using QSMGMT.QS_Classes;
using QSMGMT.Repos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        #region variables
        private ConnectionRepository _connRepo;
        private Main _form = null;
        private Connection _currentConn;
        private ObservableCollection<SystemRule> securityRules;
        private List<Actions> _actionList = new List<Actions>();
        #endregion variables

        public SecurityRuleForm(Main form)
        {
            InitializeComponent();
            _form = form;
            _connRepo = form.ConnRepo;

            InitializeDataGrid();
            InitializeDetailObjects();

            RefreshCmbConnections();
            RefreshServerInfo((Connection)cmbConnections.SelectedItem);
        }

        private void InitializeDetailObjects()
        {

            dtpCreationDate.Format = DateTimePickerFormat.Custom;
            dtpCreationDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dtpModifiedDate.Format = DateTimePickerFormat.Custom;
            dtpModifiedDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            _actionList.Add(new Actions(cbApprove, 4096));
            _actionList.Add(new Actions(cbDuplicate, 2048));
            _actionList.Add(new Actions(cbDuplicate, 1024));
            _actionList.Add(new Actions(cbAccessOffline, 512));
            _actionList.Add(new Actions(cbExportData, 256));
            _actionList.Add(new Actions(cbChangeRole, 128));
            _actionList.Add(new Actions(cbChangeOwner, 64));
            _actionList.Add(new Actions(cbPublish, 32));
            _actionList.Add(new Actions(cbExport, 16));
            _actionList.Add(new Actions(cbDelete, 8));
            _actionList.Add(new Actions(cbUpdate, 4));
            _actionList.Add(new Actions(cbRead, 2));
            _actionList.Add(new Actions(cbActionCreate, 1));
        }

        private void InitializeDataGrid()
        {
            dgvSysRules.ReadOnly = true;
            dgvSysRules.Width = Screen.PrimaryScreen.Bounds.Width;
            dgvSysRules.MultiSelect = false;
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
                securityRules = conn.QsRepoAPI.GetSecurityRules();
                dgvSysRules.DataSource = securityRules;
                //textBox1.Text = conn.QsRepoAPI.GetCountResourcesJSON();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message + "\r\n" + ex.InnerException.Message;
            }
        }


        #region Button actions

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SystemRule sysrule = (SystemRule)dgvSysRules.CurrentRow.DataBoundItem;
                var obcSysrule = securityRules.Single(s => s.id == sysrule.id);

                obcSysrule.name = txtName.Text;
                obcSysrule.rule = txtRule.Text;

                Int64 Action = 0;
                foreach (Actions action in _actionList)
                {
                    if (action.ActionValue != 1024)
                    {
                        if (action.ActionCheckBox.Checked)
                        {
                            Action += action.ActionValue;
                        }
                    }
                }

                obcSysrule.actions = Action;
                obcSysrule.resourceFilter = txtResourceFilters.Text;
                obcSysrule.comment = txtComments.Text;
                obcSysrule.disabled = cbDisabled.Checked;
                obcSysrule.RuleContext = (RuleContext)Enum.Parse(typeof(RuleContext), cbContext.SelectedItem.ToString());


                //Update QS via Repo API
                SystemRule updatedSysRule = _currentConn.QsRepoAPI.UpdateSingleSecurityRule(sysrule);

                obcSysrule.modifiedByUserName = updatedSysRule.modifiedByUserName;
                obcSysrule.modifiedDate = updatedSysRule.modifiedDate;


                dgvSysRules.Refresh();
            }
            catch (Exception ex)
            {
                txtServerInfo.Text = "Update failed: " + ex.Message;

            }

        }

        private void DgvSysRules_DataSourceChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SystemRule sysrule = (SystemRule)dgvSysRules.CurrentRow.DataBoundItem;

                dgvSysRules[1,0].Selected = true;
                securityRules.Remove(sysrule);

                //Update QS via Repo API
                txtServerInfo.Text = _currentConn.QsRepoAPI.DeleteSecurityRule(sysrule);

            }
            catch (Exception ex)
            {
                txtServerInfo.Text = "Delete failed: " + ex.Message;
            }
        }

        #endregion Button actions

        private void UpdateDetails()
        {
            try
            {

                SystemRule securtiyRule = (SystemRule)dgvSysRules.CurrentRow.DataBoundItem;

                cbContext.DataSource = Enum.GetValues(typeof(RuleContext));
                RuleContext ruleContext = securtiyRule.RuleContext;
                cbContext.SelectedItem = ruleContext;

                UpdateActions(securtiyRule);


                txtId.Text = securtiyRule.id;
                dtpCreationDate.Text = securtiyRule.createdDate.ToString();
                dtpModifiedDate.Text = securtiyRule.modifiedDate.ToString();
                txtModifiedUser.Text = securtiyRule.modifiedByUserName;
                txtCategory.Text = securtiyRule.category;
                txtType.Text = securtiyRule.type;
                txtName.Text = securtiyRule.name;
                txtRule.Text = securtiyRule.rule;
                txtComments.Text = securtiyRule.comment;
                txtResourceFilters.Text = securtiyRule.resourceFilter;
                cbDisabled.Checked = securtiyRule.disabled;
            }
            catch
            {
                MessageBox.Show("Nothing selected");
            }
        }

        private void UpdateActions(SystemRule securtiyRule)
        {

            foreach (Actions action in _actionList)
            {
                if (action.ActionValue != 1024)
                {
                    action.ActionCheckBox.Checked = false;

                }
            }

            var actionNum = securtiyRule.actions;
            foreach (Actions action in _actionList)
            {

                if (actionNum - action.ActionValue >= 0)
                {
                    if (action.ActionValue == 1024)
                    {
                        actionNum -= action.ActionValue;
                    }
                    else
                    {
                        actionNum -= action.ActionValue;
                        action.ActionCheckBox.Checked = true;

                    }
                }
            }
        }

        #region Update details based on datagrid events

        //datagrid cell enter
        private void dgvSysRules_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDetails();
        }

        //datagrid row selection changed
        private void dgvSysRules_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSysRules.SelectedRows.Count > 0)
            {
                UpdateDetails();
            }
        }

        #endregion Update details based on datagrid events

        private void SecurityRuleForm_Load(object sender, EventArgs e)
        {

        }


    }
}
