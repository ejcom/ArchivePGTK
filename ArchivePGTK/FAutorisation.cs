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
    public partial class FAutorisation : Form
    {
        public FAutorisation()
        {
            InitializeComponent();
        }

        bool outstate = false;
        string username;
        int role;

        private void Autentification(string login, string pass)
        {
            int logon = dataSetMainForm.accounts.Select("aco_login LIKE '" + login + "' AND aco_password LIKE '" + pass + "'").Count();
            if (logon == 1)
            {
                outstate = true;
                username = login;
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool LoginState
        {
            get { return outstate; }
        }

        public string Username
        {
            get { return username; }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            string passwd = AES.Encrypt(tbPass.Text, "pgtt", "ejikcom", "SHA1", 3, "zFRna73Om*ae01yY", 256);
            Autentification(tbLogin.Text, passwd);
        }

        private void FAutorisation_Load(object sender, EventArgs e)
        {
            this.accountsTableAdapter.Fill(this.dataSetMainForm.accounts);
        }
    }
}
