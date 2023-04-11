using Microsoft.Win32.SafeHandles;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGerenciadorLivraria.Components
{
    internal class DBController
    {
        string stringConnection = @"Data Source=DESKTOP-9GCFA48\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_Livraria";
        SqlConnection conn;
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
                readerDB = commandExecutionReturn(quary);
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
                MessageBox.Show("Database connection failed, contact system support", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Quary connection fail, checkLogin()");
                Console.WriteLine(e.Message);
            }

            finally { conn.Close(); }

            return false;

        }

        /// <summary>Salva do dados informados no banco de dados.</summary>
        public void create(string table, string name, string login, string password)
        {
            string quary = "INSERT INTO tbl_Atendente(ds_Login, ds_Senha, nm_Atendente) VALUES ('" + login + "','" + password + "','" + name + "');";
            commandExecution(quary);
        }

        /// <summary>Executa uma pesquisa no banco de dados retornando um DataTable.</summary>
        /// <returns>DataTable.</returns>
        public DataTable searchTable(string table, string search)
        {
            string commandSQL = "SELECT * FROM " + table + " WHERE nm_Atendente like ('%" + search + "%')";
            return createTableSQL(commandSQL);
        }

        /// <summary>
        /// Deleta o usuario apartir do valor de sua chave do banco de dados
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Null</returns>
        public void delete(string table,  string id)
        {
            string qy = "DELETE FROM " + table+ " WHERE cd_Atendente =('" + id + "')";
            commandExecution(qy);
        }

        /// <summary>
        /// Realiza a atualização dentro de uma tabela no banco de dados apartir dos aparametos recebidos.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="id_employer"></param>
        public void update(string tabela, string name, string login, string password, string id_employer)
        {
            string qy = "UPDATE " + tabela + " set ds_Login = ('" + login + "'), ds_Senha = ('" + password + "'), nm_Atendente = ('" + name + "') WHERE cd_Atendente = ('"+id_employer+"')";
            commandExecution(qy);
        }

        /// <summary>
        /// Executa uma pesquisa no banco de dados retornando um SqlDataReader.
        /// Deve ser executado o conn.close() ao final da operação
        /// </summary>
        /// <returns>SqlDataReader.</returns>
        private SqlDataReader commandExecutionReturn(string qy)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(qy, conn);
            try
            {
                return readerDB = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }

        /// <summary>Executa uma pesquisa no banco de dados sem retorno.</summary>
        private void commandExecution(string qy)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(qy, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>Realiza uma pesquisa no banco de dados retornando um DataTable pré configurado</summary>
        /// <returns>DataTable</returns>
        private DataTable createTableSQL(string qy)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(qy, conn);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = command;
                da.Fill(dt);
                return dt;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "ERROR DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }

            return null;
        }
    }
}
