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
    public partial class FPractic : Form
    {
        private static int praccode;
        private static int crdcode;
        private static int semester;
        private static int type;
        private static decimal length;
        private static int mark;
        private static int name;

        public FPractic(int CardID)
        {
            crdcode = CardID;
            InitializeComponent();
        }

        public FPractic(int CardID, int PracticID, int Semester, int Type, decimal Length, int Mark, int Name)
        {
            praccode = PracticID;
            crdcode = CardID;
            semester = Semester;
            type = Type;
            length = Length;
            mark = Mark;
            name = Name;
            InitializeComponent();
            FormView();
            
        }

        private void FormView()
        {
            this.practicnamesBindingSource.Filter = "pnm_pcode = " + name;
            cbType.SelectedValue = type;
            tbLength.Text = length.ToString();
            tbMark.Text = mark.ToString();
            tbSem.Text = semester.ToString();
        }

        private void FormAdd()
        {
            DataSetMainForm.practicmarksRow PracticMarksRow = dataSetMainForm.practicmarks.NewpracticmarksRow();

            try
            {
                PracticMarksRow.pmk_crdcode = crdcode;
                PracticMarksRow.pmk_mark = (short)Convert.ToInt32(tbMark.Text);
                PracticMarksRow.pmk_name = Convert.ToInt32(dgName[0, dgName.CurrentRow.Index].Value.ToString());
                PracticMarksRow.pmk_semester = (short)Convert.ToInt32(tbSem.Text);
                PracticMarksRow.pmk_type = Convert.ToInt16(cbType.SelectedValue);
                PracticMarksRow.pmk_weeklength = Convert.ToDecimal(tbLength.Text);

                dataSetMainForm.practicmarks.Rows.Add(PracticMarksRow);
                practicmarksTableAdapter.Update(dataSetMainForm.practicmarks);
                FPractic.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSem.Focus();
            }
        }

        private void FormEdit()
        {
            DataSetMainForm.practicmarksRow PracticMarksRow = dataSetMainForm.practicmarks.FindBypmk_pcode(praccode);

            try
            {
                PracticMarksRow.pmk_crdcode = crdcode;
                PracticMarksRow.pmk_mark = (short)Convert.ToInt32(tbMark.Text);
                PracticMarksRow.pmk_name = Convert.ToInt32(dgName[0, dgName.CurrentRow.Index].Value.ToString());
                PracticMarksRow.pmk_semester = (short)Convert.ToInt32(tbSem.Text);
                PracticMarksRow.pmk_type = Convert.ToInt16(cbType.SelectedValue);
                PracticMarksRow.pmk_weeklength = Convert.ToDecimal(tbLength.Text);

                practicmarksTableAdapter.Update(dataSetMainForm.practicmarks);
                FPractic.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSem.Focus();
            }
        }

        private void practicmarksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.practicmarksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetMainForm);

        }

        private void FPractic_Load(object sender, EventArgs e)
        {
            this.practictypesTableAdapter.Fill(this.dataSetMainForm.practictypes);
            this.practicnamesTableAdapter.Fill(this.dataSetMainForm.practicnames);
            this.practicmarksTableAdapter.Fill(this.dataSetMainForm.practicmarks);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FPractNames frmPracNames = new FPractNames();
            frmPracNames.ShowDialog();
            this.practicnamesTableAdapter.Fill(this.dataSetMainForm.practicnames);
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.practicnamesBindingSource.Filter = "pnm_name LIKE '%" + tbFind.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Ошибка поиска. Присутствуют недопустимые символы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            switch (Buffer.State)
            {
                case "add":
                    FormAdd();
                    break;
                case "edit":
                    FormEdit();
                    break;
            }
        }

    }
}
