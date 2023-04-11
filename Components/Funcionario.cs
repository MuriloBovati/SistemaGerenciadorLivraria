using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorLivraria.Components
{
    internal class Funcionario
    {
        DBController dbController = new DBController();

        string tblFuncionario = "tbl_Atendente";

        public Funcionario() { }

        public void createFuncionario(string name, string login, string password)
        {
            dbController.create(this.tblFuncionario, name, login, password);
        }
        public void readFuncionario() 
        {
        
        }

        public DataTable searchTableFuncionario(string search) 
        {
            return dbController.searchTable(this.tblFuncionario, search);
        }

        public void updateFuncionario(string name, string login,string password, string id_employer) 
        {
            dbController.update(this.tblFuncionario,name ,login ,password ,id_employer);
        }

        public void deleteFuncionario(string id_employer) 
        {
            dbController.delete(this.tblFuncionario, id_employer);
        }
    }
}
