using CrystalDecisions.Shared;
using System;
using System.Linq;

namespace QuanLiThuVien
{
    static class Printer
    {
        public static string Print(string content)
        {
            string filename = "print_" + DateTime.Now.ToString(@"dd_MM_yyyy_HH_mm") + ".txt";
            System.IO.File.WriteAllText(filename, content);
            return filename;
        }

        public static void Print(DataAccess.DataObject.BaocaoThongkeSachTraTre baocao, string rptfile)
        {
            var songaymuontoida = int.Parse(DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoNgaymuonToida").NoiDungQuiDinh);
            DataSetBaoCao dataSetBaoCao = new DataSetBaoCao();
            var dr = dataSetBaoCao.BaoCaoSachTraTre.NewRow();
            dr["MaBaoCao"] = baocao.MaBaoCao;
            dr["NgayLapBaoCao"] = baocao.NgayLapBaoCao;
            dr["DanhSachSachMuon"] = string.Join("\n", baocao.DanhsachSachTraTre.Select(s =>
            {
                var songaymuon = (DateTime.Now - s.NgayMuon.AddDays(songaymuontoida)).Days;
                if (songaymuon < 0)
                {
                    songaymuon = 0;
                }
                return s.DocGia.MaTheDG + "\t" + s.Sach.MaSach + "\t" + songaymuon;
            }));
            dataSetBaoCao.BaoCaoSachTraTre.Rows.Add(dr);

            CrystalReport2 objrpt = new CrystalReport2();
            objrpt.SetDataSource(dataSetBaoCao.Tables[0]);

            try
            {
                ExportOptions CrExportOptions;
                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                CrDiskFileDestinationOptions.DiskFileName = rptfile;
                CrExportOptions = objrpt.ExportOptions;
                {
                    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                    CrExportOptions.FormatOptions = CrFormatTypeOptions;
                }
                objrpt.Export();
            }
            catch (Exception)
            {

            }
        }
    }
}
