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
namespace QuanLiThuVien.PhieuMuonSach
{
    public partial class PhieuMuonSach : Form
    {
        private DataAccess.DataObject.DocGia DocGia;
        private DataAccess.DataObject.Sach Sach;
        private DataAccess.DataObject.QuyDinh QuyDinh;
        public PhieuMuonSach()
        {
            InitializeComponent();
        }
        private void dateTimePicker_NgayMuon_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_NgayMuon.Value = DateTime.Now;
        }

        private void dateTimePicker_HanTra_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker_HanTra.Value = dateTimePicker_HanTra.Value.AddDays(4);
        }

        private void textBox_HoTenDocGia_TextChanged(object sender, EventArgs e)
        {
            if(textBox_HoTenDocGia.Text != null)
            {
                dateTimePicker_NgaySinh.Value = DocGia.NgaySinh;
                dateTimePicker_NgayLapThe.Value = DocGia.NgayLapThe;
                textBox_LoaiDocGia.Text = DocGia.LoaiDG.TenLoaiDocGia;
            }
            

        }

        private void button_Muon_Click(object sender, EventArgs e)
        {
            
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_HoTenDocGia.Text = null;
            textBox_LoaiDocGia.Text = null;
            dateTimePicker_NgayLapThe = null;
            dateTimePicker_NgaySinh = null;
            textBox_TenSach.Text = null;
        }
        private void listView_DanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TenSach_TextChanged(object sender, EventArgs e)
        {
            if(textBox_TenSach != null)
            {
                DataAccess.Database.GetSach(Sach.TenSach);
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(Sach.MaSach);
                item.SubItems.Add(Sach.TenSach);
                item.SubItems.Add(Sach.TheLoai.TenTheLoai);
                item.SubItems.Add(Sach.TacGia.TenTacGia);
                item.SubItems.Add(Sach.TinhTrang);
            }
        }

        private void PhieuMuonSach_Load(object sender, EventArgs e)
        {

        }

      
    }
}
