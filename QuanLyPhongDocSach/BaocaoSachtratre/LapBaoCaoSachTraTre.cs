using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using DataAccess.DataObject;
using MaterialSkin;

namespace QuanLiThuVien.BaocaoSachtratre
{
    public partial class LapBaoCaoSachTraTre : MaterialSkin.Controls.MaterialForm
    {
        public LapBaoCaoSachTraTre()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        private void LapBaoCaoSachTraTre_Load(object sender, EventArgs e)
        {
            //tạo mã báo cáo
            textBox_mabaocao.Text = DataAccess.RandomIdGenerator.GetBase36(10);
            dateTimePicker_ngaylapbaocao.Value = DateTime.Now;
            var songaymuontoida = int.Parse(DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoNgaymuonToida").NoiDungQuiDinh);
            var danhsacthongtinmuonsach = DataAccess.Database.GetThongTinMuonSachs
                (x => DateTime.Now.AddDays(songaymuontoida) > x.NgayMuon).ToList();

            //hiển thị thông tin lên listview
            foreach (var ttms in danhsacthongtinmuonsach)
            {
                ListViewItem lvi = new ListViewItem(listView_sachtratre.Items.Count.ToString());
                lvi.SubItems.Add(ttms.Sach.MaSach);
                lvi.SubItems.Add(ttms.DocGia.MaTheDG);
                lvi.SubItems.Add(ttms.NgayMuon.ToShortDateString());
                var songaymuon = (DateTime.Now - ttms.NgayMuon.AddDays(songaymuontoida)).Days;
                lvi.SubItems.Add((songaymuon < 0 ? 0 : songaymuon).ToString());
                listView_sachtratre.Items.Add(lvi);
            }

            LapBaoCao(textBox_mabaocao.Text);
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(
Primary.Blue500, Primary.BlueGrey900,
Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public static BaocaoThongkeSachTraTre LapBaoCao(string mabaocao)
        {
            //lấy số ngày mượn tối đa từ quy định
            var songaymuontoida = int.Parse(DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoNgaymuonToida").NoiDungQuiDinh);
            //querry những lượt mượn sách mà có số ngày mượn lớn hơn số ngày mượn tối đa
            var danhsacthongtinmuonsach = DataAccess.Database.GetThongTinMuonSachs
                (x => DateTime.Now.AddDays(songaymuontoida) > x.NgayMuon).ToList();
            //tạo báo cáo để lưu vào csdl
            var baocao = new DataAccess.DataObject.BaocaoThongkeSachTraTre()
            {
                MaBaoCao = mabaocao,
                NgayLapBaoCao = DateTime.Now,
                DanhsachSachTraTre = danhsacthongtinmuonsach
            };
            //insert vao csdl
            DataAccess.Database.AddBaocaoThongkeSachTraTre(baocao);
            return baocao;
        }
    }
}
