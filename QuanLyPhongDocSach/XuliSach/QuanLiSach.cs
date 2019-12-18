using MaterialSkin;
using QuanLiThuVien.XuliTheDocGia;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace QuanLiThuVien.XuliSach
{
    public partial class QuanLiSach: MaterialSkin.Controls.MaterialForm
    {
        public QuanLiSach()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        private void button_themsach_Click(object sender, EventArgs e)
        {
            new LapSach().ShowDialog();
            PopulateListView(GetAll());
            //update listview
        }

        private void button_capnhatsach_Click(object sender, EventArgs e)
        {
            var slvis = listView_danhsachsach.SelectedItems;
            foreach (ListViewItem slvi in slvis)
            {
                var masach = slvi.SubItems[1].Text;
                new CapNhatSach(masach).ShowDialog();
            }
            PopulateListView(GetAll());
            //get selected item
            //new CapNhatTheDocGia().Show();
            //update listview
        }

        private void button_xoasach_Click(object sender, EventArgs e)
        {
            var slvis = listView_danhsachsach.SelectedItems;
            var danhsachsachcanxoa = new List<string>();
            foreach (ListViewItem slvi in slvis)
            {
                danhsachsachcanxoa.Add(slvi.SubItems[1].Text);
            }

            var result = MessageBox.Show("Bạn có muốn xóa những sách sau?\n" + string.Join("\n", danhsachsachcanxoa), "Xóa sách", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            StringBuilder deletedsach = new StringBuilder();
            deletedsach.AppendLine("Đã xóa các sách có mã: ");
            foreach (var masach in danhsachsachcanxoa)
            {
                DataAccess.Database.RemoveSach(masach);
                deletedsach.AppendLine(masach);
            }
            MessageBox.Show(deletedsach.ToString());
            PopulateListView(GetAll());
            //get selected item
            //delete from database
            //update listview
        }

        private void button_timsach_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                PopulateListView(GetQuerry(x => x.MaSach.Contains(textBox_MaSach.Text)));
            }
            else
            {
                if (textBox_tenSach.Text.Length == 0)
                {
                    MessageBox.Show("Tên sách không hợp lệ");
                    return;
                }
                PopulateListView(GetQuerry(x => x.TenSach.Contains(textBox_tenSach.Text)));
            }
         
            //generate querry, just querry madg for now
            //update listview
        }

        private void ThaoTacSach_Load(object sender, EventArgs e)
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

            if (!quyen.ThaoTacSach)
            {
                button_themsach.Enabled = false;
                button_themsach.Visible = false;
                button_capnhatsach.Enabled = false;
                button_capnhatsach.Visible = false;
                button_xoasach.Enabled = false;
                button_xoasach.Visible = false;
            }
        }

        private void PopulateListView(List<ListViewItem> lvis)
        {
            if (lvis.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sách");
            }

            listView_danhsachsach.Items.Clear();
            foreach (var lvi in lvis)
            {
                listView_danhsachsach.Items.Add(lvi);
            }
        }

        private List<ListViewItem> GetAll()
        {
            var lvis = new List<ListViewItem>();
            foreach (var s in DataAccess.Database.GetAllSach())
            {
                ListViewItem item = new ListViewItem(lvis.Count.ToString());
                item.SubItems.Add(s.MaSach);
                item.SubItems.Add(s.TenSach);
                item.SubItems.Add(s.TheLoai.TenTheLoai);
                item.SubItems.Add(s.TacGia.TenTacGia);
                item.SubItems.Add(s.TinhTrang);
                lvis.Add(item);
            }
            return lvis;
        }

        private List<ListViewItem> GetQuerry(Expression<Func<DataAccess.DataObject.Sach, bool>> dieukienloc)
        {
            var lvis = new List<ListViewItem>();
            foreach (var s in DataAccess.Database.GetSachs(dieukienloc))
            {
                ListViewItem item = new ListViewItem(lvis.Count.ToString());
                item.SubItems.Add(s.MaSach);
                item.SubItems.Add(s.TenSach);
                item.SubItems.Add(s.TheLoai.TenTheLoai);
                item.SubItems.Add(s.TacGia.TenTacGia);
                item.SubItems.Add(s.TinhTrang);
                lvis.Add(item);
            }
            return lvis;
        }

        private void listView_sach_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView_danhsachsach.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void toolStripMenuItem_copyMaSach_Click(object sender, EventArgs e)
        {
            var masach = listView_danhsachsach.SelectedItems[0].SubItems[1].Text;
            Clipboard.SetText(masach);
        }

        private void textBox_MaSach_Enter(object sender, EventArgs e)
        {
            textBox_MaSach.Enabled = true;
            textBox_tenSach.Enabled = false;
        }


        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_MaSach.Enabled = true;
                textBox_tenSach.Enabled = false;
            }else
            {
                textBox_tenSach.Enabled = true;
                textBox_MaSach.Enabled = false;
            }
        }

        private void textBox_MaSach_TextChanged(object sender, EventArgs e)
        {
            if(textBox_MaSach.Text.Length==0)
            {
                button_capnhatsach_Click(null, null);
            }
        }

        private void textBox_tenSach_TextChanged(object sender, EventArgs e)
        {
            if (textBox_tenSach.Text.Length == 0)
            {
                button_capnhatsach_Click(null, null);
            }
        }
    }
}
