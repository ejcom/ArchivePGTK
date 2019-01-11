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
    public partial class FPractNames : Form
    {
        public FPractNames()
        {
            InitializeComponent();
        }

        private void practicnamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.practicnamesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetMainForm);
                FPractNames.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FPractNames_Load(object sender, EventArgs e)
        {
            this.practicnamesTableAdapter.Fill(this.dataSetMainForm.practicnames);
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.practicnamesBindingSource.Filter = "pnm_name LIKE '%" + tbFind.Text + "%'";
            }
            catch
            { 
                MessageBox.Show("Ошибка поиска. Присутствуют недопустимые символы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
