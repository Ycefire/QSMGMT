﻿namespace QSMGMT
{
    partial class Main
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
            this.lblError = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.securityRuleManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbConnections = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Test = new System.Windows.Forms.Label();
            this.btnSecurtiyRules = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(20, 57);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(17, 25);
            this.lblError.TabIndex = 0;
            this.lblError.Text = " ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.ToolsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2798, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newConnectionToolStripMenuItem,
            this.showConnectionsToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(131, 34);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // newConnectionToolStripMenuItem
            // 
            this.newConnectionToolStripMenuItem.Name = "newConnectionToolStripMenuItem";
            this.newConnectionToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.newConnectionToolStripMenuItem.Text = "New Connection";
            this.newConnectionToolStripMenuItem.Click += new System.EventHandler(this.newConnectionToolStripMenuItem_Click);
            // 
            // showConnectionsToolStripMenuItem
            // 
            this.showConnectionsToolStripMenuItem.Name = "showConnectionsToolStripMenuItem";
            this.showConnectionsToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.showConnectionsToolStripMenuItem.Text = "Show Connections";
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.securityRuleManagerToolStripMenuItem});
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(72, 34);
            this.ToolsMenu.Text = "Tools";
            // 
            // securityRuleManagerToolStripMenuItem
            // 
            this.securityRuleManagerToolStripMenuItem.Name = "securityRuleManagerToolStripMenuItem";
            this.securityRuleManagerToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.securityRuleManagerToolStripMenuItem.Text = "Security rule manager";
            this.securityRuleManagerToolStripMenuItem.Click += new System.EventHandler(this.securityRuleManagerToolStripMenuItem_Click);
            // 
            // cmbConnections
            // 
            this.cmbConnections.FormattingEnabled = true;
            this.cmbConnections.Location = new System.Drawing.Point(24, 102);
            this.cmbConnections.Margin = new System.Windows.Forms.Padding(6);
            this.cmbConnections.Name = "cmbConnections";
            this.cmbConnections.Size = new System.Drawing.Size(358, 32);
            this.cmbConnections.TabIndex = 3;
            this.cmbConnections.SelectedIndexChanged += new System.EventHandler(this.cmbConnections_SelectedIndexChanged);
            // 
            // Test
            // 
            this.Test.AutoSize = true;
            this.Test.Location = new System.Drawing.Point(56, 536);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(64, 25);
            this.Test.TabIndex = 6;
            this.Test.Text = "label1";
            // 
            // btnSecurtiyRules
            // 
            this.btnSecurtiyRules.Location = new System.Drawing.Point(24, 234);
            this.btnSecurtiyRules.Name = "btnSecurtiyRules";
            this.btnSecurtiyRules.Size = new System.Drawing.Size(358, 69);
            this.btnSecurtiyRules.TabIndex = 7;
            this.btnSecurtiyRules.Text = "Security rules";
            this.btnSecurtiyRules.UseVisualStyleBackColor = true;
            this.btnSecurtiyRules.Click += new System.EventHandler(this.btnSecurtiyRules_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2798, 906);
            this.Controls.Add(this.btnSecurtiyRules);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.cmbConnections);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showConnectionsToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbConnections;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Test;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem securityRuleManagerToolStripMenuItem;
        private System.Windows.Forms.Button btnSecurtiyRules;
    }
}

