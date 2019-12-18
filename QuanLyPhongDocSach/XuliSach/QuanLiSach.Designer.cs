namespace QuanLiThuVien.XuliSach {
	partial class QuanLiSach {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.button_themsach = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listView_danhsachsach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_capnhatsach = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button_xoasach = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button_timdocgia = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox_MaSach = new System.Windows.Forms.TextBox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_copyMaSach = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_tenSach = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_themsach
            // 
            this.button_themsach.Depth = 0;
            this.button_themsach.Location = new System.Drawing.Point(12, 66);
            this.button_themsach.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_themsach.Name = "button_themsach";
            this.button_themsach.Primary = true;
            this.button_themsach.Size = new System.Drawing.Size(95, 39);
            this.button_themsach.TabIndex = 1;
            this.button_themsach.Text = "Thêm sách";
            this.button_themsach.UseVisualStyleBackColor = true;
            this.button_themsach.Click += new System.EventHandler(this.button_themsach_Click);
            // 
            // listView_danhsachsach
            // 
            this.listView_danhsachsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_danhsachsach.FullRowSelect = true;
            this.listView_danhsachsach.HideSelection = false;
            this.listView_danhsachsach.Location = new System.Drawing.Point(12, 207);
            this.listView_danhsachsach.Name = "listView_danhsachsach";
            this.listView_danhsachsach.Size = new System.Drawing.Size(534, 206);
            this.listView_danhsachsach.TabIndex = 5;
            this.listView_danhsachsach.UseCompatibleStateImageBehavior = false;
            this.listView_danhsachsach.View = System.Windows.Forms.View.Details;
            this.listView_danhsachsach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_sach_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã sách";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên sách";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thể loại";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tác giả";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tình trạng";
            this.columnHeader6.Width = 69;
            // 
            // button_capnhatsach
            // 
            this.button_capnhatsach.Depth = 0;
            this.button_capnhatsach.Location = new System.Drawing.Point(113, 66);
            this.button_capnhatsach.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_capnhatsach.Name = "button_capnhatsach";
            this.button_capnhatsach.Primary = true;
            this.button_capnhatsach.Size = new System.Drawing.Size(100, 39);
            this.button_capnhatsach.TabIndex = 2;
            this.button_capnhatsach.Text = "Cập nhật sách";
            this.button_capnhatsach.UseVisualStyleBackColor = true;
            this.button_capnhatsach.Click += new System.EventHandler(this.button_capnhatsach_Click);
            // 
            // button_xoasach
            // 
            this.button_xoasach.Depth = 0;
            this.button_xoasach.Location = new System.Drawing.Point(219, 66);
            this.button_xoasach.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_xoasach.Name = "button_xoasach";
            this.button_xoasach.Primary = true;
            this.button_xoasach.Size = new System.Drawing.Size(95, 39);
            this.button_xoasach.TabIndex = 3;
            this.button_xoasach.Text = "Xóa sách";
            this.button_xoasach.UseVisualStyleBackColor = true;
            this.button_xoasach.Click += new System.EventHandler(this.button_xoasach_Click);
            // 
            // button_timdocgia
            // 
            this.button_timdocgia.Depth = 0;
            this.button_timdocgia.Location = new System.Drawing.Point(192, 170);
            this.button_timdocgia.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_timdocgia.Name = "button_timdocgia";
            this.button_timdocgia.Primary = true;
            this.button_timdocgia.Size = new System.Drawing.Size(95, 32);
            this.button_timdocgia.TabIndex = 4;
            this.button_timdocgia.Text = "Tìm sách";
            this.button_timdocgia.UseVisualStyleBackColor = true;
            this.button_timdocgia.Click += new System.EventHandler(this.button_timsach_Click);
            // 
            // textBox_MaSach
            // 
            this.textBox_MaSach.Location = new System.Drawing.Point(105, 141);
            this.textBox_MaSach.Name = "textBox_MaSach";
            this.textBox_MaSach.Size = new System.Drawing.Size(100, 20);
            this.textBox_MaSach.TabIndex = 0;
            this.textBox_MaSach.TextChanged += new System.EventHandler(this.textBox_MaSach_TextChanged);
            this.textBox_MaSach.Enter += new System.EventHandler(this.textBox_MaSach_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(33, 142);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã sách";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_copyMaSach});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(150, 26);
            // 
            // toolStripMenuItem_copyMaSach
            // 
            this.toolStripMenuItem_copyMaSach.Name = "toolStripMenuItem_copyMaSach";
            this.toolStripMenuItem_copyMaSach.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem_copyMaSach.Text = "Copy mã sách";
            this.toolStripMenuItem_copyMaSach.Click += new System.EventHandler(this.toolStripMenuItem_copyMaSach_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(284, 140);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(70, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Tên sách";
            // 
            // textBox_tenSach
            // 
            this.textBox_tenSach.Location = new System.Drawing.Point(360, 141);
            this.textBox_tenSach.Name = "textBox_tenSach";
            this.textBox_tenSach.Size = new System.Drawing.Size(100, 20);
            this.textBox_tenSach.TabIndex = 13;
            this.textBox_tenSach.TextChanged += new System.EventHandler(this.textBox_tenSach_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(37, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Tìm theo Mã/Tên";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // QuanLiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 416);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_tenSach);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_MaSach);
            this.Controls.Add(this.button_timdocgia);
            this.Controls.Add(this.button_xoasach);
            this.Controls.Add(this.button_capnhatsach);
            this.Controls.Add(this.listView_danhsachsach);
            this.Controls.Add(this.button_themsach);
            this.MaximizeBox = false;
            this.Name = "QuanLiSach";
            this.Text = "Quản lí sách";
            this.Load += new System.EventHandler(this.ThaoTacSach_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialRaisedButton button_themsach;
		private System.Windows.Forms.ListView listView_danhsachsach;
		private MaterialSkin.Controls.MaterialRaisedButton button_capnhatsach;
		private MaterialSkin.Controls.MaterialRaisedButton button_xoasach;
		private MaterialSkin.Controls.MaterialRaisedButton button_timdocgia;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.TextBox textBox_MaSach;
		private MaterialSkin.Controls.MaterialLabel label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_copyMaSach;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox textBox_tenSach;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}