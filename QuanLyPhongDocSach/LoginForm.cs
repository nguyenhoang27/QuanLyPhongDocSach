using DataAccess;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        MainForm MainFormInstance;

        public LoginForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);

            MainFormInstance = new MainForm();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Login();
            }
        }

        private void Login()
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            var login = Database.LoginQuyen(username, password);

            if (login)
            {
                if (checkBox_save_username.Checked)
                {
                    Config.Instance.username = username;
                }
                else
                {
                    Config.Instance.username = null;
                }

                Quyen.Instance = new Quyen(Database.GetQuyen(username));
                this.Hide();
                MainFormInstance.ShowDialog();
                this.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Config.Instance.username))
            {
                textBox_username.Text = Config.Instance.username;
                checkBox_save_username.Checked = true;
            }
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(
Primary.Blue500, Primary.BlueGrey900,
Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
    }
}
