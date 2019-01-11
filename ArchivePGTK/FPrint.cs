using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;


namespace ArchivePGTK
{
    public partial class FPrint : Form
    {
        Word._Application oWord;
        Word._Document oDoc;

        static int personID;
        static int cardID;



        private void rpbm(string FindString, string ReplaceString)
        {
            oWord.Selection.Find.ClearFormatting();
            oWord.Selection.Find.Replacement.Text = @ReplaceString;
            oWord.Selection.Find.Execute(@FindString, Replace: Word.WdReplace.wdReplaceAll);
        }
        
        public FPrint(int Person, int Card)
        {
            personID = Person;
            cardID = Card;
            InitializeComponent();
        }

        private void PrintDiplome()
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
            object oTemplate = @Application.StartupPath + @"\templatediplome.dot";

            string qual = dataSetMainForm.specialities.FindByspc_pcode(dataSetMainForm.cards.FindBycrd_pcode(cardID).crd_spccode).spc_kvalification;
            string regnum = dataSetMainForm.cards.FindBycrd_pcode(cardID).crd_dipregnum;
            string dateofissue = dataSetMainForm.cards.FindBycrd_pcode(cardID).crd_dipdate.ToLongDateString().ToString();
            string firstname = dataSetMainForm.persons.FindBypsn_pcode(personID).psn_fname;
            string lastname = dataSetMainForm.persons.FindBypsn_pcode(personID).psn_lname;
            string midname = dataSetMainForm.persons.FindBypsn_pcode(personID).psn_mname;
            string specialty = dataSetMainForm.specialities.FindByspc_pcode(dataSetMainForm.cards.FindBycrd_pcode(cardID).crd_spccode).spc_name;
            string dateofdecision = dtpGosEkCom.Value.ToLongDateString().ToString();
            string chair = tbChair.Text;
            string director = tbDirector.Text;

            oWord = new Word.Application();

            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);

            rpbm(@"@@Qualification", @qual);
            rpbm(@"@@Regnum", @regnum);
            rpbm(@"@@Dateofiss", @dateofissue);
            rpbm(@"@@Firstname", @firstname);
            rpbm(@"@@Lastname", @lastname);
            rpbm(@"@@Midname", @midname);
            rpbm(@"@@Specialty", @specialty);
            rpbm(@"@@Dateoforder", @dateofdecision);
            rpbm(@"@@Chair", @chair);
            rpbm(@"@@Chief", @director);
        }

        private void PrintDipSupplement()
        {
            
        }

        private void PrintPersonCard()
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDiplome();
        }

        private void FPrint_Load(object sender, EventArgs e)
        {
            this.subjectnamesTableAdapter.Fill(this.dataSetMainForm.subjectnames);
            this.specialitiesTableAdapter.Fill(this.dataSetMainForm.specialities);
            this.semestermissingsTableAdapter.Fill(this.dataSetMainForm.semestermissings);
            this.semestermarksTableAdapter.Fill(this.dataSetMainForm.semestermarks);
            this.schoolsTableAdapter.Fill(this.dataSetMainForm.schools);
            this.remandstatusTableAdapter.Fill(this.dataSetMainForm.remandstatus);
            this.practictypesTableAdapter.Fill(this.dataSetMainForm.practictypes);
            this.practicnamesTableAdapter.Fill(this.dataSetMainForm.practicnames);
            this.practicmarksTableAdapter.Fill(this.dataSetMainForm.practicmarks);
            this.personsTableAdapter.Fill(this.dataSetMainForm.persons);
            this.finalmarksTableAdapter.Fill(this.dataSetMainForm.finalmarks);
            this.cworkmarksTableAdapter.Fill(this.dataSetMainForm.cworkmarks);
            this.cardsTableAdapter.Fill(this.dataSetMainForm.cards);
        }

    }
}
