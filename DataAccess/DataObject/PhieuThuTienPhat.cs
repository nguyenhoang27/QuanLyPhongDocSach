namespace DataAccess.DataObject {
	/// <summary>
	/// phiếu thu tiền phạt được lưu trong bảng PhieuThuTienPhat
	/// </summary>
	public class PhieuThuTienPhat {
		public string MaPhieuThuTienPhat { get; set; }
		public DocGia DocGia { get; set; }
		public int SoTienThu { get; set; }
		public override string ToString() {
			return string.Format("Mã phiếu : {1}{0}Mã đọc giả : {2}{0}Số tiền thu : {3} VND{0}", System.Environment.NewLine, MaPhieuThuTienPhat, DocGia.MaTheDG, SoTienThu);
		}
	}
}
