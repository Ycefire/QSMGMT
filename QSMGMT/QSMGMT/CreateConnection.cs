using Qlik.Engine;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QSMGMT
{
    public partial class CreateConnection : Form
    {

        private string PfxPath = "";
        private Form1 _form = null;

        public CreateConnection(Form1 form)
        {
            InitializeComponent();
            _form = form;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

              ServerUrlTextBox.Enabled = false;

            string url = ServerUrlTextBox.Text;

            ILocation location = new Connetion(url, PfxPath, ClientPassword.Text,UserId.Text,Password.Text).location;


            if (location.IsAlive()) {
                pictureBox1.Image = new Bitmap(@"C:\GITHUB\QSMGMT\QSMGMT\QSMGMT\Images\Success.png");
                _form.location = location;
            }
            else
            {
                pictureBox1.Image = new Bitmap(@"C:\GITHUB\QSMGMT\QSMGMT\QSMGMT\Images\Error.png");


                ServerUrlTextBox.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
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

                    PfxPath = Path.Combine(@"C:\GITHUB\QSMGMT\QSMGMT\QSMGMT\QS Certificates\" + ServerName.Text + @"\client.pfx");
                    System.IO.Directory.CreateDirectory(@"C:\GITHUB\QSMGMT\QSMGMT\QSMGMT\QS Certificates\" + ServerName.Text);
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
            button1.Enabled = true;
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CreateConnection_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
