using Qlik.Engine;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QSMGMT
{
    public partial class CreateConnection : Form
    {
       
        public CreateConnection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerUrlTextBox.Enabled = false;

            string url = ServerUrlTextBox.Text;

            ILocation location = new Connetion(url).location;


            if (location.IsAlive()) {
                pictureBox1.Image = new Bitmap(@"C:\GITHUB\QSMGMT\QSMGMT\QSMGMT\Images\Success.png");
               
            }
            else{
                pictureBox1.Image = new Bitmap(@"C:\GITHUB\QSMGMT\QSMGMT\QSMGMT\Images\Error.png");


                ServerUrlTextBox.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.InitialDirectory = Application.ExecutablePath.ToString();
            openFileDialog.Filter = "Pfx files (*.pfx)|*.pfx|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string newPath = Path.Combine(@"C:\GITHUB\QSMGMT\QSMGMT\QSMGMT\QS Certificates\CRED DEMO SERVER\CREDON35\client2.pfx");
                string destFile = Path.Combine(Path.GetFullPath(openFileDialog.FileName));
                textBox1.Text = destFile;

                File.Copy(openFileDialog.FileName, newPath, true);
            }
        
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
    }
}
