using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using Qlik.Engine;
using Qlik.Engine.Communication;
using System.IO;

namespace QSMGMT
{
    public partial class Form1 : Form
    {
        private ILocation _location = null;

        public Form1()
        {
            InitializeComponent();

        }

        public ILocation location
        {
            get { return _location; }
            set { _location = value; }
        }

        internal static byte[] ReadFile(string fileName)
        {
            FileStream f = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int size = (int)f.Length;
            byte[] data = new byte[size];
            size = f.Read(data, 0, size);
            f.Close();
            return data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ILocation location = new Connetion().location;

            //MessageBox.Show("Alive: " + location.IsAlive());

            //List<String> test = new List<String>();

            //foreach (IAppIdentifier appIdentifier in location.GetAppIdentifiers())
            //{
            //    Console.WriteLine(appIdentifier.AppName);
            //    test.Add(appIdentifier.AppName);
            //}

            //listBox1.DataSource = test;
        }

        private void showConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void newConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateConnection ConnectionForm = new CreateConnection(this);
            ConnectionForm.ShowDialog();
        }
    }
}
