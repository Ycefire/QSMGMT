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
            this.button1 = new System.Windows.Forms.Button();
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
            lab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerUrlLabel
            // 
            this.ServerUrlLabel.AutoSize = true;
            this.ServerUrlLabel.Location = new System.Drawing.Point(12, 185);
            this.ServerUrlLabel.Name = "ServerUrlLabel";
            this.ServerUrlLabel.Size = new System.Drawing.Size(96, 25);
            this.ServerUrlLabel.TabIndex = 0;
            this.ServerUrlLabel.Text = "Server url";
            this.ServerUrlLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ServerUrlTextBox
            // 
            this.ServerUrlTextBox.Location = new System.Drawing.Point(144, 182);
            this.ServerUrlTextBox.Name = "ServerUrlTextBox";
            this.ServerUrlTextBox.Size = new System.Drawing.Size(412, 29);
            this.ServerUrlTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(909, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1179, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BrowseClient
            // 
            this.BrowseClient.Location = new System.Drawing.Point(3, 299);
            this.BrowseClient.Name = "BrowseClient";
            this.BrowseClient.Size = new System.Drawing.Size(118, 39);
            this.BrowseClient.TabIndex = 4;
            this.BrowseClient.Text = "....";
            this.BrowseClient.UseVisualStyleBackColor = true;
            this.BrowseClient.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(144, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1117, 29);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server Name";
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(144, 238);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(412, 29);
            this.ServerName.TabIndex = 7;
            // 
            // ClientPassword
            // 
            this.ClientPassword.Enabled = false;
            this.ClientPassword.Location = new System.Drawing.Point(171, 380);
            this.ClientPassword.Name = "ClientPassword";
            this.ClientPassword.Size = new System.Drawing.Size(412, 29);
            this.ClientPassword.TabIndex = 9;
            this.ClientPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Location = new System.Drawing.Point(12, 383);
            lab.Name = "lab";
            lab.Size = new System.Drawing.Size(153, 25);
            lab.TabIndex = 8;
            lab.Text = "Client Password";
            lab.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserId
            // 
            this.UserId.Enabled = false;
            this.UserId.Location = new System.Drawing.Point(144, 475);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(412, 29);
            this.UserId.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "User";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Password
            // 
            this.Password.Enabled = false;
            this.Password.Location = new System.Drawing.Point(144, 544);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(412, 29);
            this.Password.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Domain";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CreateConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 833);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ServerUrlTextBox);
            this.Controls.Add(this.ServerUrlLabel);
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
        private System.Windows.Forms.Button button1;
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
    }
}