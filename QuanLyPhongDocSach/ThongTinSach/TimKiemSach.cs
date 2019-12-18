using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataAccess;
namespace QuanLiThuVien.ThongTinSach
{
    public partial class TimKiemSach : Form
    {
        private DataAccess.DataObject.Sach sach;
        public TimKiemSach()
        {
            InitializeComponent();
        }

        private void button_THOAT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_TIMKIEM_Click(object sender, EventArgs e)
        {
            if(textBox_MaSach == null)
            {
                MessageBox.Show("Vui Lòng Nhập Mã Sách");
            }
            else
            {
                DataAccess.Database.GetSach(sach.MaSach);
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(sach.MaSach);
                item.SubItems.Add(sach.TenSach);
                item.SubItems.Add(sach.TacGia.TenTacGia);
                item.SubItems.Add(sach.TheLoai.TenTheLoai);
            }
            
        }
    }
}
