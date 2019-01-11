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
    public partial class FPracticnamesEdit : Form
    {
        public FPracticnamesEdit()
        {
            InitializeComponent();
        }

        private void practicnamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.practicnamesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetMainForm);

        }

        private void FPracticnamesEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetMainForm.practicnames". При необходимости она может быть перемещена или удалена.
            this.practicnamesTableAdapter.Fill(this.dataSetMainForm.practicnames);

        }
    }
}
