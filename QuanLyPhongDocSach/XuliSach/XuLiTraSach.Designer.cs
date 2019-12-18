namespace QuanLiThuVien.XuliSach
{
    partial class XuLiTraSach
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
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_madocgia = new System.Windows.Forms.TextBox();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_danhsachsachmuon = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_huy = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button_xuli = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox_tongno = new System.Windows.Forms.TextBox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Location = new System.Drawing.Point(164, 103);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.ReadOnly = true;
            this.textBox_hoten.Size = new System.Drawing.Size(100, 20);
            this.textBox_hoten.TabIndex = 24;
            this.textBox_hoten.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(14, 102);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên đọc giả";
            // 
            // textBox_madocgia
            // 
            this.textBox_madocgia.Location = new System.Drawing.Point(164, 72);
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
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã đọc giả";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày mượn";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã sách";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // listView_danhsachsachmuon
            // 
            this.listView_danhsachsachmuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_danhsachsachmuon.FullRowSelect = true;
            this.listView_danhsachsachmuon.HideSelection = false;
            this.listView_danhsachsachmuon.Location = new System.Drawing.Point(12, 166);
            this.listView_danhsachsachmuon.Name = "listView_danhsachsachmuon";
            this.listView_danhsachsachmuon.Size = new System.Drawing.Size(574, 201);
            this.listView_danhsachsachmuon.TabIndex = 20;
            this.listView_danhsachsachmuon.TabStop = false;
            this.listView_danhsachsachmuon.UseCompatibleStateImageBehavior = false;
            this.listView_danhsachsachmuon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên sách";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tiền phạt trả trễ";
            this.columnHeader5.Width = 104;
            // 
            // button_huy
            // 
            this.button_huy.Depth = 0;
            this.button_huy.Location = new System.Drawing.Point(470, 72);
            this.button_huy.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_huy.Name = "button_huy";
            this.button_huy.Primary = true;
            this.button_huy.Size = new System.Drawing.Size(116, 57);
            this.button_huy.TabIndex = 2;
            this.button_huy.Text = "Hủy";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_xuli
            // 
            this.button_xuli.Depth = 0;
            this.button_xuli.Location = new System.Drawing.Point(348, 72);
            this.button_xuli.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_xuli.Name = "button_xuli";
            this.button_xuli.Primary = true;
            this.button_xuli.Size = new System.Drawing.Size(116, 57);
            this.button_xuli.TabIndex = 1;
            this.button_xuli.Text = "Xử lí trả sách";
            this.button_xuli.UseVisualStyleBackColor = true;
            this.button_xuli.Click += new System.EventHandler(this.button_xuli_Click);
            // 
            // textBox_tongno
            // 
            this.textBox_tongno.Location = new System.Drawing.Point(164, 130);
            this.textBox_tongno.Name = "textBox_tongno";
            this.textBox_tongno.ReadOnly = true;
            this.textBox_tongno.Size = new System.Drawing.Size(100, 20);
            this.textBox_tongno.TabIndex = 26;
            this.textBox_tongno.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tổng nợ của đọc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(282, 129);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "VND";
            // 
            // XuLiTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 377);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_tongno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_hoten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_madocgia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView_danhsachsachmuon);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_xuli);
            this.MaximizeBox = false;
            this.Name = "XuLiTraSach";
            this.Text = "Xử lí trả sách";
            this.Load += new System.EventHandler(this.XuLiTraSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_hoten;
        private MaterialSkin.Controls.MaterialLabel label3;
        private System.Windows.Forms.TextBox textBox_madocgia;
        private MaterialSkin.Controls.MaterialLabel label2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView_danhsachsachmuon;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialRaisedButton button_huy;
        private MaterialSkin.Controls.MaterialRaisedButton button_xuli;
        private System.Windows.Forms.TextBox textBox_tongno;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}