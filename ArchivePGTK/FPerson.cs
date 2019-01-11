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
    public partial class FPersonAdd : Form
    {
        private static bool DialogView = true;

        private static void SetEnabledControls(bool state, Control parent)
        {
            if (parent is TextBox)
            {
                ((TextBox)parent).Enabled = state;
                return;
            }
            if (parent is RadioButton)
            {
                ((RadioButton)parent).Enabled = state;
                return;
            }
            if (parent is DateTimePicker)
            {
                ((DateTimePicker)parent).Enabled = state;
                return;
            }
            foreach (Control control in parent.Controls)
                SetEnabledControls(state, control);
        }

        public FPersonAdd()
        {
            InitializeComponent();
        }

        private void personsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogView == true)
                {
                    FModalDialog frmSaveDialog = new FModalDialog("Сохранить", "Сохранить данные?", true);
                    frmSaveDialog.ShowDialog();
                    if (frmSaveDialog.DialogResult == DialogResult.OK)
                    {
                        this.Validate();
                        this.personsBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.dataSetMainForm);
                        FPersonAdd.ActiveForm.Close();
                    }
                    else if (frmSaveDialog.DialogResult == DialogResult.Cancel)
                        psn_fnameTextBox.Focus();

                }
                else FPersonAdd.ActiveForm.Close();
            }
            catch
            {
                FModalDialog frmErrorOfAdd = new FModalDialog("Ошибка", "Ошибка сохранения данных!", false);
                frmErrorOfAdd.ShowDialog();
                psn_fnameTextBox.Focus();
            }

        }

        private void FPCardAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetMainForm.persons". При необходимости она может быть перемещена или удалена.
            this.personsTableAdapter.Fill(this.dataSetMainForm.persons);
            switch (Buffer.State)
            {
                case "view":
                    DialogView = false;
                    this.personsBindingSource.Filter = "psn_pcode =" + Convert.ToString(Buffer.MFPersonBuffer);
                    SetEnabledControls(false, this);
                    cbEditMode.CheckState = CheckState.Unchecked;
                    break;
                case "add":
                    DialogView = true;
                    this.personsBindingSource.AddNew();
                    break;
                case "edit":
                    DialogView = true;

                    break;

                    
            }

        }

        private void Close(object sender, EventArgs e)
        {
            FPersonAdd.ActiveForm.Close();
            
        }

        private void FPersonAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogView == true)
            {
                FModalDialog frmCancelDialog = new FModalDialog("Отмена", "Закрыть и отменить изменения?", true);
                frmCancelDialog.ShowDialog();
                if (frmCancelDialog.DialogResult == DialogResult.OK)
                {
                    this.personsBindingSource.CancelEdit();
                    FPersonAdd.ActiveForm.Close();
                }
                else if (frmCancelDialog.DialogResult == DialogResult.Cancel)
                    psn_fnameTextBox.Focus();
            }
            else FPersonAdd.ActiveForm.Close();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbEditMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditMode.CheckState == CheckState.Checked)
            {
                SetEnabledControls(true, this);
                DialogView = true;
            }
            else SetEnabledControls(false, this);
        }

    }
}
