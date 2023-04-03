using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http;
using SistemaGerenciadorLivraria.Components;

namespace SistemaGerenciadorLivraria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLock_MouseDown(object sender, MouseEventArgs e)
        {

            if (inputPassword.UseSystemPasswordChar)
            {
                inputPassword.UseSystemPasswordChar = false;
            }
            else
            {
                inputPassword.UseSystemPasswordChar = true;
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (inputUsername.Text == "" || inputPassword.Text == "")
            {
                MessageBox.Show("Username and password required to login", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputPassword.Clear();
                inputPassword.Focus();
            }
            else
            {
                DBController database = new DBController();
                if (database.checkLogin(inputUsername.Text, inputPassword.Text))
                {
                    FrmMenu menu = new FrmMenu();
                    menu.Show();
                }
            }

        }
    }
}
