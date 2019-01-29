using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using AutoSystem.Forms;

namespace AutoSystem.Classes
{
    public class DbOperations
    {
        public string userNameField { get; set; }
        public string userLastNameField { get; set; }
        public string userLoginField { get; set; }
        public string userPasswordField { get; set; }
        public string userStatusField { get; set; }
        public string userFunctionField { get; set; }

        public static void LoginOperation(TextBox loginField, TextBox passwordField, Form form)
        {
            string login = loginField.Text;
            string password = passwordField.Text;
            string connectionString = @"Data Source=ceres-pc\sqlexpress;Initial Catalog=AutomotiveDb;Integrated Security=True";
            string selectLogin = $"SELECT LOGIN, SENHA FROM TBUSER WHERE LOGIN = '{login}' AND SENHA = '{password}';";
            string loginReturn, passwordReturn;

            SqlConnection connection = new SqlConnection(connectionString);            
            SqlCommand cmdSelectLogin = new SqlCommand(selectLogin,connection);
                        
            connection.Open();
            SqlDataReader loginReader = cmdSelectLogin.ExecuteReader();
            
            if (loginReader.Read())
            {
                loginReturn = loginReader[0].ToString();
                passwordReturn = loginReader[1].ToString();

                if (string.Equals(password,passwordReturn) == true )
                {
                    FrmInitial frmInitial = new FrmInitial();
                    frmInitial.Show();
                }
                else
                {
                    MessageBox.Show("Login ou senha invalida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginField.Text = string.Empty;
                    passwordField.Text = string.Empty;
                    loginField.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Login ou senha invalida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginField.Text = string.Empty;
                passwordField.Text = string.Empty;
                loginField.Focus();
            }
            
        }

        public static void InsertNewUser(string userNameField, string userLastNameField,
                               string userLoginField, string userPasswordField,  string userStatusField, string userFunctionField)
        {     

            string connectionString = @"Data Source=ceres-pc\sqlexpress;Initial Catalog=AutomotiveDb;Integrated Security=True";

            string insert = $"INSERT INTO TBUSER(NOME,SOBRENOME,LOGIN,SENHA,STATUS,FUNCAO) VALUES (@NOME,@SOBRENOME,@LOGIN,@SENHA,@STATUS,@FUNCAO)";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = new SqlCommand(insert, sqlConnection);

            sqlConnection.Open();

            sqlCommand.Parameters.AddWithValue("@NOME", userNameField);
            sqlCommand.Parameters.AddWithValue("@SOBRENOME", userLastNameField);
            sqlCommand.Parameters.AddWithValue("@LOGIN", userLoginField);
            sqlCommand.Parameters.AddWithValue("@SENHA", userPasswordField);
            sqlCommand.Parameters.AddWithValue("@STATUS", userStatusField);
            sqlCommand.Parameters.AddWithValue("@FUNCAO", userFunctionField);

            SqlTransaction sqlTransaction = null;

            try
            {
                sqlTransaction = sqlConnection.BeginTransaction();
                sqlCommand.Transaction = sqlTransaction;

                sqlCommand.ExecuteScalar();
                sqlTransaction.Commit();

                MessageBox.Show("Usuário criado com sucesso!", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (sqlTransaction != null)
                {
                    sqlTransaction.Rollback();
                }

                MessageBox.Show("Não foi possível completar a operação!", "Erro ao salvar dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }               
            }
        }

        public static void GetUsersData(DataGridView dataGrid)
        {
            string connectionString = @"Data Source=ceres-pc\sqlexpress;Initial Catalog=AutomotiveDb;Integrated Security=True";
            string selectData = "SELECT NOME, SOBRENOME, FUNCAO AS 'DEPARTAMENTO', LOGIN, STATUS FROM TBUSER";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();


            sqlConnection.Open();

            SqlCommand cmdSelect = new SqlCommand(selectData, sqlConnection);
            cmdSelect.ExecuteNonQuery();

            adapter.SelectCommand = cmdSelect;
            adapter.Fill(dataSet);
            dataGrid.DataSource = dataSet;
            dataGrid.DataMember = dataSet.Tables[0].TableName;

            if (sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
        }

        public static void DeleteUserSystem()
        {
            //todo: criar um delete para o usuário selecionado
        }
    }
}
