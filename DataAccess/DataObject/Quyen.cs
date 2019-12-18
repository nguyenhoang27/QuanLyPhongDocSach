namespace DataAccess.DataObject
{
    /// <summary>
    /// quyen duoc luu trong quyen
    /// </summary>
    public class Quyen
    {
        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Salt
        /// </summary>
        public string Salt { get; set; }
        /// <summary>
        /// Hash
        /// </summary>
        public string Hash { get; set; }
        /// <summary>
        /// Quyền thay đổi quy định
        /// </summary>
        public bool ThayDoiQuyDinh { get; set; }
        /// <summary>
        /// Quyền thao tác sách : <para/>
        /// thêm sách<para/>
        /// cập nhật sách<para/>
        /// xóa sách<para/>
        /// </summary>
        public bool ThaoTacSach { get; set; }
        /// <summary>
        /// Quyền xem thông tin sách
        /// </summary>
        public bool TimSach { get; set; }
        /// <summary>
        /// Quyền thực hiện mượn và trả sách
        /// </summary>
        public bool MuonTraSach { get; set; }
        /// <summary>
        /// Quyền thao tác đọc giả : <para/>
        /// lập thẻ đọc giả<para/>
        /// cập nhật thông tin đọc giả<para/>
        /// xóa thông tin đọc giả<para/>
        /// </summary>
        public bool ThaoTacDocGia { get; set; }
        /// <summary>
        /// Quyền xem thông tin đọc giả
        /// </summary>
        public bool TimDocGia { get; set; }
        /// <summary>
        /// Quyền lập và xem báo cáo
        /// </summary>
        public bool BaoCao { get; set; }
    }
}
