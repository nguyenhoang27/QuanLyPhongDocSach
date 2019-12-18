using DataAccess.DataObject;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.BaocaoSachtratre {
	public partial class QuanliBaocaoThongkeSachTratre: MaterialSkin.Controls.MaterialForm {
		public QuanliBaocaoThongkeSachTratre() {
			InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

		private void QuanliBaocaoThongkeSachTratre_Load(object sender, EventArgs e) {
			PopulateListView(GetAll());
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(
Primary.Blue500, Primary.BlueGrey900,
Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

		private void button_lapbaocao_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            //var baocaos = DataAccess.Database.GetBaocaoThongkeSachTraTres(bc => bc.NgayLapBaoCao.Year == now.Year && bc.NgayLapBaoCao.Month == now.Month && bc.NgayLapBaoCao.Day == now.Day).ToList();
            var baocaos = new List<BaocaoThongkeSachTraTre>();
            foreach (var bc in DataAccess.Database.GetAllBaocaoThongkeSachTraTre())
            {
                if (bc.NgayLapBaoCao.Year == now.Year && bc.NgayLapBaoCao.Month == now.Month && bc.NgayLapBaoCao.Day == now.Day)
                {
                    baocaos.Add(bc);
                }
            }
            if (baocaos.Count != 0)
            {
                MessageBox.Show("Báo cáo hôm nay đã được lập rồi!\nBáo cáo hôm nay: " + baocaos[0].MaBaoCao);
                return;
            }

            new LapBaoCaoSachTraTre().ShowDialog();
			PopulateListView(GetAll());
		}

		private void button_xembaocao_Click(object sender, EventArgs e) {
			if (listView_baocao.SelectedItems.Count == 0) {
				return;
			}
			var sbc = listView_baocao.SelectedItems[0];
			new XemBaoCaoSachTraTre(sbc.SubItems[1].Text).ShowDialog();
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
			foreach (var bc in DataAccess.Database.GetAllBaocaoThongkeSachTraTre()) {
				ListViewItem item = new ListViewItem(lvis.Count.ToString());
				item.SubItems.Add(bc.MaBaoCao);
				item.SubItems.Add(bc.NgayLapBaoCao.ToShortDateString());
				item.SubItems.Add(bc.DanhsachSachTraTre.Count.ToString());
				lvis.Add(item);
			}
			return lvis;
		}

		private List<ListViewItem> GetQuerry(Expression<Func<DataAccess.DataObject.BaocaoThongkeSachTraTre, bool>> dieukienloc) {
			var lvis = new List<ListViewItem>();
			foreach (var bc in DataAccess.Database.GetBaocaoThongkeSachTraTres(dieukienloc)) {
				ListViewItem item = new ListViewItem(lvis.Count.ToString());
				item.SubItems.Add(bc.MaBaoCao);
				item.SubItems.Add(bc.NgayLapBaoCao.ToShortDateString());
				item.SubItems.Add(bc.DanhsachSachTraTre.Count.ToString());
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
