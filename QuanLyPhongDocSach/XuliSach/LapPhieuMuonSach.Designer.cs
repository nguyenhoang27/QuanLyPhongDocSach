namespace QuanLiThuVien.XuliSach {
	partial class LapPhieuMuonSach {
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
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_masach = new System.Windows.Forms.TextBox();
            this.button_themsach = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button_muon = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button_huy = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listView_danhsachsachmuon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_madocgia = new System.Windows.Forms.TextBox();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker_ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.button_xoadsssach = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(11, 156);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // textBox_masach
            // 
            this.textBox_masach.Location = new System.Drawing.Point(83, 155);
            this.textBox_masach.Name = "textBox_masach";
            this.textBox_masach.Size = new System.Drawing.Size(100, 20);
            this.textBox_masach.TabIndex = 1;
            // 
            // button_themsach
            // 
            this.button_themsach.Depth = 0;
            this.button_themsach.Location = new System.Drawing.Point(195, 142);
            this.button_themsach.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_themsach.Name = "button_themsach";
            this.button_themsach.Primary = true;
            this.button_themsach.Size = new System.Drawing.Size(75, 41);
            this.button_themsach.TabIndex = 2;
            this.button_themsach.Text = "Thêm sách";
            this.button_themsach.UseVisualStyleBackColor = true;
            this.button_themsach.Click += new System.EventHandler(this.button_themsach_Click);
            // 
            // button_muon
            // 
            this.button_muon.Depth = 0;
            this.button_muon.Location = new System.Drawing.Point(437, 66);
            this.button_muon.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_muon.Name = "button_muon";
            this.button_muon.Primary = true;
            this.button_muon.Size = new System.Drawing.Size(116, 57);
            this.button_muon.TabIndex = 5;
            this.button_muon.Text = "Lập phiếu mượn sách";
            this.button_muon.UseVisualStyleBackColor = true;
            this.button_muon.Click += new System.EventHandler(this.button_muon_Click);
            // 
            // button_huy
            // 
            this.button_huy.Depth = 0;
            this.button_huy.Location = new System.Drawing.Point(559, 65);
            this.button_huy.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_huy.Name = "button_huy";
            this.button_huy.Primary = true;
            this.button_huy.Size = new System.Drawing.Size(116, 57);
            this.button_huy.TabIndex = 6;
            this.button_huy.Text = "Hủy";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // listView_danhsachsachmuon
            // 
            this.listView_danhsachsachmuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_danhsachsachmuon.FullRowSelect = true;
            this.listView_danhsachsachmuon.HideSelection = false;
            this.listView_danhsachsachmuon.Location = new System.Drawing.Point(15, 189);
            this.listView_danhsachsachmuon.Name = "listView_danhsachsachmuon";
            this.listView_danhsachsachmuon.Size = new System.Drawing.Size(660, 168);
            this.listView_danhsachsachmuon.TabIndex = 4;
            this.listView_danhsachsachmuon.UseCompatibleStateImageBehavior = false;
            this.listView_danhsachsachmuon.View = System.Windows.Forms.View.Details;
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
            // textBox_madocgia
            // 
            this.textBox_madocgia.Location = new System.Drawing.Point(117, 69);
            this.textBox_madocgia.Name = "textBox_madocgia";
            this.textBox_madocgia.Size = new System.Drawing.Size(100, 20);
            this.textBox_madocgia.TabIndex = 0;
            this.textBox_madocgia.TextChanged += new System.EventHandler(this.textBox_madocgia_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã đọc giả";
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Location = new System.Drawing.Point(331, 69);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.ReadOnly = true;
            this.textBox_hoten.Size = new System.Drawing.Size(100, 20);
            this.textBox_hoten.TabIndex = 11;
            this.textBox_hoten.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(237, 68);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên đọc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày mượn";
            // 
            // dateTimePicker_ngaymuon
            // 
            this.dateTimePicker_ngaymuon.Enabled = false;
            this.dateTimePicker_ngaymuon.Location = new System.Drawing.Point(117, 102);
            this.dateTimePicker_ngaymuon.Name = "dateTimePicker_ngaymuon";
            this.dateTimePicker_ngaymuon.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_ngaymuon.TabIndex = 1;
            this.dateTimePicker_ngaymuon.TabStop = false;
            // 
            // button_xoadsssach
            // 
            this.button_xoadsssach.Depth = 0;
            this.button_xoadsssach.Location = new System.Drawing.Point(276, 142);
            this.button_xoadsssach.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_xoadsssach.Name = "button_xoadsssach";
            this.button_xoadsssach.Primary = true;
            this.button_xoadsssach.Size = new System.Drawing.Size(145, 41);
            this.button_xoadsssach.TabIndex = 3;
            this.button_xoadsssach.Text = "Xóa danh sách sách mượn";
            this.button_xoadsssach.UseVisualStyleBackColor = true;
            this.button_xoadsssach.Click += new System.EventHandler(this.button_xoadssach_Click);
            // 
            // LapPhieuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 369);
            this.Controls.Add(this.button_xoadsssach);
            this.Controls.Add(this.dateTimePicker_ngaymuon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_hoten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_madocgia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView_danhsachsachmuon);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_muon);
            this.Controls.Add(this.button_themsach);
            this.Controls.Add(this.textBox_masach);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "LapPhieuMuonSach";
            this.Text = "Lập phiếu mượn sách";
            this.Load += new System.EventHandler(this.LapPhieuMuonSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialLabel label1;
		private System.Windows.Forms.TextBox textBox_masach;
		private MaterialSkin.Controls.MaterialRaisedButton button_themsach;
		private MaterialSkin.Controls.MaterialRaisedButton button_muon;
		private MaterialSkin.Controls.MaterialRaisedButton button_huy;
		private System.Windows.Forms.ListView listView_danhsachsachmuon;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.TextBox textBox_madocgia;
		private MaterialSkin.Controls.MaterialLabel label2;
		private System.Windows.Forms.TextBox textBox_hoten;
		private MaterialSkin.Controls.MaterialLabel label3;
		private MaterialSkin.Controls.MaterialLabel label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker_ngaymuon;
		private MaterialSkin.Controls.MaterialRaisedButton button_xoadsssach;
	}
}