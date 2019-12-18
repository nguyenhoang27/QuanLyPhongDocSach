using System;

namespace DataAccess.DataObject {
	/// <summary>
	/// thông tin sách được lưu trong bảng Sach
	/// </summary>
	public class Sach {
		public string MaSach { get; set; }
		public string TenSach { get; set; }
		public TheLoai TheLoai { get; set; }
		public TacGia TacGia { get; set; }
		public int NamXB { get; set; }
		public string NXB { get; set; }
		public DateTime NgayNhap { get; set; }
		public int TriGia { get; set; }
		public int SoLuong { get; set; }
		public string TinhTrang { get; set; }
		public override string ToString() {
			System.Text.StringBuilder result = new System.Text.StringBuilder();
			result.AppendLine("Mã sách : " + MaSach);
			result.AppendLine("Tên sách : " + TenSach);
			result.AppendLine("Tác giả : " + TacGia.TenTacGia);
			result.AppendLine("Thể loại : " + TheLoai.TenTheLoai);
			return result.ToString();
		}
	}
}