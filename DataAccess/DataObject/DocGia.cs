using System;

namespace DataAccess.DataObject {
	/// <summary>
	/// đối tượng Độc Giả được lưu trong bảng DocGia
	/// </summary>
	public class DocGia {
		public string MaTheDG { get; set; }
		public string HoTen { get; set; }
		public DateTime NgaySinh { get; set; }
		public string DiaChi { get; set; }
		public string Email { get; set; }
		public LoaiDocGia LoaiDG { get; set; }
		public DateTime NgayLapThe { get; set; }
		public DateTime NgayHetHan { get; set; }
		public int TongNo { get; set; }
		public override string ToString() {
			System.Text.StringBuilder result = new System.Text.StringBuilder();
			result.AppendLine("Mã thẻ : " + MaTheDG);
			result.AppendLine("Họ tên : " + HoTen);
			result.AppendLine("Loại đọc giả : " + LoaiDG.TenLoaiDocGia);
			result.AppendLine("Địa chỉ : " + DiaChi);
			result.AppendLine("Email : " + Email);
			result.AppendLine("Ngày lập thẻ : " + NgayLapThe.ToString(@"dd-MM-yyyy"));
			result.AppendLine("Ngày hết hạn : " + NgayHetHan.ToString(@"dd-MM-yyyy"));
			return result.ToString();
		}
	}
}
