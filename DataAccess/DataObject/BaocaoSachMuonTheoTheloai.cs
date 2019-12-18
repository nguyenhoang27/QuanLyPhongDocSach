using System;
using System.Collections.Generic;

namespace DataAccess.DataObject {
	public class BaocaoSachMuonTheoTheloai {
		public class SoLuotmuonCuaTheLoai {
			public TheLoai TheLoai { get; set; }
			public int SoLuotMuon { get; set; }
			public float TiLe { get; set; }
		}
		public string MaBaoCao { get; set; }
		public DateTime NgayLapBaoCao { get; set; }
		public int TongSoluotMuon { get; set; }
		public List<SoLuotmuonCuaTheLoai> DanhsachSachMuonTheoTheloai { get; set; }
	}
}
