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
using QSMGMT.Repos;

namespace QSMGMT
{
    public partial class Form1 : Form
    {
        private ConnectionRepository _connRepo = new ConnectionRepository();
        private Connection _currentConn;
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

        internal ConnectionRepository ConnRepo
        {
            get
            {
                return _connRepo;
            }

            set
            {
                _connRepo = value;
            }
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
            try
            { 
                RefreshCmbConnections();
               
            }
            catch (Exception ex)
            {

                CreateConnection ConnectionForm = new CreateConnection(this,ex.Message);
                ConnectionForm.ShowDialog();
            }
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

        internal void RefreshCmbConnections()
        {
            cmbConnections.DataSource = null;
            cmbConnections.Items.Clear();
            cmbConnections.DataSource = _connRepo.ConnectionList;
            cmbConnections.DisplayMember = "Name";
        }

        private void showConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void newConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateConnection ConnectionForm = new CreateConnection(this);
            ConnectionForm.ShowDialog();
        }

        private void cmbConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentConn = (Connection)cmbConnections.SelectedItem;
        }
    }
}
