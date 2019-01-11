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
    public partial class FSubjectNamesEdit : Form
    {
        public FSubjectNamesEdit()
        {
            InitializeComponent();
        }

        private void subjectnamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectnamesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetMainForm);

        }

        private void FSubjectNamesEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetMainForm.subjectnames". При необходимости она может быть перемещена или удалена.
           // this.subjectnamesTableAdapter.Fill(this.dataSetMainForm.subjectnames);

        }
    }
}
