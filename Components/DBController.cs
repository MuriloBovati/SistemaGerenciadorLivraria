using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                readerDB = quaryExecution(quary);
                if (readerDB.HasRows)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Username or password Invalid, Please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Database connection failed, contact system support", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Quary connection fail");
                Console.WriteLine(e.Message);
                conn.Close();
            }

            finally { conn.Close(); }

            return false;

        }

        public void saveNewEmployee(string name, string login, string password)
        {
            string quary = "INSERT INTO tbl_Atendente(ds_Login, ds_Senha, nm_Atendente) VALUES('"+login+"','"+password+"','"+name+"');";
            quaryExecution(quary);
        }

        private SqlDataReader quaryExecution(string quary)
        {
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.CommandText = quary;
                command.Connection = conn;
                readerDB = command.ExecuteReader();
                return readerDB;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return readerDB;
        }
    }
}
