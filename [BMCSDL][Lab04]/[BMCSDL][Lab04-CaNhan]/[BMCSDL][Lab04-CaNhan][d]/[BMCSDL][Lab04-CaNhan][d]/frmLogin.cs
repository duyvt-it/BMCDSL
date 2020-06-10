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

namespace _BMCSDL__Lab04_CaNhan__d_ {
    public partial class frmLogin : Form {
        QuanLySinhVienDonGianEntities db = new QuanLySinhVienDonGianEntities();

        public frmLogin() {
            InitializeComponent();
        }

        static string getMd5Hash(string input) {
            using (MD5 md5Hash = MD5.Create()) {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++) {
                    stringBuilder.Append(data[i].ToString("X2"));
                }

                return stringBuilder.ToString();
            }           
        }

        static string getSha1Hash(string input) {
            using (SHA1Managed sha1Hash = new SHA1Managed()) {
                byte[] hash = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder stringBuilder = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash) {
                    stringBuilder.Append(b.ToString("X2"));
                }

                return stringBuilder.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            //if (String.IsNullOrEmpty(txbUser.Text)) {
            //    DialogResult warningUsername = MessageBox.Show("Tên đăng nhập trống!!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //    if (warningUsername == System.Windows.Forms.DialogResult.Cancel) {
            //        this.Close();
            //    }
            //}

            string username = txbUser.Text;
            string password = txbPwd.Text;
            string md5Pwd = getMd5Hash(txbPwd.Text);
            string sha1Pwd = getSha1Hash(txbPwd.Text);


            if (db.SP_SEL_USER(username, md5Pwd, sha1Pwd).SingleOrDefault().ToString() == "1") {
                this.Hide();
                frmEmployeeList frmEmployeeList = new frmEmployeeList();
                frmEmployeeList.ShowDialog();
                this.Close();
            }
            else {
                DialogResult loginFail = MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ!!", username, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (loginFail == System.Windows.Forms.DialogResult.Cancel) {
                    this.Close();
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
