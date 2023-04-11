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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCloseMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            frmFuncionario1.Visible = true;
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                this.Visible = false;
                Login login = new Login();
                login.Show();
            }
        }
    }
}
