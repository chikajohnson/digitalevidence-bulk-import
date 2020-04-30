namespace DigitalEvidenceBulkProcessor
{
    partial class frmBulkPRocessor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBulkPRocessor));
            this.label1 = new System.Windows.Forms.Label();
            this.lblProcessorHeader = new System.Windows.Forms.Label();
            this.lblSheet = new System.Windows.Forms.Label();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblModules = new System.Windows.Forms.Label();
            this.cmbSheets = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabTellers = new System.Windows.Forms.TabControl();
            this.tabNewUsers = new System.Windows.Forms.TabPage();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.tabExistingUsers = new System.Windows.Forms.TabPage();
            this.existingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTellers.SuspendLayout();
            this.tabNewUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.tabExistingUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            // 
            // lblProcessorHeader
            // 
            this.lblProcessorHeader.AutoSize = true;
            this.lblProcessorHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessorHeader.Location = new System.Drawing.Point(438, 32);
            this.lblProcessorHeader.Name = "lblProcessorHeader";
            this.lblProcessorHeader.Size = new System.Drawing.Size(275, 25);
            this.lblProcessorHeader.TabIndex = 1;
            this.lblProcessorHeader.Text = "DigitalEvidence Bulk Import";
            // 
            // lblSheet
            // 
            this.lblSheet.AutoSize = true;
            this.lblSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSheet.Location = new System.Drawing.Point(49, 137);
            this.lblSheet.Name = "lblSheet";
            this.lblSheet.Size = new System.Drawing.Size(58, 17);
            this.lblSheet.TabIndex = 3;
            this.lblSheet.Text = "Sheets";
            this.lblSheet.Click += new System.EventHandler(this.lblSheet_Click);
            // 
            // cmbModule
            // 
            this.cmbModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(155, 96);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(160, 21);
            this.cmbModule.TabIndex = 4;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(985, 94);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(81, 32);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Load users";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(466, 137);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(194, 31);
            this.btnProcess.TabIndex = 7;
            this.btnProcess.Text = "IMPORT";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(466, 95);
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(522, 30);
            this.txtFileName.TabIndex = 8;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(382, 100);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(78, 17);
            this.lblFileName.TabIndex = 9;
            this.lblFileName.Text = "File name";
            this.lblFileName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblModules
            // 
            this.lblModules.AutoSize = true;
            this.lblModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModules.Location = new System.Drawing.Point(39, 97);
            this.lblModules.Name = "lblModules";
            this.lblModules.Size = new System.Drawing.Size(68, 17);
            this.lblModules.TabIndex = 11;
            this.lblModules.Text = "Modules";
            // 
            // cmbSheets
            // 
            this.cmbSheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSheets.FormattingEnabled = true;
            this.cmbSheets.Location = new System.Drawing.Point(155, 136);
            this.cmbSheets.Name = "cmbSheets";
            this.cmbSheets.Size = new System.Drawing.Size(160, 21);
            this.cmbSheets.TabIndex = 12;
            this.cmbSheets.SelectedIndexChanged += new System.EventHandler(this.cmbSheets_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(956, 137);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 31);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Grid";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabTellers
            // 
            this.tabTellers.Controls.Add(this.tabNewUsers);
            this.tabTellers.Controls.Add(this.tabExistingUsers);
            this.tabTellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTellers.Location = new System.Drawing.Point(27, 201);
            this.tabTellers.Name = "tabTellers";
            this.tabTellers.Padding = new System.Drawing.Point(8, 10);
            this.tabTellers.SelectedIndex = 0;
            this.tabTellers.Size = new System.Drawing.Size(1086, 516);
            this.tabTellers.TabIndex = 14;
            // 
            // tabNewUsers
            // 
            this.tabNewUsers.Controls.Add(this.usersDataGridView);
            this.tabNewUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNewUsers.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabNewUsers.Location = new System.Drawing.Point(4, 36);
            this.tabNewUsers.Name = "tabNewUsers";
            this.tabNewUsers.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tabNewUsers.Size = new System.Drawing.Size(1078, 476);
            this.tabNewUsers.TabIndex = 0;
            this.tabNewUsers.Text = "Loaded Users";
            this.tabNewUsers.UseVisualStyleBackColor = true;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.usersDataGridView.DataSource = this.userModelBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.Size = new System.Drawing.Size(1057, 480);
            this.usersDataGridView.TabIndex = 10;
            this.usersDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.usersDataGridView_DataBindingComplete);
            this.usersDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.usersDataGridView_RowPostPaint);
            // 
            // tabExistingUsers
            // 
            this.tabExistingUsers.Controls.Add(this.existingDataGridView);
            this.tabExistingUsers.ForeColor = System.Drawing.Color.Black;
            this.tabExistingUsers.Location = new System.Drawing.Point(4, 36);
            this.tabExistingUsers.Name = "tabExistingUsers";
            this.tabExistingUsers.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tabExistingUsers.Size = new System.Drawing.Size(1078, 476);
            this.tabExistingUsers.TabIndex = 1;
            this.tabExistingUsers.Text = "Existing Users";
            this.tabExistingUsers.UseVisualStyleBackColor = true;
            // 
            // existingDataGridView
            // 
            this.existingDataGridView.AllowUserToAddRows = false;
            this.existingDataGridView.AllowUserToDeleteRows = false;
            this.existingDataGridView.AutoGenerateColumns = false;
            this.existingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.existingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.existingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.existingDataGridView.DataSource = this.userModelBindingSource;
            this.existingDataGridView.Location = new System.Drawing.Point(0, 0);
            this.existingDataGridView.Name = "existingDataGridView";
            this.existingDataGridView.ReadOnly = true;
            this.existingDataGridView.Size = new System.Drawing.Size(1075, 490);
            this.existingDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn4.HeaderText = "Password";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserNames";
            this.dataGridViewTextBoxColumn3.HeaderText = "UserNames";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BranchCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "BranchCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn5.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BranchCode";
            this.dataGridViewTextBoxColumn6.HeaderText = "BranchCode";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UserNames";
            this.dataGridViewTextBoxColumn7.HeaderText = "UserNames";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn8.HeaderText = "Password";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // userModelBindingSource
            // 
            this.userModelBindingSource.DataSource = typeof(DigitalEvidenceBulkProcessor.UserModel);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn9.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "BranchCode";
            this.dataGridViewTextBoxColumn10.HeaderText = "BranchCode";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "UserNames";
            this.dataGridViewTextBoxColumn11.HeaderText = "UserNames";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn12.HeaderText = "Password";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // frmBulkPRocessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1147, 817);
            this.Controls.Add(this.tabTellers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbSheets);
            this.Controls.Add(this.lblModules);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.cmbModule);
            this.Controls.Add(this.lblSheet);
            this.Controls.Add(this.lblProcessorHeader);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBulkPRocessor";
            this.Text = "Digital Evidence Bulk Import";
            this.Load += new System.EventHandler(this.frmBulkPRocessor_Load);
            this.tabTellers.ResumeLayout(false);
            this.tabNewUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.tabExistingUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.existingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProcessorHeader;
        private System.Windows.Forms.Label lblSheet;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn resetPasswordDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canRegisterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn captureImageDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn browseTransactionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uploadDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn setupUserDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn setupBranchDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn setUpSystemParametersDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn setUpTranscopeParametersDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addUserDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn editUserDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn browseUserDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteUserDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addCountryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn editCountryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn browseCountryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteCountryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addStateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn editStateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn browseStateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteStateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addTransactionCategoryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn editTransactionCategoryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn browseTransactionCategoryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteTransactionCategoryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn viewReportsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exportTransactionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn printTransactionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn superUserDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn suspendedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canConfigurePollDataDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canConfigureDataMoverDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastLogOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblModules;
        private System.Windows.Forms.ComboBox cmbSheets;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource userModelBindingSource;
        private System.Windows.Forms.TabControl tabTellers;
        private System.Windows.Forms.TabPage tabExistingUsers;
        private System.Windows.Forms.TabPage tabNewUsers;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView existingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}

