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
        Funcionario funcionario = new Funcionario();

        public FrmFuncionario()
        {
            InitializeComponent();
            desableButton();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                MessageBox.Show("Cadastro de funcionario feito com sucesso","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                funcionario.createFuncionario(inputNome.Text, inputLogin.Text, inputPassword.Text);
                cleanFields();
                desableButton();
            }
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
            btnNew.Enabled = true;

        }

        private void cleanFields()
        {
            inputLogin.Text = "";
            inputNome.Text = "";
            inputPassword.Text = "";
            lblCode.Visible = false;
            lblCodeInfo.Visible = false;
            lblCodeInfo.Text = string.Empty;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                try
                {
                    dataGridSql.DataSource = funcionario.searchTableFuncionario(txtSearch.Text);
                }
                catch(Exception err) 
                {
                    MessageBox.Show(err.Message, "WARNIG",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }   
            }
            else
            {
                dataGridSql.DataSource=null;
            }
        }

        private void dataGridSql_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadEmployer();
        }

        private void loadEmployer()
        {
            lblCode.Visible = true;
            lblCodeInfo.Visible = true;
            lblCodeInfo.Text = dataGridSql.SelectedRows[0].Cells[0].Value.ToString();
            inputNome.Text = dataGridSql.SelectedRows[0].Cells[3].Value.ToString();
            inputLogin.Text = dataGridSql.SelectedRows[0].Cells[1].Value.ToString();
            inputPassword.Text = dataGridSql.SelectedRows[0].Cells[2].Value.ToString();
            btnExclude.Enabled = true;
            btnCancel.Enabled = true;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
            btnNew.Enabled = false;
            inputLogin.Enabled = true;
            inputPassword.Enabled = true;
            inputNome.Enabled = true;
        }

        private void btnExclude_Click(object sender, EventArgs e)
        {
            string response = MessageBox.Show("Deseja mesmo excluir esse funcionario da base de dados ?", "Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if(response == "OK")
            {
                funcionario.deleteFuncionario(lblCodeInfo.Text);
                desableButton();
                cleanFields();
                txtSearch.Text = string.Empty;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string response = MessageBox.Show("Deseja realizar as alteraçoes no funcionario ?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if(response == "OK")
            {
                funcionario.updateFuncionario(inputNome.Text, inputLogin.Text, inputPassword.Text, lblCodeInfo.Text);
                desableButton();
                cleanFields();
                txtSearch.Text = string.Empty;
            }
        }
    }
}
