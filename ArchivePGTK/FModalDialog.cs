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
    public partial class FModalDialog : Form
    {

        public FModalDialog(string textHead, string textLb, bool visibleCancelButton)
        {
            InitializeComponent();
            this.Text = textHead;
            lbText.Text = textLb;
            btCancel.Visible = visibleCancelButton;

        }

        private void FModalDialog_Load(object sender, EventArgs e)
        {

        }

        
    }
}
