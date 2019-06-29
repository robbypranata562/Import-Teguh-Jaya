using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportTeguhJaya
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private static string MD5(string Metin)
        {
            MD5CryptoServiceProvider MD5Code = new MD5CryptoServiceProvider();
            byte[] byteDizisi = Encoding.UTF8.GetBytes(Metin);
            byteDizisi = MD5Code.ComputeHash(byteDizisi);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in byteDizisi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grosirEntities _context = new grosirEntities();
            string password = MD5(txtPassword.Text);
            var _dataLogin = _context.admins.Where(x => x.uname == txtUsername.Text
            && x.pass == password).FirstOrDefault();

            if (_dataLogin != null)
            {
                //check role
                if (_dataLogin.level == "Super Admin")
                {
                    FormMain formMain = new FormMain();
                    formMain.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Anda Tidak Berhak Mengakses Aplikasi Ini");
                }
            }
            else
            {
                MessageBox.Show("Username / Password Tidak Cocok");
            }
        }
    }
}
