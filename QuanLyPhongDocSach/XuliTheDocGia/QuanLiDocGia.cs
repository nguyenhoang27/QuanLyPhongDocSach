using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace QuanLiThuVien.XuliTheDocGia
{
    public partial class QuanLiDocGia : MaterialSkin.Controls.MaterialForm
    {
        public QuanLiDocGia()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        private void button_lapthedocgia_Click(object sender, EventArgs e)
        {
            new LapTheDocGia().ShowDialog();
            PopulateListView(GetAll());
            //update listview
        }

        private void button_capnhatdocgia_Click(object sender, EventArgs e)
        {
            var slvis = listView_docgia.SelectedItems;
            foreach (ListViewItem slvi in slvis)
            {
                new CapNhatTheDocGia(slvi.SubItems[1].Text).ShowDialog();
            }
            PopulateListView(GetAll());
            //get selected item
            //new CapNhatTheDocGia().Show();
            //update listview
        }

        private void button_xoadocgia_Click(object sender, EventArgs e)
        {
            var slvis = listView_docgia.SelectedItems;
            StringBuilder deleteddocgia = new StringBuilder();
            deleteddocgia.AppendLine("Đã xóa các đọc giả có mã: ");
            foreach (ListViewItem slvi in slvis)
            {
                DataAccess.Database.RemoveDocGia(slvi.SubItems[1].Text);
                deleteddocgia.AppendLine(slvi.SubItems[1].Text);
            }
            MessageBox.Show(deleteddocgia.ToString());
            PopulateListView(GetAll());
            //get selected item
            //delete from database
            //update listview
        }

        private void button_timdocgia_Click(object sender, EventArgs e)
        {
            PopulateListView(GetQuerry(x => x.MaTheDG.Contains(textBox_MaDocGia.Text)));
            //generate querry, just querry madg for now
            //update listview
        }

        private void ThaoTacDocGia_Load(object sender, EventArgs e)
        {
            PopulateListView(GetAll());

            HandleQuyen();
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(
Primary.Blue500, Primary.BlueGrey900,
Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void HandleQuyen()
        {
            var quyen = Quyen.Instance;

            if (!quyen.ThaoTacDocGia)
            {
                button_lapthedocgia.Enabled = false;
                button_lapthedocgia.Visible = false;
                button_capnhatdocgia.Enabled = false;
                button_capnhatdocgia.Visible = false;
                button_xoadocgia.Enabled = false;
                button_xoadocgia.Visible = false;
            }
        }

        private void PopulateListView(List<ListViewItem> lvis)
        {
            listView_docgia.Items.Clear();
            foreach (var lvi in lvis)
            {
                listView_docgia.Items.Add(lvi);
            }
        }

        private List<ListViewItem> GetAll()
        {
            var lvis = new List<ListViewItem>();
            foreach (var dg in DataAccess.Database.GetAllDocGia())
            {
                ListViewItem item = new ListViewItem(lvis.Count.ToString());
                item.SubItems.Add(dg.MaTheDG);
                item.SubItems.Add(dg.HoTen);
                item.SubItems.Add(dg.LoaiDG.TenLoaiDocGia);
                item.SubItems.Add(dg.NgayHetHan.ToShortDateString());
                item.SubItems.Add(dg.TongNo.ToString());
                lvis.Add(item);
            }
            return lvis;
        }

        private List<ListViewItem> GetQuerry(Expression<Func<DataAccess.DataObject.DocGia, bool>> dieukienloc)
        {
            var lvis = new List<ListViewItem>();
            foreach (var dg in DataAccess.Database.GetDocGias(dieukienloc))
            {
                ListViewItem item = new ListViewItem(lvis.Count.ToString());
                item.SubItems.Add(dg.MaTheDG);
                item.SubItems.Add(dg.HoTen);
                item.SubItems.Add(dg.LoaiDG.TenLoaiDocGia);
                item.SubItems.Add(dg.NgayHetHan.ToShortDateString());
                item.SubItems.Add(dg.TongNo.ToString());
                lvis.Add(item);
            }
            return lvis;
        }

        private void listView_docgia_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView_docgia.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip_listview.Show(Cursor.Position);
                }
            }
        }

        private void toolStripMenuItem_lapphieuthutienphat_Click(object sender, EventArgs e)
        {
            var madocgia = listView_docgia.SelectedItems[0].SubItems[1].Text;
            var result = new LapPhieuThuTienPhat(madocgia).ShowDialog();
            if (result == DialogResult.Yes)
            {
                PopulateListView(GetAll());
            }
        }

        private void toolStripMenuItem_copyMaDocGia_Click(object sender, EventArgs e)
        {
            var madocgia = listView_docgia.SelectedItems[0].SubItems[1].Text;
            Clipboard.SetText(madocgia);
        }

        private void textBox_MaDocGia_TextChanged(object sender, EventArgs e)
        {
            var slvis = listView_docgia.SelectedItems;
            foreach (ListViewItem slvi in slvis)
            {
                new CapNhatTheDocGia(slvi.SubItems[1].Text).ShowDialog();
            }
            PopulateListView(GetAll());
        }
    }
}
