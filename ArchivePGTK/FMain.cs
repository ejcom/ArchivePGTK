using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using MigraDoc;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace ArchivePGTK
{
    public partial class Form1 : Form
    {
        Word._Application oWord;
        Word._Document oDoc;

        public Form1()
        {
            InitializeComponent();
        }

        private void ReloadAllOfCards()
        {
            if (dgCards.CurrentRow != null)
            {
                finalmarksBindingSource.Filter = "fmk_crdcode = " + dgCards[0, dgCards.CurrentRow.Index].Value.ToString();
                this.finalmarksTableAdapter.Fill(this.dataSetMainForm.finalmarks);
                cworkmarksBindingSource.Filter = "cmk_crdcode = " + dgCards[0, dgCards.CurrentRow.Index].Value.ToString();
                this.cworkmarksTableAdapter.Fill(this.dataSetMainForm.cworkmarks);
                semestermarksBindingSource.Filter = "smk_crdcode = " + dgCards[0, dgCards.CurrentRow.Index].Value.ToString();
                this.semestermarksTableAdapter.Fill(this.dataSetMainForm.semestermarks);
                semestermissingsBindingSource.Filter = "smm_crdcode = " + dgCards[0, dgCards.CurrentRow.Index].Value.ToString();
                this.semestermissingsTableAdapter.Fill(this.dataSetMainForm.semestermissings);
                this.practicnamesTableAdapter.Fill(this.dataSetMainForm.practicnames);
                this.practictypesTableAdapter.Fill(this.dataSetMainForm.practictypes);
                practicmarksBindingSource.Filter = "pmk_crdcode = " + dgCards[0, dgCards.CurrentRow.Index].Value.ToString();
                this.practicmarksTableAdapter.Fill(this.dataSetMainForm.practicmarks);
            }
            else
            {
                finalmarksBindingSource.Filter = "fmk_crdcode = 0";
                cworkmarksBindingSource.Filter = "cmk_crdcode = 0";
                semestermarksBindingSource.Filter = "smk_crdcode = 0";
                semestermissingsBindingSource.Filter = "smm_crdcode = 0";
                practicmarksBindingSource.Filter = "pmk_crdcode = 0";
            }
        }

        private void AddCard()
        {
            Buffer.State = "add";
            Buffer.MFPersonBuffer = Convert.ToInt32(dgPerson[0, dgPerson.CurrentRow.Index].Value.ToString());
            FPersCards frmPersCardsAdd = new FPersCards();
            frmPersCardsAdd.ShowDialog();
            Reload();
        }

        public void AddPerson()
        {
            Buffer.State = "add";
            FPersonAdd frmPersonAdd = new FPersonAdd();
            frmPersonAdd.ShowDialog();
            Reload();
        }


        public void Reload()
        {
            this.personsTableAdapter.Fill(this.dataSetMainForm.persons);
            this.cardsTableAdapter.Fill(this.dataSetMainForm.cards);
            this.subjectnamesTableAdapter.Fill(this.dataSetMainForm.subjectnames);
            this.cardsTableAdapter.Fill(this.dataSetMainForm.cards);
            this.specialitiesTableAdapter.Fill(this.dataSetMainForm.specialities);
            lbRowCount.Text = "Количество карточек: " + dgCards.RowCount;
            lbPersRowCount.Text = "Количество записей: " + dgPerson.RowCount;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.accountsTableAdapter.Fill(this.dataSetMainForm.accounts);
            Visible = false;
            FAutorisation frmAutoris = new FAutorisation();
            frmAutoris.ShowDialog();
            if (frmAutoris.LoginState == false)
            {
                Close();
            }
            if (frmAutoris.Username == "admin")
            {
                сервисToolStripMenuItem.Visible = true;
            }
            else
            {
                сервисToolStripMenuItem.Visible = false;
            }
            Text = Text + ": " + frmAutoris.Username;
            this.practictypesTableAdapter.Fill(this.dataSetMainForm.practictypes);
            this.practicnamesTableAdapter.Fill(this.dataSetMainForm.practicnames);
            this.practicmarksTableAdapter.Fill(this.dataSetMainForm.practicmarks);
            this.semestermissingsTableAdapter.Fill(this.dataSetMainForm.semestermissings);
            this.semestermarksTableAdapter.Fill(this.dataSetMainForm.semestermarks);
            Reload();
            lbRowCount.Text = "Количество записей: " + dgCards.RowCount;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.personsBindingSource.Filter = "psn_fname LIKE '%" + tbFindFname.Text + "%'";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void специальностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSpec frmSpec = new FSpec();
            frmSpec.ShowDialog();
            Reload();
        }

        private void dgPerson_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void аккаунтыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAccounts frmAcc = new FAccounts();
            frmAcc.ShowDialog();
            Reload();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FGroupsEdit frmGroups = new FGroupsEdit();
            frmGroups.ShowDialog();
            Reload();
        }

        private void типыОценокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMarktypesEdit frmMkTypes = new FMarktypesEdit();
            frmMkTypes.ShowDialog();
            Reload();
        }

        private void школыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void предметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSubjectNamesEdit frmSubjectNames = new FSubjectNamesEdit();
            frmSubjectNames.ShowDialog();
            Reload();
        }

        private void dgPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbRowCount.Text = "Количество записей: " + dgCards.RowCount;
            ReloadAllOfCards();
        }

        private void btPersDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить запись " +
                dgPerson[1, dgPerson.CurrentRow.Index].Value.ToString() + " " +
                dgPerson[2, dgPerson.CurrentRow.Index].Value.ToString() + " " +
                dgPerson[3, dgPerson.CurrentRow.Index].Value.ToString() + "?", "Удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    dgPerson.Rows.RemoveAt(dgPerson.CurrentCell.RowIndex);
                    personsTableAdapter.Update(this.dataSetMainForm);
                }
                catch
                {
                    MessageBox.Show("В таблице Личные карточки есть ссылки на этого человека!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Reload();
                    dgPerson.Focus();
                }
            }
            else
            {
                Reload();
                dgPerson.Focus();
            }

        }

        private void dgCards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReloadAllOfCards();
        }

        private void btPersEdit_Click(object sender, EventArgs e)
        {

        }

        private void dgPerson_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Buffer.State = "view";
            Buffer.MFPersonBuffer = Convert.ToInt32(dgPerson[0, dgPerson.CurrentRow.Index].Value.ToString());
            FPersonAdd frmPersView = new FPersonAdd();
            frmPersView.ShowDialog();
            Reload();
        }

        private void btCardDel_Click(object sender, EventArgs e)
        {
            try
            {
                dgCards.Rows.RemoveAt(dgCards.CurrentCell.RowIndex);
                cardsTableAdapter.Update(this.dataSetMainForm);
            }
            catch
            {
                MessageBox.Show("Выберите Личную карточку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btFinalmarkDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить оценку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dgFinalmarks.Rows.RemoveAt(dgFinalmarks.CurrentCell.RowIndex);
                finalmarksTableAdapter.Update(this.dataSetMainForm);
            }
            else dgFinalmarks.Focus();
        }

        private void btCardEdit_Click(object sender, EventArgs e)
        {
            try
            {
            Buffer.State = "edit";
            Buffer.MFCardsBuffer = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
            FPersCards frmCards = new FPersCards();
            frmCards.ShowDialog();
            Reload();
            }
            catch
            {
                MessageBox.Show("Выберите Личную карточку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgCards_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Buffer.State = "view";
            Buffer.MFCardsBuffer = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
            FPersCards frmCards = new FPersCards();
            frmCards.ShowDialog();
            Reload();
        }

        private void btFinalmarkAdd_Click(object sender, EventArgs e)
        {
            try
            {
            Buffer.State = "add";
            FFinalmarksAdd frmFinalmarks = new FFinalmarksAdd(Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString()));
            frmFinalmarks.ShowDialog();
            ReloadAllOfCards();
            }
            catch
            {
                MessageBox.Show("Выберите Личную карточку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPersAdd_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void btCardAdd_Click(object sender, EventArgs e)
        {
            AddCard();
        }

        private void btFinalmarkEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Buffer.State = "edit";
                int CardID = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
                string SubjectName = dgFinalmarks[2, dgFinalmarks.CurrentRow.Index].Value.ToString();
                int Ahours = Convert.ToInt32(dgFinalmarks[3, dgFinalmarks.CurrentRow.Index].Value.ToString());
                int Mhours = Convert.ToInt32(dgFinalmarks[4, dgFinalmarks.CurrentRow.Index].Value.ToString());
                int Mark = Convert.ToInt32(dgFinalmarks[5, dgFinalmarks.CurrentRow.Index].Value.ToString());
                int FinalmarksID = Convert.ToInt32(dgFinalmarks[0, dgFinalmarks.CurrentRow.Index].Value.ToString());
                FFinalmarksAdd frmFinalmarks = new FFinalmarksAdd(CardID, SubjectName, FinalmarksID, Ahours, Mhours, Mark);
                frmFinalmarks.ShowDialog();
                ReloadAllOfCards();
            }
            catch
            {
                MessageBox.Show("Выберите Оценку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgFinalmarks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Buffer.State = "edit";
                int CardID = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
                string SubjectName = dgFinalmarks[2, dgFinalmarks.CurrentRow.Index].Value.ToString();
                int Ahours = Convert.ToInt32(dgFinalmarks[3, dgFinalmarks.CurrentRow.Index].Value.ToString());
                int Mhours = Convert.ToInt32(dgFinalmarks[4, dgFinalmarks.CurrentRow.Index].Value.ToString());
                int Mark = Convert.ToInt32(dgFinalmarks[5, dgFinalmarks.CurrentRow.Index].Value.ToString());
                int FinalmarksID = Convert.ToInt32(dgFinalmarks[0, dgFinalmarks.CurrentRow.Index].Value.ToString());
                FFinalmarksAdd frmFinalmarks = new FFinalmarksAdd(CardID, SubjectName, FinalmarksID, Ahours, Mhours, Mark);
                frmFinalmarks.ShowDialog();
                ReloadAllOfCards();
            }
            catch
            {
                MessageBox.Show("Выберите Оценку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCworkmarkAdd_Click(object sender, EventArgs e)
        {
            try
            {
            Buffer.State = "add";
            int CardID = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
            FCworkmarks frmCworkmarks = new FCworkmarks(CardID);
            frmCworkmarks.ShowDialog();
            ReloadAllOfCards();
            }
            catch
            {
                MessageBox.Show("Выберите Личную карточку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgCworkmarks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Buffer.State = "edit";
                int CardID = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
                string SubjectName = dgCworkmarks[2, dgCworkmarks.CurrentRow.Index].Value.ToString();
                int CworkmarksID = Convert.ToInt32(dgCworkmarks[0, dgCworkmarks.CurrentRow.Index].Value.ToString());
                string Theme = dgCworkmarks[3, dgCworkmarks.CurrentRow.Index].Value.ToString();
                int Mark = Convert.ToInt32(dgCworkmarks[4, dgCworkmarks.CurrentRow.Index].Value.ToString());
                FCworkmarks frmCworkmarks = new FCworkmarks(CardID, CworkmarksID, SubjectName, Theme, Mark);
                frmCworkmarks.ShowDialog();
                ReloadAllOfCards();
            }
            catch
            {
                MessageBox.Show("Выберите Курсовую работу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCworkmarksEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Buffer.State = "edit";
                int CardID = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
                string SubjectName = dgCworkmarks[2, dgCworkmarks.CurrentRow.Index].Value.ToString();
                int CworkmarksID = Convert.ToInt32(dgCworkmarks[0, dgCworkmarks.CurrentRow.Index].Value.ToString());
                string Theme = dgCworkmarks[3, dgCworkmarks.CurrentRow.Index].Value.ToString();
                int Mark = Convert.ToInt32(dgCworkmarks[4, dgCworkmarks.CurrentRow.Index].Value.ToString());
                FCworkmarks frmCworkmarks = new FCworkmarks(CardID, CworkmarksID, SubjectName, Theme, Mark);
                frmCworkmarks.ShowDialog();
                ReloadAllOfCards();
            }
            catch
            {
                MessageBox.Show("Выберите Курсовую работу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCworkmarksDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить оценку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dgCworkmarks.Rows.RemoveAt(dgCworkmarks.CurrentCell.RowIndex);
                cworkmarksTableAdapter.Update(this.dataSetMainForm);
            }
            else dgCworkmarks.Focus();
        }



        private void личнаяКарточкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //==========================================Лажа==========================================
            try 
            {
                PdfDocument inputDocument = PdfReader.Open("templateperscard.pdf", PdfDocumentOpenMode.Import);
                PdfPage notEditablePage = inputDocument.Pages[0];
                PdfDocument outputDocument = new PdfDocument();
                PdfPage editablePage = outputDocument.AddPage(notEditablePage);

                XPdfFontOptions fontOptions = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);
                XFont font = new XFont("Times New Roman", 14, XFontStyle.Regular, fontOptions);

                XGraphics gfx = XGraphics.FromPdfPage(editablePage);
                
                outputDocument.Save("newPdf.pdf");

                MessageBox.Show("Файл успешно сформирован и сохранен в " + Environment.CurrentDirectory.ToString(), "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка создания PDF файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //==========================================/Лажа==========================================
        }

        private void btSemMarksAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Buffer.State = "add";
                int CardID = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
                FSemesterMarks frmSemMarks = new FSemesterMarks(CardID);
                frmSemMarks.ShowDialog();
                ReloadAllOfCards();
            }
            catch
            {
                MessageBox.Show("Выберите Личную карточку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSemMarksEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Buffer.State = "edit";
                int CardID = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
                int SemMarkID = Convert.ToInt32(dgSemMarks[0, dgSemMarks.CurrentRow.Index].Value.ToString());
                string SubjectName = dgSemMarks[2, dgSemMarks.CurrentRow.Index].Value.ToString();
                int Semester = Convert.ToInt32(dgSemMarks[3, dgSemMarks.CurrentRow.Index].Value.ToString());
                int Ahours = Convert.ToInt32(dgSemMarks[4, dgSemMarks.CurrentRow.Index].Value.ToString());
                int Shours = Convert.ToInt32(dgSemMarks[5, dgSemMarks.CurrentRow.Index].Value.ToString());
                int Mark = Convert.ToInt32(dgSemMarks[6, dgSemMarks.CurrentRow.Index].Value.ToString());
                string MarkType = dgSemMarks[7, dgSemMarks.CurrentRow.Index].Value.ToString();
                FSemesterMarks frmSemMarks = new FSemesterMarks(CardID, SemMarkID, Semester, Mark, Ahours, Shours, MarkType, SubjectName);
                frmSemMarks.ShowDialog();
                ReloadAllOfCards();
            }
            catch
            {
                MessageBox.Show("Выберите Оценку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSemMarksDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить оценку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dgSemMarks.Rows.RemoveAt(dgSemMarks.CurrentCell.RowIndex);
                semestermarksTableAdapter.Update(this.dataSetMainForm);
            }
            else dgSemMarks.Focus();
        }

        private void btSemMissAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Buffer.State = "add";
                int CardID = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
                FSemesterMissings frmSemMiss = new FSemesterMissings(CardID);
                frmSemMiss.ShowDialog();
                ReloadAllOfCards();
            }
            catch
            {
                MessageBox.Show("Выберите Личную карточку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSemMissEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Buffer.State = "edit";
                int CardID = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
                int SemMissID = Convert.ToInt32(dgSemMiss[0, dgSemMiss.CurrentRow.Index].Value.ToString());
                int Sem = Convert.ToInt32(dgSemMiss[2, dgSemMiss.CurrentRow.Index].Value.ToString());
                int Lmiss = Convert.ToInt32(dgSemMiss[3, dgSemMiss.CurrentRow.Index].Value.ToString());
                int Imiss = Convert.ToInt32(dgSemMiss[4, dgSemMiss.CurrentRow.Index].Value.ToString());
                FSemesterMissings frmSemMiss = new FSemesterMissings(SemMissID, CardID, Sem, Lmiss, Imiss);
                frmSemMiss.ShowDialog();
                ReloadAllOfCards();
            }
            catch
            {
                MessageBox.Show("Выберите редактируемую строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSemMissDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить строку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dgSemMiss.Rows.RemoveAt(dgSemMiss.CurrentCell.RowIndex);
                semestermissingsTableAdapter.Update(this.dataSetMainForm);
            }
            else dgSemMiss.Focus();
        }

        private void btPracticAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Buffer.State = "add";
                int CardID = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
                FPractic frmPractic = new FPractic(CardID);
                frmPractic.ShowDialog();
                ReloadAllOfCards();
            }
            catch
            {
                MessageBox.Show("Выберите Личную карточку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void практикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPractNames frmPracNames = new FPractNames();
            frmPracNames.ShowDialog();
            Reload();
        }

        private void btPracticEdit_Click(object sender, EventArgs e)
        {
           try
            {
                Buffer.State = "edit";
                int CardID = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
                int PractID = Convert.ToInt32(dgPractic[0, dgPractic.CurrentRow.Index].Value.ToString());
                int Sem = Convert.ToInt32(dgPractic[2, dgPractic.CurrentRow.Index].Value.ToString());
                int type = Convert.ToInt32(dgPractic[3, dgPractic.CurrentRow.Index].Value.ToString());
                decimal length = Convert.ToDecimal(dgPractic[5, dgPractic.CurrentRow.Index].Value.ToString());
                int mark = Convert.ToInt32(dgPractic[6, dgPractic.CurrentRow.Index].Value.ToString());
                int name = Convert.ToInt32(dgPractic[4, dgPractic.CurrentRow.Index].Value.ToString());
                FPractic frmPractic = new FPractic(CardID, PractID, Sem, type, length, mark, name);
                frmPractic.ShowDialog();
                ReloadAllOfCards();
            }
            catch
            {
                MessageBox.Show("Выберите редактируемую строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPracticDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить строку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dgPractic.Rows.RemoveAt(dgPractic.CurrentCell.RowIndex);
                practicmarksTableAdapter.Update(this.dataSetMainForm);
            }
            else dgPractic.Focus();
        }

        private void cbFindMain_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void дипломToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int person = Convert.ToInt32(dgPerson[0, dgPerson.CurrentRow.Index].Value.ToString());
            int card = Convert.ToInt32(dgCards[0, dgCards.CurrentRow.Index].Value.ToString());
            FPrint frmPrint = new FPrint(person, card);
            frmPrint.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
