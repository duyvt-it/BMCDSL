using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        
        private void frmEmployeeList_Load(object sender, EventArgs e) {
            dtgvEmployee.DataSource = db.SP_SEL_ENCRYPT_NHANVIEN();
            txbTENDN.Text = Program.username;
            txbMATKHAU.Text = String.IsNullOrEmpty(Program.sha1Pwd) != String.IsNullOrEmpty(Program.md5Pwd) ? Program.sha1Pwd : Program.md5Pwd;
        }

        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void dtgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void dtgvEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            txbMANV.DataBindings.Add(new Binding("Text", dtgvEmployee["MANV", e.RowIndex], "Value", false));
            txbHOTEN.DataBindings.Add(new Binding("Text", dtgvEmployee["HOTEN", e.RowIndex], "Value", false));
            txbEMAIL.DataBindings.Add(new Binding("Text", dtgvEmployee["EMAIL", e.RowIndex], "Value", false));
            txbLUONG.DataBindings.Add(new Binding("Text", dtgvEmployee["LUONG", e.RowIndex], "Value", false));
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            
        }

        private void btnDelete_Click(object sender, EventArgs e) {

        }

        private void btnEdit_Click(object sender, EventArgs e) {

        }

        private void btnSave_Click(object sender, EventArgs e) {

        }

        private void btnDiscard_Click(object sender, EventArgs e) {

        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
