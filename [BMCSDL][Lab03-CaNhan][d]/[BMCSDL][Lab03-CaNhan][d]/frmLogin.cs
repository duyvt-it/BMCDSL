using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _BMCSDL__Lab03_CaNhan__d_ {
    public partial class frmLogin : Form {
        QLSVEntities db = new QLSVEntities();

        public frmLogin() {
            InitializeComponent();
        }

        static string GetMd5Hash(MD5 md5Hash, string input) {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++) {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        
        private void btnLogin_Click(object sender, EventArgs e) {
            //if (String.IsNullOrEmpty(txbUser.Text)) {
            //    DialogResult warningUsername = MessageBox.Show("Tên đăng nhập trống!!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //    if (warningUsername == System.Windows.Forms.DialogResult.Cancel) {
            //        this.Close();
            //    }
            //}

            string username = txbUser.Text;
            string password = txbPwd.Text;


            if (db.SP_SEL_USER(username, password).SingleOrDefault().ToString() == "1") {
                DialogResult loginSuccess = MessageBox.Show("Đăng nhập thành công!!", username, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (loginSuccess == System.Windows.Forms.DialogResult.OK) {
                    this.Close();
                }
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
