namespace QuanLiThuVien.ThongTinSach
{
    partial class TimKiemSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MaSach = new System.Windows.Forms.TextBox();
            this.groupBox_Sach = new System.Windows.Forms.GroupBox();
            this.listView_Sach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_TIMKIEM = new System.Windows.Forms.Button();
            this.button_THOAT = new System.Windows.Forms.Button();
            this.groupBox_Sach.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // textBox_MaSach
            // 
            this.textBox_MaSach.Location = new System.Drawing.Point(96, 36);
            this.textBox_MaSach.Name = "textBox_MaSach";
            this.textBox_MaSach.Size = new System.Drawing.Size(144, 20);
            this.textBox_MaSach.TabIndex = 2;
            // 
            // groupBox_Sach
            // 
            this.groupBox_Sach.Controls.Add(this.listView_Sach);
            this.groupBox_Sach.Location = new System.Drawing.Point(16, 95);
            this.groupBox_Sach.Name = "groupBox_Sach";
            this.groupBox_Sach.Size = new System.Drawing.Size(426, 125);
            this.groupBox_Sach.TabIndex = 4;
            this.groupBox_Sach.TabStop = false;
            this.groupBox_Sach.Text = "Thông Tin Sách";
            // 
            // listView_Sach
            // 
            this.listView_Sach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Sach.Location = new System.Drawing.Point(6, 19);
            this.listView_Sach.Name = "listView_Sach";
            this.listView_Sach.Size = new System.Drawing.Size(414, 100);
            this.listView_Sach.TabIndex = 0;
            this.listView_Sach.UseCompatibleStateImageBehavior = false;
            this.listView_Sach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sách";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sách";
            this.columnHeader2.Width = 141;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tác Giả";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thể Loại";
            this.columnHeader4.Width = 86;
            // 
            // button_TIMKIEM
            // 
            this.button_TIMKIEM.Location = new System.Drawing.Point(136, 233);
            this.button_TIMKIEM.Name = "button_TIMKIEM";
            this.button_TIMKIEM.Size = new System.Drawing.Size(75, 30);
            this.button_TIMKIEM.TabIndex = 5;
            this.button_TIMKIEM.Text = "TÌM KIẾM";
            this.button_TIMKIEM.UseVisualStyleBackColor = true;
            this.button_TIMKIEM.Click += new System.EventHandler(this.button_TIMKIEM_Click);
            // 
            // button_THOAT
            // 
            this.button_THOAT.Location = new System.Drawing.Point(284, 233);
            this.button_THOAT.Name = "button_THOAT";
            this.button_THOAT.Size = new System.Drawing.Size(75, 30);
            this.button_THOAT.TabIndex = 6;
            this.button_THOAT.Text = "THOAT";
            this.button_THOAT.UseVisualStyleBackColor = true;
            this.button_THOAT.Click += new System.EventHandler(this.button_THOAT_Click);
            // 
            // TimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 275);
            this.Controls.Add(this.button_THOAT);
            this.Controls.Add(this.button_TIMKIEM);
            this.Controls.Add(this.groupBox_Sach);
            this.Controls.Add(this.textBox_MaSach);
            this.Controls.Add(this.label1);
            this.Name = "TimKiemSach";
            this.Text = "TimKiemSach";
            this.groupBox_Sach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MaSach;
        private System.Windows.Forms.GroupBox groupBox_Sach;
        private System.Windows.Forms.ListView listView_Sach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button_TIMKIEM;
        private System.Windows.Forms.Button button_THOAT;
    }
}