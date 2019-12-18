using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataAccess;
using MaterialSkin;

namespace QuanLiThuVien {
	public partial class LapTheDocGia: MaterialSkin.Controls.MaterialForm {
		public LapTheDocGia() {
			InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

		private void LapTheDocGia_Load(object sender, EventArgs e) {
			textBox_MaDocGia.Text = RandomIdGenerator.GetBase36(10);
			dateTimePicker_NgayLapThe.Value = DateTime.Today;
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(
Primary.Blue500, Primary.BlueGrey900,
Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            //groupBox_LoaiDocGia.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
        }

		private void button_LapThe_Click(object sender, EventArgs e) {
			if (CheckInfo()) {
				var docgia = new DataAccess.DataObject.DocGia() {
					MaTheDG = textBox_MaDocGia.Text,
					HoTen = textBox_HoTen.Text,
					LoaiDG = new DataAccess.DataObject.LoaiDocGia() { TenLoaiDocGia = textBox_TenLoaiDocGia.Text },
					NgaySinh = dateTimePicker_NgaySinh.Value,
					DiaChi = textBox_DiaChi.Text,
					Email = textBox_Email.Text,
					NgayLapThe = dateTimePicker_NgayLapThe.Value,
					NgayHetHan = dateTimePicker_NgayHetHan.Value,
					TongNo = int.Parse(textBox_TongNo.Text)
				};
				Database.AddDocGia(docgia);

				var isPrint = MessageBox.Show("Bạn có muốn in thẻ đọc giả không ?", "", MessageBoxButtons.YesNo);
				if (isPrint == DialogResult.Yes) {
					MessageBox.Show("saved to " + Printer.Print(docgia.ToString()));
				}
				Close();
			}
		}

		private void button_Huy_Click(object sender, EventArgs e) {
			Close();
		}

		private bool CheckInfo() {

			if (string.IsNullOrWhiteSpace(textBox_HoTen.Text)) {
				MessageBox.Show("Họ tên không thể để trống");
				goto f;
			}

			var tuoi = DateTime.Today.Year - dateTimePicker_NgaySinh.Value.Year;
			int tuoitoithieu;
			int.TryParse(Database.GetQuyDinh(x => x.TenQuiDinh == "TuoiToithieu").NoiDungQuiDinh, out tuoitoithieu);
			int tuoitoida;
			int.TryParse(Database.GetQuyDinh(x => x.TenQuiDinh == "TuoiToida").NoiDungQuiDinh, out tuoitoida);
			if (tuoi < tuoitoithieu || tuoi > tuoitoida) {
				MessageBox.Show(string.Format("Tuổi đọc giả phải từ {0} tới {1}", tuoitoithieu, tuoitoida));
				goto f;
			}

			if (string.IsNullOrWhiteSpace(textBox_DiaChi.Text)) {
				MessageBox.Show("Địa chỉ không thể để trống");
				goto f;
			}
			int tongno;
			if (!int.TryParse(textBox_TongNo.Text, out tongno)) {
				MessageBox.Show("Tổng nợ không hợp lệ");
				goto f;
			}

			return true;

f:
			return false;
		}

		private void dateTimePicker_NgayLapThe_ValueChanged(object sender, EventArgs e) {
			dateTimePicker_NgayHetHan.Value = dateTimePicker_NgayLapThe.Value.AddMonths(6);
		}

		private void radioButton_X_CheckedChanged(object sender, EventArgs e) {
			if (radioButton_X.Checked) {
				textBox_TenLoaiDocGia.Text = "X";
			}
		}

		private void radioButton_Y_CheckedChanged(object sender, EventArgs e) {
			if (radioButton_Y.Checked) {
				textBox_TenLoaiDocGia.Text = "Y";
			}
		}
	}
}
