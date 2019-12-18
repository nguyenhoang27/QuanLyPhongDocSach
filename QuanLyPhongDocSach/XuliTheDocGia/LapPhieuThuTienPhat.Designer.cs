namespace QuanLiThuVien.XuliTheDocGia {
	partial class LapPhieuThuTienPhat {
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
            this.button_huy = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button_lapphieuthutienphat = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_noconlai = new System.Windows.Forms.TextBox();
            this.textBox_sotienthu = new System.Windows.Forms.TextBox();
            this.textBox_tongno = new System.Windows.Forms.TextBox();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_madocgia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_huy
            // 
            this.button_huy.Depth = 0;
            this.button_huy.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_huy.Location = new System.Drawing.Point(152, 225);
            this.button_huy.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_huy.Name = "button_huy";
            this.button_huy.Primary = true;
            this.button_huy.Size = new System.Drawing.Size(75, 23);
            this.button_huy.TabIndex = 2;
            this.button_huy.Text = "Hủy";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_lapphieuthutienphat
            // 
            this.button_lapphieuthutienphat.Depth = 0;
            this.button_lapphieuthutienphat.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button_lapphieuthutienphat.Location = new System.Drawing.Point(12, 225);
            this.button_lapphieuthutienphat.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_lapphieuthutienphat.Name = "button_lapphieuthutienphat";
            this.button_lapphieuthutienphat.Primary = true;
            this.button_lapphieuthutienphat.Size = new System.Drawing.Size(75, 23);
            this.button_lapphieuthutienphat.TabIndex = 1;
            this.button_lapphieuthutienphat.Text = "Lập phiếu";
            this.button_lapphieuthutienphat.UseVisualStyleBackColor = true;
            this.button_lapphieuthutienphat.Click += new System.EventHandler(this.button_lapphieuthutienphat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Còn lại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số tiền thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tổng nợ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 105);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Họ tên đọc giả";
            // 
            // textBox_noconlai
            // 
            this.textBox_noconlai.Location = new System.Drawing.Point(127, 193);
            this.textBox_noconlai.Name = "textBox_noconlai";
            this.textBox_noconlai.ReadOnly = true;
            this.textBox_noconlai.Size = new System.Drawing.Size(100, 20);
            this.textBox_noconlai.TabIndex = 14;
            this.textBox_noconlai.TabStop = false;
            // 
            // textBox_sotienthu
            // 
            this.textBox_sotienthu.Location = new System.Drawing.Point(127, 167);
            this.textBox_sotienthu.Name = "textBox_sotienthu";
            this.textBox_sotienthu.Size = new System.Drawing.Size(100, 20);
            this.textBox_sotienthu.TabIndex = 0;
            this.textBox_sotienthu.TextChanged += new System.EventHandler(this.textBox_sotienthu_TextChanged);
            // 
            // textBox_tongno
            // 
            this.textBox_tongno.Location = new System.Drawing.Point(127, 134);
            this.textBox_tongno.Name = "textBox_tongno";
            this.textBox_tongno.ReadOnly = true;
            this.textBox_tongno.Size = new System.Drawing.Size(100, 20);
            this.textBox_tongno.TabIndex = 12;
            this.textBox_tongno.TabStop = false;
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Location = new System.Drawing.Point(127, 102);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.ReadOnly = true;
            this.textBox_hoten.Size = new System.Drawing.Size(100, 20);
            this.textBox_hoten.TabIndex = 11;
            this.textBox_hoten.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(13, 79);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mã đọc giả";
            // 
            // textBox_madocgia
            // 
            this.textBox_madocgia.Location = new System.Drawing.Point(127, 76);
            this.textBox_madocgia.Name = "textBox_madocgia";
            this.textBox_madocgia.ReadOnly = true;
            this.textBox_madocgia.Size = new System.Drawing.Size(100, 20);
            this.textBox_madocgia.TabIndex = 22;
            this.textBox_madocgia.TabStop = false;
            // 
            // LapPhieuThuTienPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 273);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_madocgia);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_lapphieuthutienphat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_noconlai);
            this.Controls.Add(this.textBox_sotienthu);
            this.Controls.Add(this.textBox_tongno);
            this.Controls.Add(this.textBox_hoten);
            this.MaximizeBox = false;
            this.Name = "LapPhieuThuTienPhat";
            this.Text = "Lập phiếu thu tiền phạt";
            this.Load += new System.EventHandler(this.LapPhieuThuTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialRaisedButton button_huy;
		private MaterialSkin.Controls.MaterialRaisedButton button_lapphieuthutienphat;
		private MaterialSkin.Controls.MaterialLabel label4;
		private MaterialSkin.Controls.MaterialLabel label3;
		private MaterialSkin.Controls.MaterialLabel label2;
		private MaterialSkin.Controls.MaterialLabel label1;
		private System.Windows.Forms.TextBox textBox_noconlai;
		private System.Windows.Forms.TextBox textBox_sotienthu;
		private System.Windows.Forms.TextBox textBox_tongno;
		private System.Windows.Forms.TextBox textBox_hoten;
		private MaterialSkin.Controls.MaterialLabel label6;
		private System.Windows.Forms.TextBox textBox_madocgia;
	}
}