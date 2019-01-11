using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArchivePGTK
{
    public partial class FAccounts : Form
    {
        public FAccounts()
        {
            InitializeComponent();
        }

        private void FormAdd()
        {
            DataSetMainForm.accountsRow AccRow = dataSetMainForm.accounts.NewaccountsRow();

            try
            {
                AccRow.aco_name = tbAccName.Text;
                AccRow.aco_login = tbLogin.Text;
                AccRow.aco_password = AES.Encrypt(tbPass.Text, "pgtt", "ejikcom", "SHA1", 3, "zFRna73Om*ae01yY", 256);
                AccRow.aco_role = Convert.ToInt32(tbRole.Text);

                dataSetMainForm.accounts.Rows.Add(AccRow);
                accountsTableAdapter.Update(dataSetMainForm.accounts);
                accountsTableAdapter.Fill(dataSetMainForm.accounts);
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAccName.Focus();
            }
        }
        private void FormEdit()
        {
            DataSetMainForm.accountsRow AccRow = dataSetMainForm.accounts.FindByaco_pcode(Convert.ToInt32(accountsDataGridView[0, accountsDataGridView.CurrentRow.Index].Value.ToString()));

            try
            {
                AccRow.aco_pcode = Convert.ToInt32(accountsDataGridView[0, accountsDataGridView.CurrentRow.Index].Value.ToString());
                AccRow.aco_name = tbAccName.Text;
                AccRow.aco_login = tbLogin.Text;
                AccRow.aco_password = AES.Encrypt(tbPass.Text, "pgtt", "ejikcom", "SHA1", 3, "zFRna73Om*ae01yY", 256);
                AccRow.aco_role = Convert.ToInt32(tbRole.Text);

                accountsTableAdapter.Update(dataSetMainForm.accounts);
                accountsTableAdapter.Fill(dataSetMainForm.accounts);
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAccName.Focus();
            }
        }

        private void accountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetMainForm);

        }

        private void FAccountsEdit_Load(object sender, EventArgs e)
        {
            this.accountsTableAdapter.Fill(this.dataSetMainForm.accounts);
        }

        private void accountsDataGridView_Click(object sender, EventArgs e)
        {
            tbAccName.Text = accountsDataGridView[1, accountsDataGridView.CurrentRow.Index].Value.ToString();
            tbLogin.Text = accountsDataGridView[2, accountsDataGridView.CurrentRow.Index].Value.ToString();
            tbPass.Text = "000000";
            tbRole.Text = accountsDataGridView[4, accountsDataGridView.CurrentRow.Index].Value.ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAdd();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            FormEdit();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить пользователя?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                accountsDataGridView.Rows.RemoveAt(accountsDataGridView.CurrentCell.RowIndex);
                accountsTableAdapter.Update(this.dataSetMainForm);
            }
            else accountsDataGridView.Focus();
        }
    }
}
