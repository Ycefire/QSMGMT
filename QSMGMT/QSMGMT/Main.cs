using Qlik.Engine;
using QSMGMT.Repos;
using System;
using System.IO;
using System.Windows.Forms;

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
        
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateConnectionRepo();
        }

        //UPDATE CONNECTION ON FIRST LOAD OR START CREATION FORM
        private void CreateConnectionRepo()
        {
            try
            {
                _connRepo = new ConnectionRepository();
                RefreshCmbConnections();

            }
            catch (Exception ex)
            {

                CreateConnection ConnectionForm = new CreateConnection(this, ex.Message);
                ConnectionForm.ShowDialog();
            }
        }

        //REFRESH THE CONNECTIONS IN THE COMBOBOX
        internal void RefreshCmbConnections()
        {
            cmbConnections.DataSource = null;
            cmbConnections.Items.Clear();
            cmbConnections.DataSource = _connRepo.ConnectionList;
            cmbConnections.DisplayMember = "Name";
        }

        //UPDATE CURRENT CONNECTION WHEN SELECTION IN COMBOBOX IS UPDATED
        private void cmbConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentConn = (Connection)cmbConnections.SelectedItem;
        }
                

        /*================================================================================
                                   CONNECTIONS TO OTHER FORMS 
        ================================================================================*/

        /*============================= TOOLSTRIP BASED ================================*/
        //QS CONNECTION DIALOG
        private void newConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateConnection ConnectionForm = new CreateConnection(this);
            ConnectionForm.ShowDialog();
        }

        //QS SECURITY RULE MANAGER DIALOG
        private void securityRuleManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecurityRuleForm SecurityRuleForm = new SecurityRuleForm(this);
            this.Hide();
            SecurityRuleForm.ShowDialog();
        }

        /*============================= BUTTON BASED ================================*/
        //QS SECURITY RULE MANAGER DIALOG
        private void btnSecurtiyRules_Click(object sender, EventArgs e)
        {
            SecurityRuleForm SecurityRuleForm = new SecurityRuleForm(this);
            this.Hide();
            SecurityRuleForm.ShowDialog();

        }



    }
}
