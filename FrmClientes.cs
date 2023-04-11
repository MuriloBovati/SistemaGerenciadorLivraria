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
    public partial class FrmClientes : UserControl
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
