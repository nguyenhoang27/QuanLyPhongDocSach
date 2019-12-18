namespace QuanLiThuVien.BaocaoSachtratre {
	partial class QuanliBaocaoThongkeSachTratre {
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
            this.textBox_mabaocao = new System.Windows.Forms.TextBox();
            this.button_timbaocao = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listView_baocao = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_lapbaocao = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button_xembaocao = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(8, 120);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã báo cáo";
            // 
            // textBox_mabaocao
            // 
            this.textBox_mabaocao.Location = new System.Drawing.Point(102, 121);
            this.textBox_mabaocao.Name = "textBox_mabaocao";
            this.textBox_mabaocao.Size = new System.Drawing.Size(100, 20);
            this.textBox_mabaocao.TabIndex = 1;
            this.textBox_mabaocao.TextChanged += new System.EventHandler(this.textBox_mabaocao_TextChanged);
            // 
            // button_timbaocao
            // 
            this.button_timbaocao.Depth = 0;
            this.button_timbaocao.Location = new System.Drawing.Point(208, 112);
            this.button_timbaocao.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_timbaocao.Name = "button_timbaocao";
            this.button_timbaocao.Primary = true;
            this.button_timbaocao.Size = new System.Drawing.Size(81, 37);
            this.button_timbaocao.TabIndex = 2;
            this.button_timbaocao.Text = "Tìm báo cáo";
            this.button_timbaocao.UseVisualStyleBackColor = true;
            this.button_timbaocao.Click += new System.EventHandler(this.button_timbaocao_Click);
            // 
            // listView_baocao
            // 
            this.listView_baocao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_baocao.FullRowSelect = true;
            this.listView_baocao.HideSelection = false;
            this.listView_baocao.Location = new System.Drawing.Point(12, 161);
            this.listView_baocao.MultiSelect = false;
            this.listView_baocao.Name = "listView_baocao";
            this.listView_baocao.Size = new System.Drawing.Size(360, 156);
            this.listView_baocao.TabIndex = 3;
            this.listView_baocao.UseCompatibleStateImageBehavior = false;
            this.listView_baocao.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 43;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã báo cáo";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày lập báo cáo";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số sách trả trễ";
            this.columnHeader4.Width = 92;
            // 
            // button_lapbaocao
            // 
            this.button_lapbaocao.Depth = 0;
            this.button_lapbaocao.Location = new System.Drawing.Point(8, 67);
            this.button_lapbaocao.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_lapbaocao.Name = "button_lapbaocao";
            this.button_lapbaocao.Primary = true;
            this.button_lapbaocao.Size = new System.Drawing.Size(94, 35);
            this.button_lapbaocao.TabIndex = 4;
            this.button_lapbaocao.Text = "Lập báo cáo";
            this.button_lapbaocao.UseVisualStyleBackColor = true;
            this.button_lapbaocao.Click += new System.EventHandler(this.button_lapbaocao_Click);
            // 
            // button_xembaocao
            // 
            this.button_xembaocao.Depth = 0;
            this.button_xembaocao.Location = new System.Drawing.Point(108, 67);
            this.button_xembaocao.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_xembaocao.Name = "button_xembaocao";
            this.button_xembaocao.Primary = true;
            this.button_xembaocao.Size = new System.Drawing.Size(105, 35);
            this.button_xembaocao.TabIndex = 6;
            this.button_xembaocao.Text = "Xem báo cáo";
            this.button_xembaocao.UseVisualStyleBackColor = true;
            this.button_xembaocao.Click += new System.EventHandler(this.button_xembaocao_Click);
            // 
            // QuanliBaocaoThongkeSachTratre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 329);
            this.Controls.Add(this.button_xembaocao);
            this.Controls.Add(this.button_lapbaocao);
            this.Controls.Add(this.listView_baocao);
            this.Controls.Add(this.button_timbaocao);
            this.Controls.Add(this.textBox_mabaocao);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "QuanliBaocaoThongkeSachTratre";
            this.Text = "Báo cáo thống kê sách trả trễ";
            this.Load += new System.EventHandler(this.QuanliBaocaoThongkeSachTratre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialLabel label1;
		private System.Windows.Forms.TextBox textBox_mabaocao;
		private MaterialSkin.Controls.MaterialRaisedButton button_timbaocao;
		private System.Windows.Forms.ListView listView_baocao;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private MaterialSkin.Controls.MaterialRaisedButton button_lapbaocao;
		private MaterialSkin.Controls.MaterialRaisedButton button_xembaocao;
	}
}