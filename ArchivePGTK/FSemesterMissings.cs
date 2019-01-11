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
    public partial class FSemesterMissings : Form
    {
        private static int smmID;
        private static int crdcode;
        private static int semester;
        private static int lmissings;
        private static int imissings;


        public FSemesterMissings(int CardCode)
        {
            crdcode = CardCode;
            InitializeComponent();
        }

        public FSemesterMissings(int SemesterMissingID, int CardCode, int Semester, int LMissings, int IMissings)
        {
            smmID = SemesterMissingID;
            crdcode = CardCode;
            semester = Semester;
            lmissings = LMissings;
            imissings = IMissings;
            InitializeComponent();
            FormView();
        }

        private void FormView()
        {
            tb_Sem.Text = semester.ToString();
            tb_imiss.Text = imissings.ToString();
            tb_lmiss.Text = lmissings.ToString();
        }

        private void FormEdit()
        {
            DataSetMainForm.semestermissingsRow SemesterMissingsRow = dataSetMainForm.semestermissings.FindBysmm_pcode(smmID);

            try
            {
                SemesterMissingsRow.smm_crdcode = crdcode;
                SemesterMissingsRow.smm_semester = (short)Convert.ToInt32(tb_Sem.Text);
                SemesterMissingsRow.smm_imissings = (short)Convert.ToInt32(tb_imiss.Text);
                SemesterMissingsRow.smm_lmissings = (short)Convert.ToInt32(tb_lmiss.Text);

                semestermissingsTableAdapter.Update(dataSetMainForm.semestermissings);
                FSemesterMissings.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Sem.Focus();
            }
        }

        private void FormAdd()
        {
            DataSetMainForm.semestermissingsRow SemesterMissingsRow = dataSetMainForm.semestermissings.NewsemestermissingsRow();

            try
            {
                SemesterMissingsRow.smm_crdcode = crdcode;
                SemesterMissingsRow.smm_semester = (short)Convert.ToInt32(tb_Sem.Text);
                SemesterMissingsRow.smm_imissings = (short)Convert.ToInt32(tb_imiss.Text);
                SemesterMissingsRow.smm_lmissings = (short)Convert.ToInt32(tb_lmiss.Text);

                dataSetMainForm.semestermissings.Rows.Add(SemesterMissingsRow);
                semestermissingsTableAdapter.Update(dataSetMainForm.semestermissings);
                FSemesterMissings.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Sem.Focus();
            }
        }

        private void FSemesterMissings_Load(object sender, EventArgs e)
        {
            this.semestermissingsTableAdapter.Fill(this.dataSetMainForm.semestermissings);
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
