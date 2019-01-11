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
    public partial class FFinalmarksAdd : Form
    {
        private static int crdcode;
        private static int finalmarkscode;
        private static string subjectname;
        private static int ahours;
        private static int mhours;
        private static int mark;

        public FFinalmarksAdd(int CardCode)
        {
            crdcode = CardCode;
            InitializeComponent();
        }

        public FFinalmarksAdd(int CardID, string SubjectName, int FinalmarksID, int Ahours, int Mhours, int Mark)
        {
            crdcode = CardID;
            finalmarkscode = FinalmarksID;
            subjectname = SubjectName;
            ahours = Ahours;
            mhours = Mhours;
            mark = Mark;
            InitializeComponent();
            FormView();
        }

        private void FormView()
        {
            this.subjectnamesBindingSource.Filter = "snm_pcode =" + subjectname;
            tb_ahours.Text = ahours.ToString();
            tb_mhours.Text = mhours.ToString();
            tb_mark.Text = mark.ToString();
        }

        private void FormEdit()
        {
            DataSetMainForm.finalmarksRow FinalmarksRow = dataSetMainForm.finalmarks.FindByfmk_pcode(finalmarkscode);

            try
            {
                FinalmarksRow.fmk_crdcode = crdcode;
                FinalmarksRow.fmk_subject = Convert.ToInt32(dgSubject[0, dgSubject.CurrentRow.Index].Value.ToString());
                FinalmarksRow.fmk_ahours = Convert.ToInt32(tb_ahours.Text);
                FinalmarksRow.fmk_mhours = Convert.ToInt32(tb_mhours.Text);
                FinalmarksRow.fmk_mark = (short)Convert.ToInt32(tb_mark.Text);
                FinalmarksRow.fmk_marktype = "F";

                finalmarksTableAdapter.Update(dataSetMainForm.finalmarks);
                FFinalmarksAdd.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_ahours.Focus();
            }
        }

        private void FormAdd()
        {
            DataSetMainForm.finalmarksRow FinalmarksRow = dataSetMainForm.finalmarks.NewfinalmarksRow();

            try
            {
                FinalmarksRow.fmk_crdcode = crdcode;
                FinalmarksRow.fmk_subject = Convert.ToInt32(dgSubject[0, dgSubject.CurrentRow.Index].Value.ToString());
                FinalmarksRow.fmk_ahours = Convert.ToInt32(tb_ahours.Text);
                FinalmarksRow.fmk_mhours = Convert.ToInt32(tb_mhours.Text);
                FinalmarksRow.fmk_mark = (short)Convert.ToInt32(tb_mark.Text);
                FinalmarksRow.fmk_marktype = "F";

                dataSetMainForm.finalmarks.Rows.Add(FinalmarksRow);
                finalmarksTableAdapter.Update(dataSetMainForm.finalmarks);
                FFinalmarksAdd.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_ahours.Focus();
            }
        }

        private void FFinalmarksAdd_Load(object sender, EventArgs e)
        {
            this.finalmarksTableAdapter.Fill(this.dataSetMainForm.finalmarks);
            this.subjectnamesTableAdapter.Fill(this.dataSetMainForm.subjectnames);
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

    }
}
