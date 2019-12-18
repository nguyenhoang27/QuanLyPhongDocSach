using System;
using System.Windows.Forms;

using QuanLiThuVien.BaocaoSachtratre;
using QuanLiThuVien.XuliTheDocGia;
using QuanLiThuVien.XuliSach;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using DataAccess;
using MaterialSkin;

namespace QuanLiThuVien
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        QuanLiDocGia QuanLiDocGia = null;
        QuanLiSach QuanLiSach = null;
        LapPhieuMuonSach LapPhieuMuonSach = null;
        XuLiTraSach XuLiTraSach = null;
        QuanliBaocaoThongkeSachTratre QuanliBaocaoThongkeSachTratre = null;
        QuanliBaocaoSachMuonTheoTheloai QuanliBaocaoSachMuonTheoTheloai = null;

        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        private void button_docgia_Click(object sender, EventArgs e)
        {
            if (QuanLiDocGia != null)
            {
                return;
            }

            QuanLiDocGia = new QuanLiDocGia();
            QuanLiDocGia.Show();
            QuanLiDocGia.FormClosed += (o, ee) => QuanLiDocGia = null;
        }

        private void button_sach_Click(object sender, EventArgs e)
        {
            if (QuanLiSach != null)
            {
                return;
            }

            QuanLiSach = new QuanLiSach();
            QuanLiSach.Show();
            QuanLiSach.FormClosed += (o, ee) => QuanLiSach = null;
        }

        private void button_muonsach_Click(object sender, EventArgs e)
        {
            if (LapPhieuMuonSach != null)
            {
                return;
            }

            LapPhieuMuonSach = new LapPhieuMuonSach();
            LapPhieuMuonSach.Show();
            LapPhieuMuonSach.FormClosed += (o, ee) => LapPhieuMuonSach = null;
        }

        private void button_trasach_Click(object sender, EventArgs e)
        {
            if (XuLiTraSach != null)
            {
                return;
            }

            XuLiTraSach = new XuLiTraSach();
            XuLiTraSach.Show();
            XuLiTraSach.FormClosed += (o, ee) => XuLiTraSach = null;
        }

        private void button_baocao_Click(object sender, EventArgs e)
        {
            if (QuanliBaocaoThongkeSachTratre != null)
            {
                return;
            }

            QuanliBaocaoThongkeSachTratre = new QuanliBaocaoThongkeSachTratre();
            QuanliBaocaoThongkeSachTratre.Show();
            QuanliBaocaoThongkeSachTratre.FormClosed += (o, ee) => QuanliBaocaoThongkeSachTratre = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (QuanliBaocaoSachMuonTheoTheloai != null)
            {
                return;
            }

            QuanliBaocaoSachMuonTheoTheloai = new QuanliBaocaoSachMuonTheoTheloai();
            QuanliBaocaoSachMuonTheoTheloai.Show();
            QuanliBaocaoSachMuonTheoTheloai.FormClosed += (o, ee) => QuanliBaocaoSachMuonTheoTheloai = null;
        }

        DataAccess.DataObject.QuyDinh TuoiToithieu;
        DataAccess.DataObject.QuyDinh TuoiToida;
        DataAccess.DataObject.QuyDinh ThoihanThe;
        DataAccess.DataObject.QuyDinh NamXuatban;
        DataAccess.DataObject.QuyDinh SoluongSachDuocMuon;
        DataAccess.DataObject.QuyDinh SoNgaymuonToida;
        DataAccess.DataObject.QuyDinh TienPhatTraTre;

        private void MainForm_Load(object sender, EventArgs e)
        {
            TuoiToithieu = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "TuoiToithieu");
            TuoiToida = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "TuoiToida");
            ThoihanThe = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "ThoihanThe");
            NamXuatban = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "NamXuatban");
            SoluongSachDuocMuon = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoluongSachDuocMuon");
            SoNgaymuonToida = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoNgaymuonToida");
            TienPhatTraTre = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "TienPhatTraTre");

            textBox_tuoitoithieu.Text = TuoiToithieu.NoiDungQuiDinh;
            textBox_tuoitoida.Text = TuoiToida.NoiDungQuiDinh;
            textBox_thoihanthe.Text = ThoihanThe.NoiDungQuiDinh;
            textBox_namxuatban.Text = NamXuatban.NoiDungQuiDinh;
            textBox_slsachtoidadcmuon.Text = SoluongSachDuocMuon.NoiDungQuiDinh;
            textBox_songaymuontoida.Text = SoNgaymuonToida.NoiDungQuiDinh;
            textBox_tienphattre.Text = TienPhatTraTre.NoiDungQuiDinh;

            var now = DateTime.Now;
            if (now.Day == 1)
            {
                if (DataAccess.Database.GetBaocaoThongkeSachTraTres(bc => bc.NgayLapBaoCao.Year == now.Year && bc.NgayLapBaoCao.Month == now.Month && bc.NgayLapBaoCao.Day == now.Day).ToList().Count == 0)
                {
                    LapBaoCaoSachTraTre.LapBaoCao(DataAccess.RandomIdGenerator.GetBase36(10));
                }
            }

            HandleQuyen();
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(
Primary.Blue500, Primary.BlueGrey900,
Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void HandleQuyen()
        {
            var quyen = Quyen.Instance;

            if (!quyen.ThayDoiQuyDinh)
            {
                foreach(Control c in groupBox_quydinh.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Enabled = false;
                    }
                    else if (c is MaterialSkin.Controls.MaterialRaisedButton)
                    {
                        c.Enabled = false;
                        c.Visible = false;
                    }
                }
            }

            if (!quyen.TimDocGia)
            {
                button_docgia.Enabled = false;
                button_docgia.Visible = false;
            }

            if (!quyen.TimSach)
            {
                button_sach.Enabled = false;
                button_sach.Visible = false;
            }

            if (!quyen.MuonTraSach)
            {
                button_muonsach.Enabled = false;
                button_muonsach.Visible = false;
                button_trasach.Enabled = false;
                button_trasach.Visible = false;
            }

            if (!quyen.BaoCao)
            {
                button_baocao_thongketratre.Enabled = false;
                button_baocao_thongketratre.Visible = false;
                button_baocao_thongketheloaitheoluotmuon.Enabled = false;
                button_baocao_thongketheloaitheoluotmuon.Visible = false;
            }
        }

        private void button_luuquydinh_Click(object sender, EventArgs e)
        {
            TuoiToithieu.NoiDungQuiDinh = textBox_tuoitoithieu.Text;
            TuoiToida.NoiDungQuiDinh = textBox_tuoitoida.Text;
            ThoihanThe.NoiDungQuiDinh = textBox_thoihanthe.Text;
            NamXuatban.NoiDungQuiDinh = textBox_namxuatban.Text;
            SoluongSachDuocMuon.NoiDungQuiDinh = textBox_slsachtoidadcmuon.Text;
            SoNgaymuonToida.NoiDungQuiDinh = textBox_songaymuontoida.Text;
            TienPhatTraTre.NoiDungQuiDinh = textBox_tienphattre.Text;

            DataAccess.Database.SetQuyDinh(TuoiToithieu);
            DataAccess.Database.SetQuyDinh(TuoiToida);
            DataAccess.Database.SetQuyDinh(ThoihanThe);
            DataAccess.Database.SetQuyDinh(NamXuatban);
            DataAccess.Database.SetQuyDinh(SoluongSachDuocMuon);
            DataAccess.Database.SetQuyDinh(SoNgaymuonToida);
            DataAccess.Database.SetQuyDinh(TienPhatTraTre);
        }

        private void CheckTextboxNumeric(object sender, EventArgs e)
        {
            var textbox = ((TextBox)sender);
            int t = 0;
            if (!int.TryParse(textbox.Text, out t))
            {
                textbox.Undo();
            }
        }

        private void button_macdinh_Click(object sender, EventArgs e)
        {
            var quydinhdatapath = "quydinh.json";

            var dataquydinh = JsonConvert.DeserializeObject<List<quydinh>>(File.ReadAllText(quydinhdatapath));
            if (dataquydinh != null)
            {
                var qds = Database.GetQuyDinhs(qd => true);
                foreach (var qd in qds)
                {
                    Database.RemoveQuyDinh(qd.MaQuyDinh);
                }
                foreach (var qd in dataquydinh)
                {
                    Database.AddQuyDinh(new DataAccess.DataObject.QuyDinh()
                    {
                        MaQuyDinh = qd.maquydinh,
                        TenQuiDinh = qd.tenquydinh,
                        NoiDungQuiDinh = qd.noidungquydinh
                    });
                }
            }

            TuoiToithieu = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "TuoiToithieu");
            TuoiToida = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "TuoiToida");
            ThoihanThe = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "ThoihanThe");
            NamXuatban = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "NamXuatban");
            SoluongSachDuocMuon = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoluongSachDuocMuon");
            SoNgaymuonToida = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoNgaymuonToida");
            TienPhatTraTre = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "TienPhatTraTre");

            textBox_tuoitoithieu.Text = TuoiToithieu.NoiDungQuiDinh;
            textBox_tuoitoida.Text = TuoiToida.NoiDungQuiDinh;
            textBox_thoihanthe.Text = ThoihanThe.NoiDungQuiDinh;
            textBox_namxuatban.Text = NamXuatban.NoiDungQuiDinh;
            textBox_slsachtoidadcmuon.Text = SoluongSachDuocMuon.NoiDungQuiDinh;
            textBox_songaymuontoida.Text = SoNgaymuonToida.NoiDungQuiDinh;
            textBox_tienphattre.Text = TienPhatTraTre.NoiDungQuiDinh;
        }



        class quydinh
        {
            public string maquydinh { get; set; }
            public string tenquydinh { get; set; }
            public string noidungquydinh { get; set; }
        }
    }
}
