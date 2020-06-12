using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _BMCSDL__Lab04_CaNhan__d_ {
    public partial class frmEmployeeList : Form {
        private string accountLogin;
        private List<string> listMaNV;
        private string runTimeMode;
        public string AccountLogin { get => accountLogin; set => accountLogin = value; }
        public List<string> ListMaNV { get => listMaNV; set => listMaNV = value; }
        public string RunTimeMode { get => runTimeMode; set => runTimeMode = value; }

        public frmEmployeeList(string _accountLogin) {
            InitializeComponent();
            AccountLogin = _accountLogin;
        }

        public void frmEmployeeList_Load(object sender, EventArgs e) {
            lvNhanVien_Load();

            txbTENDN.Text = AccountLogin;
        }

        private void lvNhanVien_Load() {
            lvNhanVien.Items.Clear();

            foreach (AccountDTO item in AccountDAO.Instance.getListAccount()) {
                ListViewItem list = new ListViewItem();
                list.SubItems.Add(item.MANV);
                list.SubItems.Add(item.HOTEN);
                list.SubItems.Add(item.EMAIL);
                list.SubItems.Add(item.LUONG);

                lvNhanVien.Items.Add(list);
            }
        }

        public void updateListMaNV() {
            List<string> listMaNV = new List<string>();
            foreach (ListViewItem item in lvNhanVien.Items) {
                listMaNV.Add(item.SubItems[1].Text.ToUpper());
            }
            ListMaNV = listMaNV;
        }

        public void isFillDataInsert() {
            if (RunTimeMode == "addBegin()") {
                if (String.IsNullOrEmpty(txbMANV.Text) ||
                String.IsNullOrEmpty(txbTENDN.Text) ||
                String.IsNullOrEmpty(txbMATKHAU.Text)) {
                    btnAdd.Enabled = false;
                }
                else {
                    btnAdd.Enabled = true;
                }
            }
        }

        private void changeStatus(string _type) {
            if (_type == "addBegin()") {
                txbMANV.Focus();

                txbMANV.ReadOnly = false;
                txbTENDN.ReadOnly = false;
                txbMATKHAU.ReadOnly = false;

                btnAdd.Enabled = false;
                btnDelete.Visible = false;
                btnEdit.Visible = false;

                lvNhanVien.Enabled = false;
                lvNhanVien.FullRowSelect = false;

                tipSave.SetToolTip(btnSave, "Nhấp \"Thêm\" để thêm nhân viên.\nSau khi thêm hoàn tất nhấp \"Ghi/Lưu\" để lưu thay đổi.");
                tipSave.Active = true;
            }

            if (_type == "addEnd()" && !txbMANV.ReadOnly) {
                txbMANV.ReadOnly = true;
                txbTENDN.ReadOnly = true;
                txbMATKHAU.ReadOnly = true;

                btnAdd.Enabled = true;
                btnDelete.Visible = true;
                btnEdit.Visible = true;

                lvNhanVien.Enabled = true;
                lvNhanVien.FullRowSelect = true;

                tipSave.Active = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (RunTimeMode == "addBegin()") {    //!txbMANV.ReadOnly
                ListViewItem list = new ListViewItem();
                list.SubItems.Add(txbMANV.Text);
                list.SubItems.Add(txbHOTEN.Text);
                list.SubItems.Add(txbEMAIL.Text);
                list.SubItems.Add(txbLUONG.Text);

                lvNhanVien.Items.Add(list);
                AccountDAO.Instance.insertNhanVien(
                    txbMANV.Text,
                    txbHOTEN.Text,
                    txbEMAIL.Text,
                    txbLUONG.Text,
                    txbTENDN.Text,
                    txbMATKHAU.Text);
            }
            else {
                RunTimeMode = "addBegin()";
                changeStatus(RunTimeMode);
            }

            txbMANV.Clear();
            txbHOTEN.Clear();
            txbEMAIL.Clear();
            txbLUONG.Clear();
            txbTENDN.Clear();
            txbMATKHAU.Clear();

            updateListMaNV();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (lvNhanVien.SelectedItems.Count == 1) {
                ListViewItem item = lvNhanVien.SelectedItems[0];

                lvNhanVien.Items.Remove(item);
                AccountDAO.Instance.deleteNhanVien(txbMANV.Text);
            }
            else {
                MessageBox.Show(
                    "Chưa chọn nhân viên trong danh sách",
                    "Không xóa được", MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (lvNhanVien.SelectedItems.Count == 1) {
                AccountDAO.Instance.editNhanVien(
                    txbMANV.Text,
                    txbHOTEN.Text,
                    txbEMAIL.Text,
                    txbLUONG.Text);

                ListViewItem item = lvNhanVien.SelectedItems[0];
                item.SubItems[2].Text = txbHOTEN.Text;
                item.SubItems[3].Text = txbEMAIL.Text;
                item.SubItems[4].Text = txbLUONG.Text;
            }
            else {
                MessageBox.Show(
                    "Chưa chọn nhân viên trong danh sách",
                    "Không sửa được", MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (AccountDAO.Instance.getChangeStatus()) {
                try {
                    RunTimeMode = "addEnd()";
                    changeStatus(RunTimeMode);

                    AccountDAO.Instance.saveChangeNhanVien();
                    lvNhanVien_Load();

                    MessageBox.Show(
                        "Đã cập nhật dữ liệu",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                catch (Exception) {
                    DialogResult error = MessageBox.Show(
                        "Thao tác thất bại",
                        "Lỗi",
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);

                    if (error == System.Windows.Forms.DialogResult.Cancel) {
                        Application.Exit();
                    }
                }
            }
            else {
                MessageBox.Show(
                    "Không có thay đổi nào được thực hiện",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e) {
            RunTimeMode = "addEnd()";
            changeStatus(RunTimeMode);

            if (AccountDAO.Instance.getChangeStatus()) {
                lvNhanVien_Load();

                MessageBox.Show(
                   "Đã hoàn tác dữ liệu",
                   "Thành công",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);
            }
            else {
                MessageBox.Show(
                    "Không có thay đổi nào được thực hiện",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }

        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvNhanVien.SelectedItems.Count == 1) {
                ListViewItem selectItem = lvNhanVien.SelectedItems[0];

                txbMANV.Text = selectItem.SubItems[1].Text;
                txbHOTEN.Text = selectItem.SubItems[2].Text;
                txbEMAIL.Text = selectItem.SubItems[3].Text;
                txbLUONG.Text = selectItem.SubItems[4].Text;
            }
        }

        private void txbMANV_Leave(object sender, EventArgs e) {
            
        }

        private void frmEmployeeList_FormClosing(object sender, FormClosingEventArgs e) {
            if (AccountDAO.Instance.getChangeStatus()) {
                DialogResult saveChange = MessageBox.Show(
                    "Các thay đổi chưa được lưu\n\nLưu và thoát?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button3);

                if (saveChange == DialogResult.Yes) {
                    btnSave_Click(sender, e);
                    Application.Exit();
                }
                else {
                    if (saveChange == DialogResult.No) {
                        btnDiscard_Click(sender, e);
                        Application.Exit();
                    }
                    else {
                        if (saveChange == DialogResult.Cancel) {
                            e.Cancel = true;
                        }
                    }
                }
            }
            else {
                Application.Exit();
            }
        }

        private void txbMANV_TextChanged(object sender, EventArgs e) {
            if (RunTimeMode == "addBegin()") {
                tipTxbMaNV.Active = false;

                foreach (string item in ListMaNV) {
                    if (txbMANV.Text.ToUpper() == item) {
                        //ToolTip tipTxbMaNV = new ToolTip();
                        string message = "Mã nhân viên \"" + txbMANV.Text.ToUpper() + "\" đã tồn tại!";
                        tipTxbMaNV.ToolTipTitle = "Cảnh báo:";
                        tipTxbMaNV.ToolTipIcon = ToolTipIcon.Warning;

                        tipTxbMaNV.Active = true;
                        tipTxbMaNV.Show(message, txbMANV, 0, 30, 5000);
                        btnAdd.Enabled = false;
                        break;
                    }
                    else {
                        isFillDataInsert();
                    }
                }
            }
        }

        private void txbTENDN_TextChanged(object sender, EventArgs e) {
            isFillDataInsert();
        }

        private void txbMATKHAU_TextChanged(object sender, EventArgs e) {
            isFillDataInsert();
        }
    }
}
