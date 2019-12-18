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
    public partial class ThongTinSach : Form
    {
        private DataAccess.DataObject.Sach sach;
        public ThongTinSach()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button_THOAT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_NHAPMOI_Click(object sender, EventArgs e)
        {
            textBox_Kho.Text = null;
            textBox_MaSach.Text = null;
            textBox_NamXuatBan.Text = null;
            textBox_NhaXuatBan.Text = null;
            textBox_TacGia.Text = null;
            textBox_TriGia.Text = null;
            textBox_TheLoai.Text = null;
            textBox_MaSach.Text = null;
        }

        private void button_NHAPLIEU_Click(object sender, EventArgs e)
        {
            sach.MaSach = textBox_MaSach.Text;
            sach.NamXB = Convert.ToInt32(textBox_NamXuatBan.Text);
            sach.NXB = textBox_NhaXuatBan.Text;
            sach.SoLuong = Convert.ToInt32 (numericUpDown_SoLuongNhap.Value) ;
            sach.NgayNhap = dateTimePicker_NgayNhap.Value;
            sach.TacGia.TenTacGia = textBox_TacGia.Text;
            sach.TenSach = textBox_TenSach.Text;
            sach.TheLoai.TenTheLoai = textBox_TheLoai.Text;
        }

        private void dateTimePicker_NgayNhap_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_NgayNhap.Value = DateTime.Now;
        }

        private void ThongTinSach_Load(object sender, EventArgs e)
        {

        }
    }
}
