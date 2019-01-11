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
    public partial class FPersCards : Form
    {
        public FPersCards()
        {
            InitializeComponent();
        }

        private static bool DialogView = true;
        private static bool EditMode = false;

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
            
            if (parent is ComboBox)
            {
                ((ComboBox)parent).Enabled = state;
                return;
            }
            foreach (Control control in parent.Controls)
                SetEnabledControls(state, control);
            
        }

        private void FormAdd()
        {
            DataSetMainForm.cardsRow newCardsRow = dataSetMainForm.cards.NewcardsRow();

            try
            {
                newCardsRow.crd_psncode = Buffer.MFPersonBuffer;
                newCardsRow.crd_spccode = Convert.ToInt32(crd_spccodeListBox.SelectedValue);
                newCardsRow.crd_workplace = crd_workplaceTextBox.Text;
                newCardsRow.crd_workpost = crd_workpostTextBox.Text;
                newCardsRow.crd_outschool = Convert.ToInt32(crd_OutScoolListBox.SelectedValue);
                newCardsRow.crd_inschool = Convert.ToInt32(crd_InScoolListBox.SelectedValue);
                newCardsRow.crd_remanded = Convert.ToByte(crd_remadnstatuscomboBox.SelectedValue);
                newCardsRow.crd_remandreason = crd_remandreasonTextBox.Text;
                newCardsRow.crd_bdate = crd_bdateDateTimePicker.Value;
                newCardsRow.crd_edate = crd_edateDateTimePicker.Value;
                newCardsRow.crd_docdate = crd_docdateDateTimePicker.Value;
                newCardsRow.crd_docname = crd_docnameTextBox.Text;
                newCardsRow.crd_docorg = crd_docorgTextBox.Text;
                newCardsRow.crd_dipdate = dtpDipdate.Value;
                newCardsRow.crd_dipregnum = tbDipregnum.Text;
                newCardsRow.crd_dipserial = tbDipserial.Text;


                dataSetMainForm.cards.Rows.Add(newCardsRow);
                cardsTableAdapter.Update(dataSetMainForm.cards);

            }
            catch
            {
                FModalDialog frmErrorDialog = new FModalDialog("Ошибка", "Ошибка обновления данных", false);
                frmErrorDialog.ShowDialog();
                if (frmErrorDialog.DialogResult == DialogResult.OK) crd_spccodeListBox.Focus();
            }
        }

        private void FormView()
        {
            crd_bdateDateTimePicker.DataBindings.Add("Value", cardsBindingSource, "crd_bdate");
            crd_spccodeListBox.DataBindings.Add("SelectedValue", cardsBindingSource, "crd_spccode");
            crd_OutScoolListBox.DataBindings.Add("SelectedValue", cardsBindingSource, "crd_outschool");
            crd_InScoolListBox.DataBindings.Add("SelectedValue", cardsBindingSource, "crd_inschool");
            crd_remadnstatuscomboBox.DataBindings.Add("SelectedValue", cardsBindingSource, "crd_remanded");
            crd_remandreasonTextBox.DataBindings.Add("Text", cardsBindingSource, "crd_remandreason");
            crd_edateDateTimePicker.DataBindings.Add("Value", cardsBindingSource, "crd_edate");
            crd_docdateDateTimePicker.DataBindings.Add("Value", cardsBindingSource, "crd_docdate");
            crd_docnameTextBox.DataBindings.Add("Text", cardsBindingSource, "crd_docname");
            crd_docorgTextBox.DataBindings.Add("Text", cardsBindingSource, "crd_docorg");
            crd_workplaceTextBox.DataBindings.Add("Text", cardsBindingSource, "crd_workplace");
            crd_workpostTextBox.DataBindings.Add("Text", cardsBindingSource, "crd_workpost");
            tbDipregnum.DataBindings.Add("Text", cardsBindingSource, "crd_dipregnum");
            tbDipserial.DataBindings.Add("Text", cardsBindingSource, "crd_dipserial");
            dtpDipdate.DataBindings.Add("Value", cardsBindingSource, "crd_dipdate");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.remandstatusTableAdapter.Fill(this.dataSetMainForm.remandstatus);
            this.specialitiesTableAdapter.Fill(this.dataSetMainForm.specialities);
            this.cardsTableAdapter.Fill(this.dataSetMainForm.cards);
            this.schoolsTableAdapter.Fill(this.dataSetMainForm.schools);

            switch (Buffer.State)
            {
                case "view":
                    DialogView = false;
                    this.cardsBindingSource.Filter = "crd_pcode =" + Convert.ToString(Buffer.MFCardsBuffer);
                    FormView();
                    SetEnabledControls(false, this);
                    button1.Enabled = false;
                    cbEditMode.CheckState = CheckState.Unchecked;
                    break;
                case "add":
                    cbEditMode.Enabled = false;
                    DialogView = true;
                    EditMode = false;
                    break;
                case "edit":
                    DialogView = true;
                    this.cardsBindingSource.Filter = "crd_pcode =" + Convert.ToString(Buffer.MFCardsBuffer);
                    FormView();
                    EditMode = true;
                    SetEnabledControls(true, this);
                    button1.Enabled = true;
                    cbEditMode.CheckState = CheckState.Checked;
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogView == true && EditMode == false)
            {
                if (MessageBox.Show("Cохранить изменения?", "Сохранить", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    FormAdd();
                    FPersCards.ActiveForm.Close();
                }
                else crd_bdateDateTimePicker.Focus();
            }
            else if (EditMode == true)
            {
                cardsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.dataSetMainForm);
                FPersCards.ActiveForm.Close();
            }
            else crd_bdateDateTimePicker.Focus();
        }

        private void FPersCards_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void cbEditMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditMode.CheckState == CheckState.Checked)
            {
                SetEnabledControls(true, this);
                DialogView = true;
                EditMode = true;
                button1.Enabled = true;
            }
            else
            {
                SetEnabledControls(false, this);
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogView == true && EditMode == true)
            {
                if (MessageBox.Show("Отменить изменения?", "Отмена", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.cardsBindingSource.CancelEdit();
                    FPersCards.ActiveForm.Close();
                }
                else crd_bdateDateTimePicker.Focus();
            }
            else FPersonAdd.ActiveForm.Close();
        }
                
    }
}
