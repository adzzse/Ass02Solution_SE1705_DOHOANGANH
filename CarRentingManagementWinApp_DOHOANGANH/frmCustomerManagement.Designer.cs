﻿
namespace CarRentingManagementWinApp_DOHOANGANH
{
    partial class frmCustomerManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCustomerID = new System.Windows.Forms.Label();
            txtCustomerId = new System.Windows.Forms.TextBox();
            lbCustomerName = new System.Windows.Forms.Label();
            txtCustomerName = new System.Windows.Forms.TextBox();
            lbTelephone = new System.Windows.Forms.Label();
            txtTelephone = new System.Windows.Forms.TextBox();
            lbBirthday = new System.Windows.Forms.Label();
            dtpBirthday = new System.Windows.Forms.DateTimePicker();
            lbStatus = new System.Windows.Forms.Label();
            txtStatus = new System.Windows.Forms.TextBox();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvCustomerList = new System.Windows.Forms.DataGridView();
            lbSearch = new System.Windows.Forms.Label();
            txtSearchValue = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            grSearch = new System.Windows.Forms.GroupBox();
            radioById = new System.Windows.Forms.RadioButton();
            radioByCarName = new System.Windows.Forms.RadioButton();
            txtEmail = new System.Windows.Forms.TextBox();
            lbEmail = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            grSearch.SuspendLayout();
            SuspendLayout();
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Location = new System.Drawing.Point(26, 30);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new System.Drawing.Size(73, 15);
            lbCustomerID.TabIndex = 0;
            lbCustomerID.Text = "Customer ID";
            lbCustomerID.Click += lbCustomerID_Click;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new System.Drawing.Point(130, 27);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new System.Drawing.Size(184, 23);
            txtCustomerId.TabIndex = 1;
            txtCustomerId.TextChanged += txtCustomerID_TextChanged;
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new System.Drawing.Point(26, 71);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new System.Drawing.Size(94, 15);
            lbCustomerName.TabIndex = 2;
            lbCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(130, 68);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(184, 23);
            txtCustomerName.TabIndex = 3;
            // 
            // lbTelephone
            // 
            lbTelephone.AutoSize = true;
            lbTelephone.Location = new System.Drawing.Point(26, 111);
            lbTelephone.Name = "lbTelephone";
            lbTelephone.Size = new System.Drawing.Size(61, 15);
            lbTelephone.TabIndex = 4;
            lbTelephone.Text = "Telephone";
            lbTelephone.Click += lbShortDescription_Click;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new System.Drawing.Point(130, 109);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new System.Drawing.Size(184, 23);
            txtTelephone.TabIndex = 5;
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new System.Drawing.Point(380, 71);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new System.Drawing.Size(51, 15);
            lbBirthday.TabIndex = 8;
            lbBirthday.Text = "Birthday";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new System.Drawing.Point(446, 68);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new System.Drawing.Size(184, 23);
            dtpBirthday.TabIndex = 9;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new System.Drawing.Point(380, 112);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new System.Drawing.Size(39, 15);
            lbStatus.TabIndex = 10;
            lbStatus.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(446, 109);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(184, 23);
            txtStatus.TabIndex = 11;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(45, 148);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(109, 23);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(205, 148);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(109, 23);
            btnNew.TabIndex = 13;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(505, 149);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(109, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Location = new System.Drawing.Point(26, 297);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.ReadOnly = true;
            dgvCustomerList.RowHeadersWidth = 51;
            dgvCustomerList.RowTemplate.Height = 25;
            dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerList.Size = new System.Drawing.Size(604, 200);
            dgvCustomerList.TabIndex = 15;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new System.Drawing.Point(20, 24);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(42, 15);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(68, 21);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(201, 23);
            txtSearchValue.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(194, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(75, 23);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(radioById);
            grSearch.Controls.Add(radioByCarName);
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new System.Drawing.Point(25, 191);
            grSearch.Name = "grSearch";
            grSearch.Size = new System.Drawing.Size(577, 89);
            grSearch.TabIndex = 22;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            grSearch.Enter += grSearch_Enter;
            // 
            // radioById
            // 
            radioById.AutoSize = true;
            radioById.Checked = true;
            radioById.Location = new System.Drawing.Point(20, 50);
            radioById.Name = "radioById";
            radioById.Size = new System.Drawing.Size(51, 19);
            radioById.TabIndex = 23;
            radioById.TabStop = true;
            radioById.Text = "By Id";
            radioById.UseVisualStyleBackColor = true;
            // 
            // radioByCarName
            // 
            radioByCarName.AutoSize = true;
            radioByCarName.Location = new System.Drawing.Point(96, 50);
            radioByCarName.Name = "radioByCarName";
            radioByCarName.Size = new System.Drawing.Size(94, 19);
            radioByCarName.TabIndex = 22;
            radioByCarName.TabStop = true;
            radioByCarName.Text = "By Car Name";
            radioByCarName.UseVisualStyleBackColor = true;
            radioByCarName.CheckedChanged += radioByProducer_CheckedChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(446, 28);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(184, 23);
            txtEmail.TabIndex = 33;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(380, 29);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(36, 15);
            lbEmail.TabIndex = 32;
            lbEmail.Text = "Email";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(361, 149);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(109, 23);
            btnSave.TabIndex = 34;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmCustomerManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(660, 509);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(grSearch);
            Controls.Add(dgvCustomerList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtStatus);
            Controls.Add(lbStatus);
            Controls.Add(dtpBirthday);
            Controls.Add(lbBirthday);
            Controls.Add(txtTelephone);
            Controls.Add(lbTelephone);
            Controls.Add(txtCustomerName);
            Controls.Add(lbCustomerName);
            Controls.Add(txtCustomerId);
            Controls.Add(lbCustomerID);
            Name = "frmCustomerManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Customer Management";
            Load += frmCustomerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.RadioButton radioByCarName;
        private System.Windows.Forms.RadioButton radioById;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnSave;
    }
}