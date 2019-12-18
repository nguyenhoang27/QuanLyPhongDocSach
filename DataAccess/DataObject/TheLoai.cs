namespace DataAccess.DataObject
{
    /// <summary>
    /// thể loại được lưu trong bảng TheLoai
    /// </summary>
    public class TheLoai
    {
        public string TenTheLoai { get; set; }
        public string GhiChu { get; set; }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + TenTheLoai.GetHashCode();
                hash = hash * 23 + GhiChu == null ? 0 : (GhiChu?.GetHashCode()).GetValueOrDefault();
                return hash;
            }
        }
    }
}
