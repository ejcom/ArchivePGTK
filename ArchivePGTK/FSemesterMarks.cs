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
    public partial class FSemesterMarks : Form
    {
        private static int semmarkscode;
        private static int cardcode;
        private static int semester;
        private static int mark;
        private static int ahours;
        private static int shours;
        private static string marktype;
        private static string subject;

        public FSemesterMarks(int CardCode)
        {
            cardcode = CardCode;
            InitializeComponent();
        }

        public FSemesterMarks(int CardID, int SemesterMarksID, int Semester, int Mark, int Ahours, int Shours, string Marktype, string Subject)
        {
            semmarkscode = SemesterMarksID;
            cardcode = CardID;
            semester = Semester;
            mark = Mark;
            ahours = Ahours;
            shours = Shours;
            marktype = Marktype;
            subject = Subject;
            InitializeComponent();
            FormView();
        }

        private void FormView()
        {
            this.subjectnamesBindingSource.Filter = "snm_pcode =" + subject;
            tb_semester.Text = semester.ToString();
            tb_mark.Text = mark.ToString();
            tb_ahours.Text = ahours.ToString();
            tb_shours.Text = shours.ToString();
        }

        private void FormEdit()
        {
            DataSetMainForm.semestermarksRow SemMarksRow = dataSetMainForm.semestermarks.FindBysmk_pcode(semmarkscode);

            try
            {
                SemMarksRow.smk_crdcode = cardcode;
                SemMarksRow.smk_subject = Convert.ToInt32(dgSubject[0, dgSubject.CurrentRow.Index].Value.ToString());
                SemMarksRow.smk_ahours = (short)Convert.ToInt32(tb_ahours.Text);
                SemMarksRow.smk_mark = (short)Convert.ToInt32(tb_mark.Text);
                SemMarksRow.smk_shours = (short)Convert.ToInt32(tb_shours.Text);
                SemMarksRow.smk_semester = (short)Convert.ToInt32(tb_semester.Text);
                SemMarksRow.smk_marktype = 1;

                semestermarksTableAdapter.Update(dataSetMainForm.semestermarks);
                FSemesterMarks.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_semester.Focus();
            }
        }

        private void FormAdd()
        {
            DataSetMainForm.semestermarksRow SemMarksRow = dataSetMainForm.semestermarks.NewsemestermarksRow();

            try
            {
                SemMarksRow.smk_crdcode = cardcode;
                SemMarksRow.smk_subject = Convert.ToInt32(dgSubject[0, dgSubject.CurrentRow.Index].Value.ToString());
                SemMarksRow.smk_ahours = (short)Convert.ToInt32(tb_ahours.Text);
                SemMarksRow.smk_mark = (short)Convert.ToInt32(tb_mark.Text);
                SemMarksRow.smk_shours = (short)Convert.ToInt32(tb_shours.Text);
                SemMarksRow.smk_semester = (short)Convert.ToInt32(tb_semester.Text);
                SemMarksRow.smk_marktype = 1;

                dataSetMainForm.semestermarks.Rows.Add(SemMarksRow);
                semestermarksTableAdapter.Update(dataSetMainForm.semestermarks);
                FSemesterMarks.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_semester.Focus();
            }
        }

        private void FSemesterMarks_Load(object sender, EventArgs e)
        {
            this.semestermarksTableAdapter.Fill(this.dataSetMainForm.semestermarks);
            this.subjectnamesTableAdapter.Fill(this.dataSetMainForm.subjectnames);
        }

        private void tb_Find_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.subjectnamesBindingSource.Filter = "snm_name LIKE '%" + tb_Find.Text + "%'";
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
