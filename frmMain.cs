using System;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;

namespace teraLauncher
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text.Equals(""))
            {
                MessageBox.Show("Please enter your account name.", "TERA-Launcher");
                return;
            }
            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter your password.", "TERA-Launcher");
                return;
            }
            Process.Start("tera.exe", "1 " + GetMD5(txtPassword.Text) + " 0 1 " + txtAccount.Text + " en");
            Application.Exit();
        }

        private static string GetMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] b = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
            return BitConverter.ToString(b).Replace("-", string.Empty).ToLower();
        }
    }
}
