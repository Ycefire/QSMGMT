using Qlik.Engine;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QSMGMT.Repos;

namespace QSMGMT
{
    public partial class CreateConnection : Form
    {

        private string PfxPath = "";
        private Form1 _form = null;
        private string _currentDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public CreateConnection(Form1 form)
        {
            InitializeComponent();
            _form = form;
        }

        public CreateConnection (Form1 form, string error)
        {
            InitializeComponent();
            _form = form;
            lblError.Text = error;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

              ServerUrlTextBox.Enabled = false;

            Connection conn = new Connection(ServerUrlTextBox.Text, @"\QS Certificates\" + ServerName.Text + @"\client.pfx", ClientPassword.Text,UserId.Text,Password.Text, ServerName.Text);
            conn.ConnectToQlikSense();

            ILocation location = conn.Location;

            if (location.IsAlive()) {
                pictureBox1.Image = new Bitmap(Path.Combine(_currentDir + @"\Images\Success.png"));
                _form.location = location;
                btnSave.Enabled = true;
            }
            else
            {
                pictureBox1.Image = new Bitmap(Path.Combine(_currentDir + @"\Images\Error.png"));
                ServerUrlTextBox.Enabled = true;
            }
            
        }

        private void BrowseClient_Click(object sender, EventArgs e)
        {
            if(ServerName.Text.Length >= 0)
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();


                openFileDialog.InitialDirectory = Application.ExecutablePath.ToString();
                openFileDialog.Filter = "Pfx files (*.pfx)|*.pfx|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    PfxPath = Path.Combine(_currentDir + @"\QS Certificates\" + ServerName.Text + @"\client.pfx");
                    System.IO.Directory.CreateDirectory(Path.Combine(_currentDir + @"\QS Certificates\" + ServerName.Text));
                    string destFile = Path.Combine(Path.GetFullPath(openFileDialog.FileName));
                    textBox1.Text = destFile;

                    File.Copy(openFileDialog.FileName, PfxPath, true);
                }
            }else
            {
                MessageBox.Show("Fill in Server Name");
            }

            ClientPassword.Enabled = true;
            Password.Enabled = true;
            UserId.Enabled = true;
            btnTest.Enabled = true;

        }

        private void CreateConnection_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conn = new Connection(ServerUrlTextBox.Text, @"\QS Certificates\" + ServerName.Text, ClientPassword.Text, UserId.Text, Password.Text, ServerName.Text);
                _form.ConnRepo.AddConnection(conn);
                _form.RefreshCmbConnections();
                this.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                btnSave.Enabled = false;
            }
        }
    }
}
