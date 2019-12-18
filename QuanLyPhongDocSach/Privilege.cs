namespace QuanLiThuVien
{
    class Quyen
    {
        public static Quyen Instance = null;

        public Quyen(DataAccess.DataObject.Quyen quyen)
        {
            ThayDoiQuyDinh = quyen.ThayDoiQuyDinh;
            ThaoTacSach = quyen.ThaoTacSach;
            TimSach = quyen.TimSach;
            MuonTraSach = quyen.MuonTraSach;
            ThaoTacDocGia = quyen.ThaoTacDocGia;
            TimDocGia = quyen.TimDocGia;
            BaoCao = quyen.BaoCao;
        }

        public bool ThayDoiQuyDinh { get; set; }
        public bool ThaoTacSach { get; set; }
        public bool TimSach { get; set; }
        public bool MuonTraSach { get; set; }
        public bool ThaoTacDocGia { get; set; }
        public bool TimDocGia { get; set; }
        public bool BaoCao { get; set; }
    }
}
