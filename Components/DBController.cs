using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGerenciadorLivraria.Components
{
    internal class DBController
    {
        string stringConnection = @"Data Source=DESKTOP-9GCFA48\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_Livraria";
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader readerDB;

        public DBController()
        {
            connect();
        }

        public void connect()
        {
            try
            {
                conn = new SqlConnection(stringConnection);
                Console.WriteLine("Connection Success");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Connection fail, connect()");
                Console.WriteLine(e.Message);
            }
        }

        public bool checkLogin(string Username, string Password) 
        {
            try
            {
                string quary = "SELECT * FROM tbl_atendente where ds_Login = ('" + Username + "') AND ds_Senha = ('" + Password + "')";
                command = new SqlCommand();
                command.CommandText = quary;
                command.Connection = conn;
                readerDB = command.ExecuteReader();
                if (readerDB.HasRows)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Connection to database fai, contact to support ", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Quary connection fail");
                Console.WriteLine(e.Message);
            }
            return false;

        }
    }
}
