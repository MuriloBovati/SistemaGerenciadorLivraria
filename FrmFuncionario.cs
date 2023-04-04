using SistemaGerenciadorLivraria.Components;
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
    public partial class FrmFuncionario : UserControl
    {
        public FrmFuncionario()
        {
            InitializeComponent();
            desableButton();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void desableButton()
        {
            btnCancel.Enabled = false;
            btnExclude.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            inputLogin.Enabled = false;
            inputPassword.Enabled = false;
            inputNome.Enabled = false;

        }

        private void enableButton()
        {

        }

        private void cleanFields()
        {
            inputLogin.Text = "";
            inputNome.Text = "";
            inputPassword.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled=true;
            btnSave.Enabled=true;
            inputLogin.Enabled=true;
            inputNome.Enabled=true;
            inputPassword.Enabled=true;
            cleanFields();
            btnNew.Enabled=false;
            inputLogin.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desableButton();
            cleanFields();
            btnNew.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (inputLogin.Text == "" || inputNome.Text == "" || inputPassword.Text == "")
            {
                //MessageBox.Show("Filds Nome, Senha ou Usuario must be filled", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                MessageBox.Show("Campos Nome, Senha ou Usuario devem ser preenchidos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DBController DBlivraria = new DBController();
                DBlivraria.saveNewEmployee(inputNome.Text, inputLogin.Text, inputPassword.Text);
                cleanFields();
                desableButton();
            }
        }
    }
}
