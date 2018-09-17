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
    public partial class Main : Form
    {
        private ConnectionRepository _connRepo;
        private Connection _currentConn;
        private ILocation _location = null;

        public Main()
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
                _connRepo = new ConnectionRepository();
                RefreshCmbConnections();
               
            }
            catch (Exception ex)
            {

                CreateConnection ConnectionForm = new CreateConnection(this,ex.Message);
                ConnectionForm.ShowDialog();
            }
         
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
            RefreshServerInfo(_currentConn);
        }

        private void RefreshServerInfo(Connection conn)
        {
            try
            {
                txtServerInfo.Text = conn.QsRepoAPI.GetSecurityRulesJSON();
                dgvSysRules.DataSource = conn.QsRepoAPI.GetSecurityRules();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message + "\r\n" + ex.InnerException.Message;
            }
        }
    }
}
