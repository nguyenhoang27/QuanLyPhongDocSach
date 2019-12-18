using DataAccess;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.XuliSach
{
    public partial class XuLiTraSach : MaterialSkin.Controls.MaterialForm
    {
        DataAccess.DataObject.DocGia docgia = null;

        public XuLiTraSach()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        private void textBox_madocgia_TextChanged(object sender, EventArgs e)
        {
            if (textBox_madocgia.Text.Length == 10)
            {
                docgia = Database.GetDocGia(textBox_madocgia.Text);
                if (docgia != null)
                {
                    textBox_hoten.Text = docgia.HoTen;
                    textBox_tongno.Text = docgia.TongNo.ToString();
                    PopulateListView(GetAllForMaDocGia(docgia.MaTheDG));
                }
            }
        }

        private void button_xuli_Click(object sender, EventArgs e)
        {
            if (docgia is null)
            {
                MessageBox.Show("Chưa nhập mã đọc giả", "!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var masachtras = GetSelectedSachTras();
            if (masachtras.Count == 0)
            {
                MessageBox.Show("Chọn sách được trả", "!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataAccess.DataObject.PhieuTraSach phieuTraSach = new DataAccess.DataObject.PhieuTraSach();
            phieuTraSach.DocGia = docgia;
            phieuTraSach.MaPhieuTraSach = RandomIdGenerator.GetBase62(10);
            phieuTraSach.NgayTra = DateTime.Now;
            phieuTraSach.TienPhatKyNay = docgia.TongNo;

            var songaymuontoida = int.Parse(Database.GetQuyDinh(x => x.TenQuiDinh == "SoNgaymuonToida").NoiDungQuiDinh);
            var tienphattratre = int.Parse(Database.GetQuyDinh(x => x.TenQuiDinh == "TienPhatTraTre").NoiDungQuiDinh);

            var thongtinsachtras = new List<DataAccess.DataObject.SachTra>();

            //foreach (var ttms in Database.GetThongTinMuonSachs(ttms => ttms.DocGia.MaTheDG == docgia.MaTheDG && sachtras.Contains(ttms.Sach.MaSach)))
            foreach (var mst in masachtras)
            {
                var ttms = Database.GetThongTinMuonSach(docgia.MaTheDG, mst);
                DataAccess.DataObject.SachTra thongtinsachtra = new DataAccess.DataObject.SachTra()
                {
                    id = RandomIdGenerator.GetBase62(10),
                    PhieuTraSach = phieuTraSach,
                    SoNgayMuon = (phieuTraSach.NgayTra - ttms.NgayMuon).Days,
                    Sach = ttms.Sach
                };
                if (thongtinsachtra.SoNgayMuon > songaymuontoida)
                {
                    thongtinsachtra.TienPhat = (thongtinsachtra.SoNgayMuon - songaymuontoida) * tienphattratre;
                }
                else
                {
                    thongtinsachtra.TienPhat = 0;
                }
                docgia.TongNo += thongtinsachtra.TienPhat;

                thongtinsachtras.Add(thongtinsachtra);
            }

            phieuTraSach.TienPhatKyNay = docgia.TongNo - phieuTraSach.TienPhatKyNay;
            StringBuilder phieutrasach = new StringBuilder();
            phieutrasach.AppendLine("Đã nhận trả những sách sau:");
            foreach (var ttst in thongtinsachtras)
            {
                Database.RemoveThongTinMuonSach(docgia.MaTheDG, ttst.Sach.MaSach);
                phieutrasach.AppendLine($"{ttst.Sach.MaSach} {ttst.Sach.TenSach}");
            }

            var dr = MessageBox.Show(phieutrasach.ToString(), "", MessageBoxButtons.OK);
            if (dr == DialogResult.OK)
            {
                phieutrasach.Append(phieuTraSach.NgayTra.ToShortDateString());
                var isprint = MessageBox.Show(phieutrasach.ToString(), "In phiếu?", MessageBoxButtons.YesNo) == DialogResult.Yes;
                if (isprint)
                {
                    MessageBox.Show("saved to " + Printer.Print(phieutrasach.ToString()));
                }

                PopulateListView(GetAllForMaDocGia(docgia.MaTheDG));
                if (listView_danhsachsachmuon.Items.Count == 0)
                {
                    return;
                }
            }
        }

        private List<string> GetSelectedSachTras()
        {
            List<string> masachtraduocchon = new List<string>();
            foreach (ListViewItem lvi in listView_danhsachsachmuon.SelectedItems)
            {
                masachtraduocchon.Add(lvi.SubItems[1].Text);
            }
            return masachtraduocchon;
        }

        private void PopulateListView(List<ListViewItem> lvis)
        {
            listView_danhsachsachmuon.Items.Clear();
            foreach (var lvi in lvis)
            {
                listView_danhsachsachmuon.Items.Add(lvi);
            }
        }

        private List<ListViewItem> GetAllForMaDocGia(string madocgia)
        {
            var lvis = new List<ListViewItem>();

            var songaymuontoida = int.Parse(Database.GetQuyDinh(x => x.TenQuiDinh == "SoNgaymuonToida").NoiDungQuiDinh);
            var tienphattratre = int.Parse(Database.GetQuyDinh(x => x.TenQuiDinh == "TienPhatTraTre").NoiDungQuiDinh);

            foreach (var ttms in Database.GetThongTinMuonSachs(ttms => ttms.DocGia.MaTheDG == madocgia))
            {
                ListViewItem item = new ListViewItem(lvis.Count.ToString());
                item.SubItems.Add(ttms.Sach.MaSach);
                item.SubItems.Add(ttms.Sach.TenSach);
                item.SubItems.Add(ttms.NgayMuon.ToShortDateString());
                var soNgayMuon = (DateTime.Now - ttms.NgayMuon).Days;
                var tienPhat = soNgayMuon > songaymuontoida ? (soNgayMuon - songaymuontoida) * tienphattratre : 0;
                item.SubItems.Add(tienPhat.ToString());
                lvis.Add(item);
            }
            return lvis;
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void XuLiTraSach_Load(object sender, EventArgs e)
        {
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(
Primary.Blue500, Primary.BlueGrey900,
Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
    }
}
