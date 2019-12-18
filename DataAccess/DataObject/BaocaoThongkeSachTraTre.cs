using System;
using System.Collections.Generic;

namespace DataAccess.DataObject {
	public class BaocaoThongkeSachTraTre {
		public string MaBaoCao { get; set; }
		public DateTime NgayLapBaoCao { get; set; }
		public List<ThongTinMuonSach> DanhsachSachTraTre { get; set; }
	}
}
