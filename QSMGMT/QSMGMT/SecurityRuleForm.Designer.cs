namespace QSMGMT
{
    partial class SecurityRuleForm
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
            this.txtServerInfo = new System.Windows.Forms.TextBox();
            this.dgvSysRules = new System.Windows.Forms.DataGridView();
            this.cmbConnections = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.dtpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpModifiedDate = new System.Windows.Forms.DateTimePicker();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.lblModifiedUser = new System.Windows.Forms.Label();
            this.txtModifiedUser = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtRule = new System.Windows.Forms.TextBox();
            this.lblResourceFilter = new System.Windows.Forms.Label();
            this.txtResourceFilters = new System.Windows.Forms.TextBox();
            this.lblActions = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.cbDisabled = new System.Windows.Forms.CheckBox();
            this.lblContext = new System.Windows.Forms.Label();
            this.lblRule = new System.Windows.Forms.Label();
            this.cbContext = new System.Windows.Forms.ComboBox();
            this.cbActionCreate = new System.Windows.Forms.CheckBox();
            this.cbRead = new System.Windows.Forms.CheckBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbExport = new System.Windows.Forms.CheckBox();
            this.cbPublish = new System.Windows.Forms.CheckBox();
            this.cbChangeOwner = new System.Windows.Forms.CheckBox();
            this.cbChangeRole = new System.Windows.Forms.CheckBox();
            this.cbExportData = new System.Windows.Forms.CheckBox();
            this.cbAccessOffline = new System.Windows.Forms.CheckBox();
            this.cbDuplicate = new System.Windows.Forms.CheckBox();
            this.cbApprove = new System.Windows.Forms.CheckBox();
            this.txtDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysRules)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServerInfo
            // 
            this.txtServerInfo.Location = new System.Drawing.Point(3, 441);
            this.txtServerInfo.MaxLength = 0;
            this.txtServerInfo.Multiline = true;
            this.txtServerInfo.Name = "txtServerInfo";
            this.txtServerInfo.ReadOnly = true;
            this.txtServerInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServerInfo.Size = new System.Drawing.Size(312, 370);
            this.txtServerInfo.TabIndex = 5;
            // 
            // dgvSysRules
            // 
            this.dgvSysRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSysRules.Location = new System.Drawing.Point(3, 50);
            this.dgvSysRules.Name = "dgvSysRules";
            this.dgvSysRules.Size = new System.Drawing.Size(943, 371);
            this.dgvSysRules.TabIndex = 6;
            this.dgvSysRules.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSysRules_CellEnter);
            this.dgvSysRules.SelectionChanged += new System.EventHandler(this.dgvSysRules_SelectionChanged);
            // 
            // cmbConnections
            // 
            this.cmbConnections.FormattingEnabled = true;
            this.cmbConnections.Location = new System.Drawing.Point(3, 17);
            this.cmbConnections.Name = "cmbConnections";
            this.cmbConnections.Size = new System.Drawing.Size(197, 21);
            this.cmbConnections.TabIndex = 8;
            this.cmbConnections.SelectedIndexChanged += new System.EventHandler(this.cmbConnections_SelectedIndexChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(0, 425);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "label1";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 32);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(47, 30);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(314, 20);
            this.txtId.TabIndex = 10;
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(15, 61);
            this.lblCreationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(69, 13);
            this.lblCreationDate.TabIndex = 11;
            this.lblCreationDate.Text = "CreationDate";
            // 
            // dtpCreationDate
            // 
            this.dtpCreationDate.Enabled = false;
            this.dtpCreationDate.Location = new System.Drawing.Point(98, 59);
            this.dtpCreationDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpCreationDate.Name = "dtpCreationDate";
            this.dtpCreationDate.Size = new System.Drawing.Size(263, 20);
            this.dtpCreationDate.TabIndex = 12;
            // 
            // dtpModifiedDate
            // 
            this.dtpModifiedDate.Enabled = false;
            this.dtpModifiedDate.Location = new System.Drawing.Point(98, 80);
            this.dtpModifiedDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpModifiedDate.Name = "dtpModifiedDate";
            this.dtpModifiedDate.Size = new System.Drawing.Size(263, 20);
            this.dtpModifiedDate.TabIndex = 14;
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Location = new System.Drawing.Point(15, 82);
            this.lblModifiedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(70, 13);
            this.lblModifiedDate.TabIndex = 13;
            this.lblModifiedDate.Text = "ModifiedDate";
            // 
            // lblModifiedUser
            // 
            this.lblModifiedUser.AutoSize = true;
            this.lblModifiedUser.Location = new System.Drawing.Point(15, 106);
            this.lblModifiedUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModifiedUser.Name = "lblModifiedUser";
            this.lblModifiedUser.Size = new System.Drawing.Size(69, 13);
            this.lblModifiedUser.TabIndex = 15;
            this.lblModifiedUser.Text = "ModifiedUser";
            // 
            // txtModifiedUser
            // 
            this.txtModifiedUser.Enabled = false;
            this.txtModifiedUser.Location = new System.Drawing.Point(98, 104);
            this.txtModifiedUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModifiedUser.Name = "txtModifiedUser";
            this.txtModifiedUser.Size = new System.Drawing.Size(263, 20);
            this.txtModifiedUser.TabIndex = 16;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 128);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 17;
            this.lblCategory.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(74, 126);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(287, 20);
            this.txtCategory.TabIndex = 18;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(15, 150);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(56, 148);
            this.txtType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(305, 20);
            this.txtType.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblCreationDate);
            this.groupBox1.Controls.Add(this.txtCategory);
            this.groupBox1.Controls.Add(this.dtpCreationDate);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.lblModifiedDate);
            this.groupBox1.Controls.Add(this.txtModifiedUser);
            this.groupBox1.Controls.Add(this.dtpModifiedDate);
            this.groupBox1.Controls.Add(this.lblModifiedUser);
            this.groupBox1.Location = new System.Drawing.Point(334, 441);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(374, 186);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Not changeable settings";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(729, 472);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(782, 472);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 20);
            this.txtName.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(968, 807);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 34);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtRule
            // 
            this.txtRule.AcceptsReturn = true;
            this.txtRule.AcceptsTab = true;
            this.txtRule.Location = new System.Drawing.Point(1087, 472);
            this.txtRule.MaxLength = 0;
            this.txtRule.Multiline = true;
            this.txtRule.Name = "txtRule";
            this.txtRule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRule.Size = new System.Drawing.Size(825, 370);
            this.txtRule.TabIndex = 25;
            // 
            // lblResourceFilter
            // 
            this.lblResourceFilter.AutoSize = true;
            this.lblResourceFilter.Location = new System.Drawing.Point(729, 501);
            this.lblResourceFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResourceFilter.Name = "lblResourceFilter";
            this.lblResourceFilter.Size = new System.Drawing.Size(83, 13);
            this.lblResourceFilter.TabIndex = 26;
            this.lblResourceFilter.Text = "Resource Filters";
            // 
            // txtResourceFilters
            // 
            this.txtResourceFilters.Location = new System.Drawing.Point(815, 499);
            this.txtResourceFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResourceFilters.Name = "txtResourceFilters";
            this.txtResourceFilters.Size = new System.Drawing.Size(261, 20);
            this.txtResourceFilters.TabIndex = 27;
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Location = new System.Drawing.Point(730, 570);
            this.lblActions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(42, 13);
            this.lblActions.TabIndex = 28;
            this.lblActions.Text = "Actions";
            // 
            // txtComments
            // 
            this.txtComments.AcceptsReturn = true;
            this.txtComments.AcceptsTab = true;
            this.txtComments.Location = new System.Drawing.Point(733, 685);
            this.txtComments.MaxLength = 0;
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(349, 110);
            this.txtComments.TabIndex = 30;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(736, 661);
            this.lblComments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 31;
            this.lblComments.Text = "Comments";
            this.lblComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDisabled
            // 
            this.cbDisabled.AutoSize = true;
            this.cbDisabled.Location = new System.Drawing.Point(731, 524);
            this.cbDisabled.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDisabled.Name = "cbDisabled";
            this.cbDisabled.Size = new System.Drawing.Size(67, 17);
            this.cbDisabled.TabIndex = 32;
            this.cbDisabled.Text = "Disabled";
            this.cbDisabled.UseVisualStyleBackColor = true;
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.Location = new System.Drawing.Point(729, 548);
            this.lblContext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(43, 13);
            this.lblContext.TabIndex = 33;
            this.lblContext.Text = "Context";
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Location = new System.Drawing.Point(736, 641);
            this.lblRule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(29, 13);
            this.lblRule.TabIndex = 35;
            this.lblRule.Text = "Rule";
            // 
            // cbContext
            // 
            this.cbContext.FormattingEnabled = true;
            this.cbContext.Location = new System.Drawing.Point(782, 545);
            this.cbContext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbContext.Name = "cbContext";
            this.cbContext.Size = new System.Drawing.Size(294, 21);
            this.cbContext.TabIndex = 36;
            // 
            // cbActionCreate
            // 
            this.cbActionCreate.AutoSize = true;
            this.cbActionCreate.Location = new System.Drawing.Point(733, 585);
            this.cbActionCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbActionCreate.Name = "cbActionCreate";
            this.cbActionCreate.Size = new System.Drawing.Size(57, 17);
            this.cbActionCreate.TabIndex = 38;
            this.cbActionCreate.Text = "Create";
            this.cbActionCreate.UseVisualStyleBackColor = true;
            // 
            // cbRead
            // 
            this.cbRead.AutoSize = true;
            this.cbRead.Location = new System.Drawing.Point(789, 585);
            this.cbRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRead.Name = "cbRead";
            this.cbRead.Size = new System.Drawing.Size(52, 17);
            this.cbRead.TabIndex = 39;
            this.cbRead.Text = "Read";
            this.cbRead.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Location = new System.Drawing.Point(838, 585);
            this.cbUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(61, 17);
            this.cbUpdate.TabIndex = 40;
            this.cbUpdate.Text = "Update";
            this.cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(895, 585);
            this.cbDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(57, 17);
            this.cbDelete.TabIndex = 41;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbExport
            // 
            this.cbExport.AutoSize = true;
            this.cbExport.Location = new System.Drawing.Point(949, 585);
            this.cbExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbExport.Name = "cbExport";
            this.cbExport.Size = new System.Drawing.Size(56, 17);
            this.cbExport.TabIndex = 42;
            this.cbExport.Text = "Export";
            this.cbExport.UseVisualStyleBackColor = true;
            // 
            // cbPublish
            // 
            this.cbPublish.AutoSize = true;
            this.cbPublish.Location = new System.Drawing.Point(1004, 585);
            this.cbPublish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPublish.Name = "cbPublish";
            this.cbPublish.Size = new System.Drawing.Size(60, 17);
            this.cbPublish.TabIndex = 43;
            this.cbPublish.Text = "Publish";
            this.cbPublish.UseVisualStyleBackColor = true;
            // 
            // cbChangeOwner
            // 
            this.cbChangeOwner.AutoSize = true;
            this.cbChangeOwner.Location = new System.Drawing.Point(733, 604);
            this.cbChangeOwner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbChangeOwner.Name = "cbChangeOwner";
            this.cbChangeOwner.Size = new System.Drawing.Size(95, 17);
            this.cbChangeOwner.TabIndex = 44;
            this.cbChangeOwner.Text = "Change owner";
            this.cbChangeOwner.UseVisualStyleBackColor = true;
            // 
            // cbChangeRole
            // 
            this.cbChangeRole.AutoSize = true;
            this.cbChangeRole.Location = new System.Drawing.Point(827, 604);
            this.cbChangeRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbChangeRole.Name = "cbChangeRole";
            this.cbChangeRole.Size = new System.Drawing.Size(83, 17);
            this.cbChangeRole.TabIndex = 45;
            this.cbChangeRole.Text = "Change role";
            this.cbChangeRole.UseVisualStyleBackColor = true;
            // 
            // cbExportData
            // 
            this.cbExportData.AutoSize = true;
            this.cbExportData.Location = new System.Drawing.Point(909, 604);
            this.cbExportData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbExportData.Name = "cbExportData";
            this.cbExportData.Size = new System.Drawing.Size(80, 17);
            this.cbExportData.TabIndex = 46;
            this.cbExportData.Text = "Export data";
            this.cbExportData.UseVisualStyleBackColor = true;
            // 
            // cbAccessOffline
            // 
            this.cbAccessOffline.AutoSize = true;
            this.cbAccessOffline.Location = new System.Drawing.Point(987, 604);
            this.cbAccessOffline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAccessOffline.Name = "cbAccessOffline";
            this.cbAccessOffline.Size = new System.Drawing.Size(92, 17);
            this.cbAccessOffline.TabIndex = 47;
            this.cbAccessOffline.Text = "Access offline";
            this.cbAccessOffline.UseVisualStyleBackColor = true;
            // 
            // cbDuplicate
            // 
            this.cbDuplicate.AutoSize = true;
            this.cbDuplicate.Location = new System.Drawing.Point(733, 623);
            this.cbDuplicate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDuplicate.Name = "cbDuplicate";
            this.cbDuplicate.Size = new System.Drawing.Size(71, 17);
            this.cbDuplicate.TabIndex = 48;
            this.cbDuplicate.Text = "Duplicate";
            this.cbDuplicate.UseVisualStyleBackColor = true;
            // 
            // cbApprove
            // 
            this.cbApprove.AutoSize = true;
            this.cbApprove.Location = new System.Drawing.Point(801, 623);
            this.cbApprove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbApprove.Name = "cbApprove";
            this.cbApprove.Size = new System.Drawing.Size(66, 17);
            this.cbApprove.TabIndex = 49;
            this.cbApprove.Text = "Approve";
            this.cbApprove.UseVisualStyleBackColor = true;
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(846, 807);
            this.txtDelete.Margin = new System.Windows.Forms.Padding(2);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(106, 34);
            this.txtDelete.TabIndex = 50;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // SecurityRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 877);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.cbApprove);
            this.Controls.Add(this.cbDuplicate);
            this.Controls.Add(this.cbAccessOffline);
            this.Controls.Add(this.cbExportData);
            this.Controls.Add(this.cbChangeRole);
            this.Controls.Add(this.cbChangeOwner);
            this.Controls.Add(this.cbPublish);
            this.Controls.Add(this.cbExport);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.cbUpdate);
            this.Controls.Add(this.cbRead);
            this.Controls.Add(this.cbActionCreate);
            this.Controls.Add(this.cbContext);
            this.Controls.Add(this.lblRule);
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.cbDisabled);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.txtResourceFilters);
            this.Controls.Add(this.lblResourceFilter);
            this.Controls.Add(this.txtRule);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbConnections);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgvSysRules);
            this.Controls.Add(this.txtServerInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SecurityRuleForm";
            this.Text = "SecurityRuleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecurityRuleForm_FormClosed);
            this.Load += new System.EventHandler(this.SecurityRuleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysRules)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerInfo;
        private System.Windows.Forms.DataGridView dgvSysRules;
        private System.Windows.Forms.ComboBox cmbConnections;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.DateTimePicker dtpCreationDate;
        private System.Windows.Forms.DateTimePicker dtpModifiedDate;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.Label lblModifiedUser;
        private System.Windows.Forms.TextBox txtModifiedUser;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtRule;
        private System.Windows.Forms.Label lblResourceFilter;
        private System.Windows.Forms.TextBox txtResourceFilters;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.CheckBox cbDisabled;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.ComboBox cbContext;
        private System.Windows.Forms.CheckBox cbActionCreate;
        private System.Windows.Forms.CheckBox cbRead;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbExport;
        private System.Windows.Forms.CheckBox cbPublish;
        private System.Windows.Forms.CheckBox cbChangeOwner;
        private System.Windows.Forms.CheckBox cbChangeRole;
        private System.Windows.Forms.CheckBox cbExportData;
        private System.Windows.Forms.CheckBox cbAccessOffline;
        private System.Windows.Forms.CheckBox cbDuplicate;
        private System.Windows.Forms.CheckBox cbApprove;
        private System.Windows.Forms.Button txtDelete;
    }
}