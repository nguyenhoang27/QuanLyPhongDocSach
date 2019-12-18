using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using MaterialSkin;
using QuanLiThuVien.BaocaoSachMuonTheoTheloai;

namespace QuanLiThuVien {
	public partial class QuanliBaocaoSachMuonTheoTheloai: MaterialSkin.Controls.MaterialForm {
		public QuanliBaocaoSachMuonTheoTheloai() {
			InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

		private void QuanliBaocaoSachMuonTheoTheloai_Load(object sender, EventArgs e) {
			PopulateListView(GetAll());
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(
Primary.Blue500, Primary.BlueGrey900,
Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

		private void button_lapbaocao_Click(object sender, EventArgs e) {
			new LapBaocaoSachMuonTheoTheloai().ShowDialog();
			PopulateListView(GetAll());
		}

		private void button_xembaocao_Click(object sender, EventArgs e) {
			if (listView_baocao.SelectedItems.Count == 0) {
				return;
			}
			var sbc = listView_baocao.SelectedItems[0];
			new XemBaocaoSachMuonTheoTheloai(sbc.SubItems[1].Text).ShowDialog();
		}

		private void button_timbaocao_Click(object sender, EventArgs e) {
			PopulateListView(GetQuerry(x => x.MaBaoCao.Contains(textBox_mabaocao.Text)));
		}

		private void PopulateListView(List<ListViewItem> lvis) {
			listView_baocao.Items.Clear();
			foreach (var lvi in lvis) {
				listView_baocao.Items.Add(lvi);
			}
		}

		private List<ListViewItem> GetAll() {
			var lvis = new List<ListViewItem>();
			foreach (var bc in DataAccess.Database.GetAllBaocaoSachMuonTheoTheloai()) {
				ListViewItem item = new ListViewItem(lvis.Count.ToString());
				item.SubItems.Add(bc.MaBaoCao);
				item.SubItems.Add(bc.NgayLapBaoCao.ToShortDateString());
				item.SubItems.Add(bc.DanhsachSachMuonTheoTheloai.Count.ToString());
				lvis.Add(item);
			}
			return lvis;
		}

		private List<ListViewItem> GetQuerry(Expression<Func<DataAccess.DataObject.BaocaoSachMuonTheoTheloai, bool>> dieukienloc) {
			var lvis = new List<ListViewItem>();
			foreach (var bc in DataAccess.Database.GetBaocaoSachMuonTheoTheloais(dieukienloc)) {
				ListViewItem item = new ListViewItem(lvis.Count.ToString());
				item.SubItems.Add(bc.MaBaoCao);
				item.SubItems.Add(bc.NgayLapBaoCao.ToShortDateString());
				item.SubItems.Add(bc.DanhsachSachMuonTheoTheloai.Count.ToString());
				lvis.Add(item);
			}
			return lvis;
		}

        private void textBox_mabaocao_TextChanged(object sender, EventArgs e)
        {
            if (textBox_mabaocao.Text.Length == 0)
                PopulateListView(GetAll());
        }
    }
}
