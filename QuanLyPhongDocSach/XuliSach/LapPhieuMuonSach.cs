using DataAccess;
using MaterialSkin;
using System;
using System.Text;
using System.Windows.Forms;

namespace QuanLiThuVien.XuliSach
{
    public partial class LapPhieuMuonSach: MaterialSkin.Controls.MaterialForm
    {

        public LapPhieuMuonSach()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        private void button_muon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_madocgia.Text))
            {
                MessageBox.Show("Xin nhập mã đọc giả mượn sách");
                return;
            }

            if (listView_danhsachsachmuon.Items.Count == 0)
            {
                MessageBox.Show("Xin thêm sách mượn vào");
                return;
            }

            StringBuilder phieumuonsach = new StringBuilder();
            phieumuonsach.AppendLine("Phiếu mượn sách");
            phieumuonsach.AppendLine("Mã đọc giả mượn : " + textBox_madocgia.Text);
            phieumuonsach.AppendLine("Sách mượn :");
            foreach (ListViewItem item in listView_danhsachsachmuon.Items)
            {
                var masach = item.SubItems[1].Text;
                DataAccess.DataObject.ThongTinMuonSach thongTinMuonSach = new DataAccess.DataObject.ThongTinMuonSach()
                {
                    id = RandomIdGenerator.GetBase36(10),
                    DocGia = Database.GetDocGia(textBox_madocgia.Text),
                    Sach = Database.GetSach(masach),
                    NgayMuon = dateTimePicker_ngaymuon.Value
                };
                Database.AddThongTinMuonSach(thongTinMuonSach);
                phieumuonsach.AppendFormat("{0} {1}", thongTinMuonSach.Sach.MaSach, thongTinMuonSach.Sach.TenSach);
                phieumuonsach.AppendLine();
            }

            var isprint = MessageBox.Show(phieumuonsach.ToString(), "In phiếu?", MessageBoxButtons.YesNo) == DialogResult.Yes;
            if (isprint)
            {
                MessageBox.Show("saved to " + Printer.Print(phieumuonsach.ToString()));
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_themsach_Click(object sender, EventArgs e)
        {
            if (textBox_masach.Text.Length != 10)
            {
                MessageBox.Show("Mã sách không hợp lệ");
                return;
            }

            int soluongsachtoidaduocmuon = int.Parse(Database.GetQuyDinh(x => x.TenQuiDinh == "SoluongSachDuocMuon").NoiDungQuiDinh);
            if (listView_danhsachsachmuon.Items.Count == soluongsachtoidaduocmuon - 1)
            {
                MessageBox.Show("Số lượng sách tối đa được mượn là " + soluongsachtoidaduocmuon);
                return;
            }

            var sach = Database.GetSach(textBox_masach.Text);
            if (sach == null)
            {
                MessageBox.Show("Mã sách không tồn tại");
                return;
            }

            ListViewItem sachmuon = new ListViewItem(listView_danhsachsachmuon.Items.Count.ToString());
            sachmuon.SubItems.Add(sach.MaSach);
            sachmuon.SubItems.Add(sach.TenSach);
            sachmuon.SubItems.Add(sach.TheLoai.TenTheLoai);
            sachmuon.SubItems.Add(sach.TacGia.TenTacGia);
            sachmuon.SubItems.Add(sach.TinhTrang);
            listView_danhsachsachmuon.Items.Add(sachmuon);
        }

        private void LapPhieuMuonSach_Load(object sender, EventArgs e)
        {
            dateTimePicker_ngaymuon.Value = DateTime.Now;
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(
Primary.Blue500, Primary.BlueGrey900,
Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void textBox_madocgia_TextChanged(object sender, EventArgs e)
        {
            if (textBox_madocgia.Text.Length == 10)
            {
                var docgia = Database.GetDocGia(textBox_madocgia.Text);
                if (docgia != null)
                {
                    textBox_hoten.Text = docgia.HoTen;
                }
            }
        }

        private void button_xoadssach_Click(object sender, EventArgs e)
        {
            listView_danhsachsachmuon.Items.Clear();
        }
    }
}
