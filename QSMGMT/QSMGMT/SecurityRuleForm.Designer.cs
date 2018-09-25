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
            this.lblError = new System.Windows.Forms.Label();
            this.cmbConnections = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysRules)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServerInfo
            // 
            this.txtServerInfo.Location = new System.Drawing.Point(5, 228);
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
            this.dgvSysRules.Location = new System.Drawing.Point(595, 228);
            this.dgvSysRules.Margin = new System.Windows.Forms.Padding(6);
            this.dgvSysRules.Name = "dgvSysRules";
            this.dgvSysRules.Size = new System.Drawing.Size(1729, 685);
            this.dgvSysRules.TabIndex = 6;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(15, 22);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 25);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "label1";
            // 
            // cmbConnections
            // 
            this.cmbConnections.FormattingEnabled = true;
            this.cmbConnections.Location = new System.Drawing.Point(20, 101);
            this.cmbConnections.Margin = new System.Windows.Forms.Padding(6);
            this.cmbConnections.Name = "cmbConnections";
            this.cmbConnections.Size = new System.Drawing.Size(358, 32);
            this.cmbConnections.TabIndex = 8;
            // 
            // SecurityRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2386, 1105);
            this.Controls.Add(this.cmbConnections);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgvSysRules);
            this.Controls.Add(this.txtServerInfo);
            this.Name = "SecurityRuleForm";
            this.Text = "SecurityRuleForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecurityRuleForm_FormClosed);
            this.Load += new System.EventHandler(this.SecurityRuleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysRules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerInfo;
        private System.Windows.Forms.DataGridView dgvSysRules;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cmbConnections;
    }
}