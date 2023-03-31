using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            if(inputPassword.UseSystemPasswordChar)
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
            
        }
    }
}
