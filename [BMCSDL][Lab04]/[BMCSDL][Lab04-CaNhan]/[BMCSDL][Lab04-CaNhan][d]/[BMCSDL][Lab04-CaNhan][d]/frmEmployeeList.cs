using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _BMCSDL__Lab04_CaNhan__d_ {
    public partial class frmEmployeeList : Form {
        QuanLySinhVienDonGianEntities db = new QuanLySinhVienDonGianEntities();

        public frmEmployeeList() {
            InitializeComponent();   
        }
        
        private void frmEmployeeList_Load(object sender, EventArgs e) {
            dtgvEmployee.DataSource = db.SP_SEL_ENCRYPT_NHANVIEN();
        }

        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e) {
            txbMANV.DataBindings.Add(new Binding("Text", dtgvEmployee["MANV", e.RowIndex], "Value", false));
            txbHOTEN.DataBindings.Add(new Binding("Text", dtgvEmployee["HOTEN", e.RowIndex], "Value", false));
            txbEMAIL.DataBindings.Add(new Binding("Text", dtgvEmployee["EMAIL", e.RowIndex], "Value", false));
            txbLUONG.DataBindings.Add(new Binding("Text", dtgvEmployee["LUONG", e.RowIndex], "Value", false));
            txbTENDN.DataBindings.Add(new Binding("Text", dtgvEmployee["TENDN", e.RowIndex], "Value", false));
            txbMATKHAU.DataBindings.Add(new Binding("Text", dtgvEmployee["MATKHAU", e.RowIndex], "Value", false));
        }
    }
}
