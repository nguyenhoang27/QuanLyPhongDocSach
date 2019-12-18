namespace DataAccess.DataObject
{
    /// <summary>
    /// thông tin sách được trả được lưu trong bảng SachTra
    /// </summary>
    public class SachTra
    {
        public string id { get; set; }
        public PhieuTraSach PhieuTraSach { get; set; }
        public Sach Sach { get; set; }
        public int SoNgayMuon { get; set; }
        public int TienPhat { get; set; }
    }
}
