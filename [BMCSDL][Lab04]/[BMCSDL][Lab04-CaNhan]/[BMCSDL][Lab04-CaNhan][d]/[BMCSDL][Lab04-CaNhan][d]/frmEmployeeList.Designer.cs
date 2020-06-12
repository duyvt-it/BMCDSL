namespace _BMCSDL__Lab04_CaNhan__d_ {
    partial class frmEmployeeList {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbMATKHAU = new System.Windows.Forms.TextBox();
            this.txbLUONG = new System.Windows.Forms.TextBox();
            this.txbHOTEN = new System.Windows.Forms.TextBox();
            this.txbTENDN = new System.Windows.Forms.TextBox();
            this.txbEMAIL = new System.Windows.Forms.TextBox();
            this.txbMANV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.lvEmployeeSTTItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEmployeeMaNVItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEmployeeHoTenItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEmployeeEmailItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEmployeeLuongItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tipSave = new System.Windows.Forms.ToolTip(this.components);
            this.tipTxbMaNV = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMATKHAU);
            this.groupBox1.Controls.Add(this.txbLUONG);
            this.groupBox1.Controls.Add(this.txbHOTEN);
            this.groupBox1.Controls.Add(this.txbTENDN);
            this.groupBox1.Controls.Add(this.txbEMAIL);
            this.groupBox1.Controls.Add(this.txbMANV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 223);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txbMATKHAU
            // 
            this.txbMATKHAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMATKHAU.Location = new System.Drawing.Point(655, 152);
            this.txbMATKHAU.Name = "txbMATKHAU";
            this.txbMATKHAU.PasswordChar = '*';
            this.txbMATKHAU.ReadOnly = true;
            this.txbMATKHAU.Size = new System.Drawing.Size(355, 29);
            this.txbMATKHAU.TabIndex = 6;
            this.txbMATKHAU.Text = "ENCRYPTED";
            this.txbMATKHAU.TextChanged += new System.EventHandler(this.txbMATKHAU_TextChanged);
            // 
            // txbLUONG
            // 
            this.txbLUONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLUONG.Location = new System.Drawing.Point(655, 95);
            this.txbLUONG.Name = "txbLUONG";
            this.txbLUONG.Size = new System.Drawing.Size(355, 29);
            this.txbLUONG.TabIndex = 4;
            // 
            // txbHOTEN
            // 
            this.txbHOTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHOTEN.Location = new System.Drawing.Point(655, 38);
            this.txbHOTEN.Name = "txbHOTEN";
            this.txbHOTEN.Size = new System.Drawing.Size(355, 29);
            this.txbHOTEN.TabIndex = 2;
            // 
            // txbTENDN
            // 
            this.txbTENDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTENDN.Location = new System.Drawing.Point(168, 154);
            this.txbTENDN.Name = "txbTENDN";
            this.txbTENDN.ReadOnly = true;
            this.txbTENDN.Size = new System.Drawing.Size(355, 29);
            this.txbTENDN.TabIndex = 5;
            this.txbTENDN.TextChanged += new System.EventHandler(this.txbTENDN_TextChanged);
            // 
            // txbEMAIL
            // 
            this.txbEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEMAIL.Location = new System.Drawing.Point(168, 97);
            this.txbEMAIL.Name = "txbEMAIL";
            this.txbEMAIL.Size = new System.Drawing.Size(355, 29);
            this.txbEMAIL.TabIndex = 3;
            // 
            // txbMANV
            // 
            this.txbMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMANV.Location = new System.Drawing.Point(168, 40);
            this.txbMANV.Name = "txbMANV";
            this.txbMANV.ReadOnly = true;
            this.txbMANV.Size = new System.Drawing.Size(355, 29);
            this.txbMANV.TabIndex = 1;
            this.txbMANV.TextChanged += new System.EventHandler(this.txbMANV_TextChanged);
            this.txbMANV.Leave += new System.EventHandler(this.txbMANV_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã NV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvNhanVien);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 386);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".";
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.CheckBoxes = true;
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvEmployeeSTTItem,
            this.lvEmployeeMaNVItem,
            this.lvEmployeeHoTenItem,
            this.lvEmployeeEmailItem,
            this.lvEmployeeLuongItem});
            this.lvNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNhanVien.FullRowSelect = true;
            this.lvNhanVien.GridLines = true;
            this.lvNhanVien.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvNhanVien.HideSelection = false;
            this.lvNhanVien.Location = new System.Drawing.Point(25, 19);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(985, 267);
            this.lvNhanVien.TabIndex = 20;
            this.lvNhanVien.TabStop = false;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvNhanVien_SelectedIndexChanged);
            // 
            // lvEmployeeSTTItem
            // 
            this.lvEmployeeSTTItem.Text = "";
            this.lvEmployeeSTTItem.Width = 0;
            // 
            // lvEmployeeMaNVItem
            // 
            this.lvEmployeeMaNVItem.Text = "MANV";
            this.lvEmployeeMaNVItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvEmployeeMaNVItem.Width = 114;
            // 
            // lvEmployeeHoTenItem
            // 
            this.lvEmployeeHoTenItem.Text = "HOTEN";
            this.lvEmployeeHoTenItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvEmployeeHoTenItem.Width = 403;
            // 
            // lvEmployeeEmailItem
            // 
            this.lvEmployeeEmailItem.Text = "EMAIL";
            this.lvEmployeeEmailItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvEmployeeEmailItem.Width = 285;
            // 
            // lvEmployeeLuongItem
            // 
            this.lvEmployeeLuongItem.Text = "LUONG";
            this.lvEmployeeLuongItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvEmployeeLuongItem.Width = 178;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnDiscard);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(25, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(985, 83);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = ".";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(848, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 37);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscard.Location = new System.Drawing.Point(643, 29);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(118, 37);
            this.btnDiscard.TabIndex = 11;
            this.btnDiscard.Text = "Không lưu";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(519, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Ghi/Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(267, 29);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 37);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(143, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 37);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(19, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 37);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tipSave
            // 
            this.tipSave.Active = false;
            this.tipSave.AutomaticDelay = 100;
            this.tipSave.AutoPopDelay = 10000;
            this.tipSave.InitialDelay = 100;
            this.tipSave.ReshowDelay = 20;
            this.tipSave.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipSave.ToolTipTitle = "Mẹo:";
            // 
            // tipTxbMaNV
            // 
            this.tipTxbMaNV.AutomaticDelay = 200;
            // 
            // frmEmployeeList
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1064, 685);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployeeList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployeeList_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployeeList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbMATKHAU;
        private System.Windows.Forms.TextBox txbLUONG;
        private System.Windows.Forms.TextBox txbHOTEN;
        private System.Windows.Forms.TextBox txbTENDN;
        private System.Windows.Forms.TextBox txbEMAIL;
        private System.Windows.Forms.TextBox txbMANV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader lvEmployeeMaNVItem;
        private System.Windows.Forms.ColumnHeader lvEmployeeHoTenItem;
        private System.Windows.Forms.ColumnHeader lvEmployeeEmailItem;
        private System.Windows.Forms.ColumnHeader lvEmployeeLuongItem;
        private System.Windows.Forms.ColumnHeader lvEmployeeSTTItem;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ToolTip tipSave;
        private System.Windows.Forms.ToolTip tipTxbMaNV;
    }
}