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
    public partial class FCworkmarks : Form
    {
        private static int cardcode;
        private static int cworkmarkcode;
        private static int mark;
        private static string subject;
        private static string theme;
        
        public FCworkmarks(int CarddID)
        {
            cardcode = CarddID;
            InitializeComponent();
        }

        public FCworkmarks(int CardID, int CWorkmarksID, string Subject, string Theme, int Mark)
        {
            cardcode = CardID;
            cworkmarkcode = CWorkmarksID;
            subject = Subject;
            theme = Theme;
            mark = Mark;
            InitializeComponent();
            FormView();
        }

        private void FormView()
        {
            this.subjectnamesBindingSource.Filter = "snm_pcode =" + subject;
            tbTheme.Text = theme;
            tbMark.Text = mark.ToString();
        }

        private void FormEdit()
        {
        DataSetMainForm.cworkmarksRow editCworkmarksRow = dataSetMainForm.cworkmarks.FindBycmk_pcode(cworkmarkcode);

        try
        {
            editCworkmarksRow.cmk_crdcode = cardcode;
            editCworkmarksRow.cmk_mark = (short)Convert.ToInt32(tbMark.Text);
            editCworkmarksRow.cmk_marktype = 0;
            editCworkmarksRow.cmk_subject = Convert.ToInt32(dgSubject[0, dgSubject.CurrentRow.Index].Value.ToString());
            editCworkmarksRow.cmk_theme = tbTheme.Text;

            cworkmarksTableAdapter.Update(dataSetMainForm.cworkmarks);
            FCworkmarks.ActiveForm.Close();
        }
        catch
        {
            MessageBox.Show("Данные введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbFind.Focus();
        }
        }

        private void FormAdd()
        {
            DataSetMainForm.cworkmarksRow newCworkmarksRow = dataSetMainForm.cworkmarks.NewcworkmarksRow();

            try
            {
                newCworkmarksRow.cmk_crdcode = cardcode;
                newCworkmarksRow.cmk_mark = (short)Convert.ToInt32(tbMark.Text);
                newCworkmarksRow.cmk_marktype = 0;
                newCworkmarksRow.cmk_subject = Convert.ToInt32(dgSubject[0, dgSubject.CurrentRow.Index].Value.ToString());
                newCworkmarksRow.cmk_theme = tbTheme.Text;

                dataSetMainForm.cworkmarks.Rows.Add(newCworkmarksRow);
                cworkmarksTableAdapter.Update(dataSetMainForm.cworkmarks);
                FCworkmarks.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFind.Focus();
            }
        }


        private void CWorkmarks_Load(object sender, EventArgs e)
        {
            this.cworkmarksTableAdapter.Fill(this.dataSetMainForm.cworkmarks);
            this.subjectnamesTableAdapter.Fill(this.dataSetMainForm.subjectnames);
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.subjectnamesBindingSource.Filter = "snm_name LIKE '%" + tbFind.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Ошибка поиска. Присутствуют недопустимые символы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btOK_Click(object sender, EventArgs e)
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
