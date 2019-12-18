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

namespace QuanLiThuVien.BaocaoSachMuonTheoTheloai {
	public partial class LapBaocaoSachMuonTheoTheloai: MaterialSkin.Controls.MaterialForm {
		public LapBaocaoSachMuonTheoTheloai() {
			InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

		private void LapBaocaoSachMuonTheoTheloai_Load(object sender, EventArgs e) {
			//tạo mã báo cáo
			textBox_mabaocao.Text = DataAccess.RandomIdGenerator.GetBase36(10);
			dateTimePicker_ngaylapbaocao.Value = DateTime.Now;
			//querry tất cả lượt mượn sách
			var danhsacthongtinmuonsach = DataAccess.Database.GetAllThongTinMuonSach();
			//thống kê thể loại theo lượt mượn
			List<DataAccess.DataObject.BaocaoSachMuonTheoTheloai.SoLuotmuonCuaTheLoai> danhsach = new List<DataAccess.DataObject.BaocaoSachMuonTheoTheloai.SoLuotmuonCuaTheLoai>();
			Dictionary<DataAccess.DataObject.TheLoai, int> danhsachsoluotmuontheotheloai = new Dictionary<DataAccess.DataObject.TheLoai, int>();
			foreach (var ttms in danhsacthongtinmuonsach) {
				if (danhsachsoluotmuontheotheloai.ContainsKey(ttms.Sach.TheLoai)) {
					danhsachsoluotmuontheotheloai[ttms.Sach.TheLoai]++;
				}
				else {
					danhsachsoluotmuontheotheloai.Add(ttms.Sach.TheLoai, 1);
				}
			}
			var tongsoluotmuonsach = danhsachsoluotmuontheotheloai.Values.Sum();
			textBox_tongluotmuon.Text = tongsoluotmuonsach.ToString();
			foreach (var kvp in danhsachsoluotmuontheotheloai) {
				danhsach.Add(new DataAccess.DataObject.BaocaoSachMuonTheoTheloai.SoLuotmuonCuaTheLoai() {
					TheLoai = kvp.Key,
					SoLuotMuon = kvp.Value,
					TiLe = (float)kvp.Value / tongsoluotmuonsach * 100
				});
			}

			//hiển thị thông tin lên listview
			foreach (var ttms in danhsach) {
				ListViewItem lvi = new ListViewItem(listView_theloaitheoluotmuon.Items.Count.ToString());
				lvi.SubItems.Add(ttms.TheLoai.TenTheLoai);
				lvi.SubItems.Add(ttms.SoLuotMuon.ToString());
				lvi.SubItems.Add(ttms.TiLe.ToString());
				listView_theloaitheoluotmuon.Items.Add(lvi);
			}
			//tạo báo cáo để lưu vào csdl
			var baocao = new DataAccess.DataObject.BaocaoSachMuonTheoTheloai() {
				MaBaoCao = textBox_mabaocao.Text,
				NgayLapBaoCao = dateTimePicker_ngaylapbaocao.Value,
				TongSoluotMuon = tongsoluotmuonsach,
				DanhsachSachMuonTheoTheloai = danhsach
			};
			//insert vao csdl
			DataAccess.Database.AddBaocaoSachMuonTheoTheloai(baocao);
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(
Primary.Blue500, Primary.BlueGrey900,
Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
	}
}
