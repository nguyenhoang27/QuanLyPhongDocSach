using System;

namespace DataAccess.DataObject
{
    /// <summary>
    /// phiếu trả sách được lưu trong bảng PhieuTraSach
    /// </summary>
    public class PhieuTraSach
    {
        public string MaPhieuTraSach { get; set; }
        public DocGia DocGia { get; set; }
        public DateTime NgayTra { get; set; }
        public int TienPhatKyNay { get; set; }
    }
}
