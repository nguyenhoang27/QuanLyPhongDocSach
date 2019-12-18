using CrystalDecisions.Shared;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.BaocaoSachtratre
{
    public partial class XemBaoCaoSachTraTre : MaterialSkin.Controls.MaterialForm
    {
        private string mabaocao;
        public XemBaoCaoSachTraTre(string mabaocao)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
            this.mabaocao = mabaocao;
        }

        private void XemBaoCaoSachTraTre_Load(object sender, EventArgs e)
        {
            //lấy số ngày mượn tối đa từ quy định
            var songaymuontoida = int.Parse(DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoNgaymuonToida").NoiDungQuiDinh);
            //truy xuất báo cáo từ csdl
            textBox_mabaocao.Text = mabaocao;
            var baocao = DataAccess.Database.GetBaocaoThongkeSachTraTre(mabaocao);
            dateTimePicker_ngaylapbaocao.Value = baocao.NgayLapBaoCao;
            //hiển thị thông tin lên listview
            foreach (var ttms in baocao.DanhsachSachTraTre)
            {
                ListViewItem lvi = new ListViewItem(listView_sachtratre.Items.Count.ToString());
                lvi.SubItems.Add(ttms.Sach.MaSach);
                lvi.SubItems.Add(ttms.DocGia.MaTheDG);
                lvi.SubItems.Add(ttms.NgayMuon.ToShortDateString());
                var songaymuon = (DateTime.Now - ttms.NgayMuon.AddDays(songaymuontoida)).Days;
                lvi.SubItems.Add((songaymuon < 0 ? 0 : songaymuon).ToString());
                listView_sachtratre.Items.Add(lvi);
            }
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(
Primary.Blue500, Primary.BlueGrey900,
Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void button_inbaocao_Click(object sender, EventArgs e)
        {
            var baocao = DataAccess.Database.GetBaocaoThongkeSachTraTre(mabaocao);
            var songaymuontoida = int.Parse(DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoNgaymuonToida").NoiDungQuiDinh);

            var rptfile = $"report-{baocao.MaBaoCao}-{DateTime.Now.ToShortDateString()}-.pdf";

            Printer.Print(baocao, rptfile);

            MessageBox.Show("saved to " + rptfile);
        }
    }
}
