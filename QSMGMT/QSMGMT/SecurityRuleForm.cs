using QSMGMT.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSMGMT
{
    public partial class SecurityRuleForm : Form
    {

        private ConnectionRepository _connRepo;
        private Main _form = null;
        private Connection _currentConn;

        public SecurityRuleForm(Main form)
        {
            InitializeComponent();
            _form = form;

            InitializeDataGrid();

        }

        private void InitializeDataGrid()
        {

            DataGridViewButtonColumn upDateButtonColumn = new DataGridViewButtonColumn();
            upDateButtonColumn.Name = "Update_column";
            upDateButtonColumn.Text = "Update";
            upDateButtonColumn.HeaderText = "Update";
            upDateButtonColumn.UseColumnTextForButtonValue = true;
            dgvSysRules.CellClick += dgvSysRules_CellClick;
            int columnIndex = 0;
            if (dgvSysRules.Columns["Update_column"] == null)
            {
                dgvSysRules.Columns.Insert(columnIndex, upDateButtonColumn);
            }
        }

        private void dgvSysRules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSysRules.Columns["Update_column"].Index)
            {
                //Do something with your button.
                lblError.Text = "Update Button Cliked on row " + e.RowIndex + "!";

            }
        }

        private void SecurityRuleForm_Load(object sender, EventArgs e)
        { 
                _connRepo = new ConnectionRepository();
                RefreshCmbConnections();    
        }
        private void cmbConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentConn = (Connection)cmbConnections.SelectedItem;
            RefreshServerInfo(_currentConn);
        }

        internal void RefreshCmbConnections()
        {
            cmbConnections.DataSource = null;
            cmbConnections.Items.Clear();
            cmbConnections.DataSource = _connRepo.ConnectionList;
            cmbConnections.DisplayMember = "Name";
        }

        private void SecurityRuleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form.Show();
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
