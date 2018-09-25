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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysRules)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServerInfo
            // 
            this.txtServerInfo.Location = new System.Drawing.Point(5, 815);
            this.txtServerInfo.Margin = new System.Windows.Forms.Padding(6);
            this.txtServerInfo.MaxLength = 0;
            this.txtServerInfo.Multiline = true;
            this.txtServerInfo.Name = "txtServerInfo";
            this.txtServerInfo.ReadOnly = true;
            this.txtServerInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServerInfo.Size = new System.Drawing.Size(569, 680);
            this.txtServerInfo.TabIndex = 5;
            // 
            // dgvSysRules
            // 
            this.dgvSysRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSysRules.Location = new System.Drawing.Point(5, 93);
            this.dgvSysRules.Margin = new System.Windows.Forms.Padding(6);
            this.dgvSysRules.Name = "dgvSysRules";
            this.dgvSysRules.Size = new System.Drawing.Size(1729, 685);
            this.dgvSysRules.TabIndex = 6;
            this.dgvSysRules.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSysRules_CellEnter);
            this.dgvSysRules.SelectionChanged += new System.EventHandler(this.dgvSysRules_SelectionChanged);
            // 
            // cmbConnections
            // 
            this.cmbConnections.FormattingEnabled = true;
            this.cmbConnections.Location = new System.Drawing.Point(5, 31);
            this.cmbConnections.Margin = new System.Windows.Forms.Padding(6);
            this.cmbConnections.Name = "cmbConnections";
            this.cmbConnections.Size = new System.Drawing.Size(358, 32);
            this.cmbConnections.TabIndex = 8;
            this.cmbConnections.SelectedIndexChanged += new System.EventHandler(this.cmbConnections_SelectedIndexChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(0, 784);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 25);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "label1";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(28, 59);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 25);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(86, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(572, 29);
            this.txtId.TabIndex = 10;
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(28, 113);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(127, 25);
            this.lblCreationDate.TabIndex = 11;
            this.lblCreationDate.Text = "CreationDate";
            // 
            // dtpCreationDate
            // 
            this.dtpCreationDate.Enabled = false;
            this.dtpCreationDate.Location = new System.Drawing.Point(179, 109);
            this.dtpCreationDate.Name = "dtpCreationDate";
            this.dtpCreationDate.Size = new System.Drawing.Size(479, 29);
            this.dtpCreationDate.TabIndex = 12;
            // 
            // dtpModifiedDate
            // 
            this.dtpModifiedDate.Enabled = false;
            this.dtpModifiedDate.Location = new System.Drawing.Point(179, 148);
            this.dtpModifiedDate.Name = "dtpModifiedDate";
            this.dtpModifiedDate.Size = new System.Drawing.Size(479, 29);
            this.dtpModifiedDate.TabIndex = 14;
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Location = new System.Drawing.Point(28, 152);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(127, 25);
            this.lblModifiedDate.TabIndex = 13;
            this.lblModifiedDate.Text = "ModifiedDate";
            // 
            // lblModifiedUser
            // 
            this.lblModifiedUser.AutoSize = true;
            this.lblModifiedUser.Location = new System.Drawing.Point(28, 195);
            this.lblModifiedUser.Name = "lblModifiedUser";
            this.lblModifiedUser.Size = new System.Drawing.Size(127, 25);
            this.lblModifiedUser.TabIndex = 15;
            this.lblModifiedUser.Text = "ModifiedUser";
            // 
            // txtModifiedUser
            // 
            this.txtModifiedUser.Enabled = false;
            this.txtModifiedUser.Location = new System.Drawing.Point(179, 192);
            this.txtModifiedUser.Name = "txtModifiedUser";
            this.txtModifiedUser.Size = new System.Drawing.Size(479, 29);
            this.txtModifiedUser.TabIndex = 16;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(28, 236);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 17;
            this.lblCategory.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(135, 233);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(523, 29);
            this.txtCategory.TabIndex = 18;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(28, 277);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(57, 25);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(103, 274);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(555, 29);
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
            this.groupBox1.Location = new System.Drawing.Point(612, 815);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 343);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Not changeable settings";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1336, 871);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1433, 871);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(536, 29);
            this.txtName.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1102, 1433);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 62);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtRule
            // 
            this.txtRule.AcceptsReturn = true;
            this.txtRule.AcceptsTab = true;
            this.txtRule.Location = new System.Drawing.Point(1341, 1215);
            this.txtRule.Margin = new System.Windows.Forms.Padding(6);
            this.txtRule.MaxLength = 0;
            this.txtRule.Multiline = true;
            this.txtRule.Name = "txtRule";
            this.txtRule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRule.Size = new System.Drawing.Size(628, 377);
            this.txtRule.TabIndex = 25;
            // 
            // lblResourceFilter
            // 
            this.lblResourceFilter.AutoSize = true;
            this.lblResourceFilter.Location = new System.Drawing.Point(1336, 924);
            this.lblResourceFilter.Name = "lblResourceFilter";
            this.lblResourceFilter.Size = new System.Drawing.Size(152, 25);
            this.lblResourceFilter.TabIndex = 26;
            this.lblResourceFilter.Text = "Resource Filters";
            // 
            // txtResourceFilters
            // 
            this.txtResourceFilters.Location = new System.Drawing.Point(1494, 921);
            this.txtResourceFilters.Name = "txtResourceFilters";
            this.txtResourceFilters.Size = new System.Drawing.Size(475, 29);
            this.txtResourceFilters.TabIndex = 27;
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Location = new System.Drawing.Point(1339, 1052);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(77, 25);
            this.lblActions.TabIndex = 28;
            this.lblActions.Text = "Actions";
            // 
            // txtComments
            // 
            this.txtComments.AcceptsReturn = true;
            this.txtComments.AcceptsTab = true;
            this.txtComments.Location = new System.Drawing.Point(612, 1215);
            this.txtComments.Margin = new System.Windows.Forms.Padding(6);
            this.txtComments.MaxLength = 0;
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(685, 200);
            this.txtComments.TabIndex = 30;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(620, 1175);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(107, 25);
            this.lblComments.TabIndex = 31;
            this.lblComments.Text = "Comments";
            this.lblComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDisabled
            // 
            this.cbDisabled.AutoSize = true;
            this.cbDisabled.Location = new System.Drawing.Point(1341, 967);
            this.cbDisabled.Name = "cbDisabled";
            this.cbDisabled.Size = new System.Drawing.Size(114, 29);
            this.cbDisabled.TabIndex = 32;
            this.cbDisabled.Text = "Disabled";
            this.cbDisabled.UseVisualStyleBackColor = true;
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.Location = new System.Drawing.Point(1336, 1011);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(80, 25);
            this.lblContext.TabIndex = 33;
            this.lblContext.Text = "Context";
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Location = new System.Drawing.Point(1349, 1184);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(51, 25);
            this.lblRule.TabIndex = 35;
            this.lblRule.Text = "Rule";
            // 
            // cbContext
            // 
            this.cbContext.FormattingEnabled = true;
            this.cbContext.Location = new System.Drawing.Point(1433, 1007);
            this.cbContext.Name = "cbContext";
            this.cbContext.Size = new System.Drawing.Size(536, 32);
            this.cbContext.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2014, 868);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.MaxLength = 0;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1509, 680);
            this.textBox1.TabIndex = 37;
            // 
            // cbActionCreate
            // 
            this.cbActionCreate.AutoSize = true;
            this.cbActionCreate.Location = new System.Drawing.Point(1344, 1080);
            this.cbActionCreate.Name = "cbActionCreate";
            this.cbActionCreate.Size = new System.Drawing.Size(97, 29);
            this.cbActionCreate.TabIndex = 38;
            this.cbActionCreate.Text = "Create";
            this.cbActionCreate.UseVisualStyleBackColor = true;
            // 
            // cbRead
            // 
            this.cbRead.AutoSize = true;
            this.cbRead.Location = new System.Drawing.Point(1447, 1080);
            this.cbRead.Name = "cbRead";
            this.cbRead.Size = new System.Drawing.Size(84, 29);
            this.cbRead.TabIndex = 39;
            this.cbRead.Text = "Read";
            this.cbRead.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Location = new System.Drawing.Point(1537, 1080);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(101, 29);
            this.cbUpdate.TabIndex = 40;
            this.cbUpdate.Text = "Update";
            this.cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(1640, 1080);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(94, 29);
            this.cbDelete.TabIndex = 41;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbExport
            // 
            this.cbExport.AutoSize = true;
            this.cbExport.Location = new System.Drawing.Point(1740, 1080);
            this.cbExport.Name = "cbExport";
            this.cbExport.Size = new System.Drawing.Size(94, 29);
            this.cbExport.TabIndex = 42;
            this.cbExport.Text = "Export";
            this.cbExport.UseVisualStyleBackColor = true;
            // 
            // cbPublish
            // 
            this.cbPublish.AutoSize = true;
            this.cbPublish.Location = new System.Drawing.Point(1840, 1080);
            this.cbPublish.Name = "cbPublish";
            this.cbPublish.Size = new System.Drawing.Size(102, 29);
            this.cbPublish.TabIndex = 43;
            this.cbPublish.Text = "Publish";
            this.cbPublish.UseVisualStyleBackColor = true;
            // 
            // cbChangeOwner
            // 
            this.cbChangeOwner.AutoSize = true;
            this.cbChangeOwner.Location = new System.Drawing.Point(1344, 1115);
            this.cbChangeOwner.Name = "cbChangeOwner";
            this.cbChangeOwner.Size = new System.Drawing.Size(166, 29);
            this.cbChangeOwner.TabIndex = 44;
            this.cbChangeOwner.Text = "Change owner";
            this.cbChangeOwner.UseVisualStyleBackColor = true;
            // 
            // cbChangeRole
            // 
            this.cbChangeRole.AutoSize = true;
            this.cbChangeRole.Location = new System.Drawing.Point(1516, 1115);
            this.cbChangeRole.Name = "cbChangeRole";
            this.cbChangeRole.Size = new System.Drawing.Size(145, 29);
            this.cbChangeRole.TabIndex = 45;
            this.cbChangeRole.Text = "Change role";
            this.cbChangeRole.UseVisualStyleBackColor = true;
            // 
            // cbExportData
            // 
            this.cbExportData.AutoSize = true;
            this.cbExportData.Location = new System.Drawing.Point(1667, 1115);
            this.cbExportData.Name = "cbExportData";
            this.cbExportData.Size = new System.Drawing.Size(137, 29);
            this.cbExportData.TabIndex = 46;
            this.cbExportData.Text = "Export data";
            this.cbExportData.UseVisualStyleBackColor = true;
            // 
            // cbAccessOffline
            // 
            this.cbAccessOffline.AutoSize = true;
            this.cbAccessOffline.Location = new System.Drawing.Point(1810, 1115);
            this.cbAccessOffline.Name = "cbAccessOffline";
            this.cbAccessOffline.Size = new System.Drawing.Size(159, 29);
            this.cbAccessOffline.TabIndex = 47;
            this.cbAccessOffline.Text = "Access offline";
            this.cbAccessOffline.UseVisualStyleBackColor = true;
            // 
            // cbDuplicate
            // 
            this.cbDuplicate.AutoSize = true;
            this.cbDuplicate.Location = new System.Drawing.Point(1344, 1150);
            this.cbDuplicate.Name = "cbDuplicate";
            this.cbDuplicate.Size = new System.Drawing.Size(119, 29);
            this.cbDuplicate.TabIndex = 48;
            this.cbDuplicate.Text = "Duplicate";
            this.cbDuplicate.UseVisualStyleBackColor = true;
            // 
            // cbApprove
            // 
            this.cbApprove.AutoSize = true;
            this.cbApprove.Location = new System.Drawing.Point(1469, 1150);
            this.cbApprove.Name = "cbApprove";
            this.cbApprove.Size = new System.Drawing.Size(112, 29);
            this.cbApprove.TabIndex = 49;
            this.cbApprove.Text = "Approve";
            this.cbApprove.UseVisualStyleBackColor = true;
            // 
            // SecurityRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2386, 1585);
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
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
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
    }
}