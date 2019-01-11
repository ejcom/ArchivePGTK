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
    public partial class FSpec : Form
    {
        public FSpec()
        {
            InitializeComponent();
        }

        private void specialitiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specialitiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetMainForm);

        }

        private void FSpec_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetMainForm.specialities". При необходимости она может быть перемещена или удалена.
            this.specialitiesTableAdapter.Fill(this.dataSetMainForm.specialities);

        }

        private void FSpec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
