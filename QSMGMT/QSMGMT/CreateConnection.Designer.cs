using System;

namespace QSMGMT
{
    partial class CreateConnection
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
            System.Windows.Forms.Label lab;
            this.ServerUrlLabel = new System.Windows.Forms.Label();
            this.ServerUrlTextBox = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BrowseClient = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.ClientPassword = new System.Windows.Forms.TextBox();
            this.UserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            lab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Location = new System.Drawing.Point(7, 209);
            lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lab.Name = "lab";
            lab.Size = new System.Drawing.Size(82, 13);
            lab.TabIndex = 8;
            lab.Text = "Client Password";
            // 
            // ServerUrlLabel
            // 
            this.ServerUrlLabel.AutoSize = true;
            this.ServerUrlLabel.Location = new System.Drawing.Point(7, 99);
            this.ServerUrlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServerUrlLabel.Name = "ServerUrlLabel";
            this.ServerUrlLabel.Size = new System.Drawing.Size(52, 13);
            this.ServerUrlLabel.TabIndex = 0;
            this.ServerUrlLabel.Text = "Server url";
            // 
            // ServerUrlTextBox
            // 
            this.ServerUrlTextBox.Location = new System.Drawing.Point(93, 96);
            this.ServerUrlTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ServerUrlTextBox.Name = "ServerUrlTextBox";
            this.ServerUrlTextBox.Size = new System.Drawing.Size(227, 20);
            this.ServerUrlTextBox.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Enabled = false;
            this.btnTest.Location = new System.Drawing.Point(510, 400);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(144, 29);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(657, 395);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BrowseClient
            // 
            this.BrowseClient.Location = new System.Drawing.Point(10, 163);
            this.BrowseClient.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseClient.Name = "BrowseClient";
            this.BrowseClient.Size = new System.Drawing.Size(49, 21);
            this.BrowseClient.TabIndex = 4;
            this.BrowseClient.Text = "....";
            this.BrowseClient.UseVisualStyleBackColor = true;
            this.BrowseClient.Click += new System.EventHandler(this.BrowseClient_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(93, 164);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(611, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server Name";
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(93, 129);
            this.ServerName.Margin = new System.Windows.Forms.Padding(2);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(227, 20);
            this.ServerName.TabIndex = 7;
            // 
            // ClientPassword
            // 
            this.ClientPassword.Enabled = false;
            this.ClientPassword.Location = new System.Drawing.Point(93, 206);
            this.ClientPassword.Margin = new System.Windows.Forms.Padding(2);
            this.ClientPassword.Name = "ClientPassword";
            this.ClientPassword.Size = new System.Drawing.Size(227, 20);
            this.ClientPassword.TabIndex = 9;
            // 
            // UserId
            // 
            this.UserId.Enabled = false;
            this.UserId.Location = new System.Drawing.Point(93, 257);
            this.UserId.Margin = new System.Windows.Forms.Padding(2);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(227, 20);
            this.UserId.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "User";
            // 
            // Password
            // 
            this.Password.Enabled = false;
            this.Password.Location = new System.Drawing.Point(93, 295);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(227, 20);
            this.Password.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Domain";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(7, 53);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(362, 400);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 29);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CreateConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 451);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.ClientPassword);
            this.Controls.Add(lab);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BrowseClient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.ServerUrlTextBox);
            this.Controls.Add(this.ServerUrlLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateConnection";
            this.Text = "CreateConnection";
            this.Load += new System.EventHandler(this.CreateConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

 

        #endregion

        private System.Windows.Forms.Label ServerUrlLabel;
        private System.Windows.Forms.TextBox ServerUrlTextBox;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BrowseClient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.TextBox ClientPassword;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSave;
    }
}