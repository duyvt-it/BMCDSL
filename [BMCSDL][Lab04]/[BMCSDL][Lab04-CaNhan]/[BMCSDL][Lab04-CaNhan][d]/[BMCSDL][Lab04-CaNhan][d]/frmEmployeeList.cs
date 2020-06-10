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
using System.Windows.Forms.VisualStyles;

namespace _BMCSDL__Lab04_CaNhan__d_ {
    public partial class frmEmployeeList : Form {
        QuanLySinhVienDonGianEntities db = Program.db;

        public frmEmployeeList() {
            InitializeComponent();

        }
        
        public void frmEmployeeList_Load(object sender, EventArgs e) {
            dtgvEmployee.DataSource = db.SP_SEL_ENCRYPT_NHANVIEN();
            txbTENDN.Text = Program.username;
            txbMATKHAU.Text = String.IsNullOrEmpty(Program.sha1Pwd) != String.IsNullOrEmpty(Program.md5Pwd) ? Program.sha1Pwd : Program.md5Pwd;
        }

        private void dtgvEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            txbMANV.DataBindings.Add(new Binding("Text", dtgvEmployee["MANV", e.RowIndex], "Value", false));
            txbHOTEN.DataBindings.Add(new Binding("Text", dtgvEmployee["HOTEN", e.RowIndex], "Value", false));
            txbEMAIL.DataBindings.Add(new Binding("Text", dtgvEmployee["EMAIL", e.RowIndex], "Value", false));
            txbLUONG.DataBindings.Add(new Binding("Text", dtgvEmployee["LUONG", e.RowIndex], "Value", false));
        }

        static byte[] getMd5Hash(string input) {
            using (MD5 md5Hash = MD5.Create()) {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++) {
                    stringBuilder.Append(data[i].ToString("X2"));
                }

                byte[] result = Encoding.ASCII.GetBytes(stringBuilder.ToString());

                return result;
            }
        }

        static byte[] getSha1Hash(string input) {
            using (SHA1Managed sha1Hash = new SHA1Managed()) {
                byte[] hash = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder stringBuilder = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash) {
                    stringBuilder.Append(b.ToString("X2"));
                }

                byte[] result = Encoding.ASCII.GetBytes(stringBuilder.ToString());

                return result;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            //db.SP_INS_ENCRYPT_NHANVIEN(
            //    txbMANV.Text, 
            //    txbHOTEN.Text, 
            //    txbEMAIL.Text, 
            //    txbLUONG.Text, 
            //    txbTENDN.Text, 
            //    txbMATKHAU.Text
            //);

            tempNHANVIEN temp = new tempNHANVIEN() {
                MANV = txbMANV.Text,
                HOTEN = txbHOTEN.Text,
                EMAIL = txbEMAIL.Text,
                LUONG = txbLUONG.Text,
                TENDN = txbTENDN.Text,
                MATKHAU = txbMATKHAU.Text
            };

            db.tempNHANVIEN.Add(temp);
            db.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            
            NHANVIEN nhanVien = new NHANVIEN() {
                MANV = txbMANV.Text
            };

            db.NHANVIEN.Attach(nhanVien);
            db.NHANVIEN.Remove(nhanVien);
            db.SaveChanges();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            
        }

        private void btnSave_Click(object sender, EventArgs e) {
            foreach (var item in db.tempNHANVIEN) {
                db.SP_INS_ENCRYPT_NHANVIEN(
                    item.MANV,
                    item.HOTEN,
                    item.EMAIL,
                    item.LUONG,
                    item.TENDN,
                    item.MATKHAU
                );

                db.tempNHANVIEN.Attach(item);
                db.tempNHANVIEN.Remove(item);
            }
            db.SaveChanges();
        }

        private void btnDiscard_Click(object sender, EventArgs e) {

        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
