using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;

namespace teraLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary> 
        /// 取得 MD5 編碼後的 Hex 字串 
        /// 加密後為 32 Bytes Hex String (16 Byte) 
        /// </summary> 
        /// <span  name="original" class="mceItemParam"></span>原始字串</param> 
        /// <returns></returns> 
        public static string GetMD5(string original)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] b = md5.ComputeHash(Encoding.UTF8.GetBytes(original));
            return BitConverter.ToString(b).Replace("-", string.Empty).ToLower();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            //this.Text = GetMD5(textBox2.Text);
            Process.Start("tera.exe","1 " + GetMD5(textBox2.Text) + " 0 1 " + textBox1.Text + " en");
        }
    }
}
