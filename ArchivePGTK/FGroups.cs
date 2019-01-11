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
    public partial class FGroupsEdit : Form
    {
        public FGroupsEdit()
        {
            InitializeComponent();
        }

        private void groupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetMainForm);

        }

        private void FGroupsEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetMainForm.groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.dataSetMainForm.groups);

        }
    }
}
