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
            string selectLogin = $"SELECT LOGIN, SENHA, STATUS FROM TBUSER WHERE LOGIN = '{login}' AND SENHA = '{password}';";
            string loginReturn, passwordReturn, statusReturn;
            string statusActive = "Ativo";
            string statusAdmin = "Admin";
            string statusMaster = "Master";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmdSelectLogin = new SqlCommand(selectLogin, connection);

            connection.Open();
            SqlDataReader loginReader = cmdSelectLogin.ExecuteReader();

            if (loginReader.Read())
            {
                loginReturn = loginReader[0].ToString();
                passwordReturn = loginReader[1].ToString();
                statusReturn = loginReader[2].ToString();

                if (string.Equals(password, passwordReturn) == true)
                {
                    if (string.Equals(statusActive, statusReturn) == true || string.Equals(statusAdmin, statusReturn) == true
                        || string.Equals(statusMaster, statusReturn) == true)
                    {
                        FrmInitial frmInitial = new FrmInitial();
                        frmInitial.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário inativo", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Login ou senha invalida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginField.Text = string.Empty;
                passwordField.Text = string.Empty;
                loginField.Focus();
            }

        }

        public static void InsertNewUser(string userNameField, string userLastNameField,
                               string userLoginField, string userPasswordField, string userStatusField, string userFunctionField)
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

        public static void DeleteUserSystem(DataGridView grid)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Deseja realmente excluir este usuário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string connectionString = @"Data Source=ceres-pc\sqlexpress;Initial Catalog=AutomotiveDb;Integrated Security=True";

                string getName = grid.CurrentRow.Cells["NOME"].Value.ToString();
                string getLastName = grid.CurrentRow.Cells["SOBRENOME"].Value.ToString();
                string getLogin = grid.CurrentRow.Cells["LOGIN"].Value.ToString();
                string selectPK = $"SELECT IDUSER FROM TBUSER WHERE NOME = '{getName}' AND SOBRENOME = '{getLastName}' AND LOGIN = '{getLogin}'";
                int pk;

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmdSelectPk = new SqlCommand(selectPK, connection);
                connection.Open();

                pk = Convert.ToInt32(cmdSelectPk.ExecuteScalar());


                string deleteUser = $"DELETE FROM TBUSER WHERE IDUSER = '{pk}'";
                SqlCommand cmdDeleteUser = new SqlCommand(deleteUser, connection);
                SqlTransaction transaction = null;


                try
                {
                    transaction = connection.BeginTransaction();
                    cmdDeleteUser.Transaction = transaction;
                    cmdDeleteUser.ExecuteScalar();
                    transaction.Commit();
                    MessageBox.Show("Usuário deletado com sucesso!", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    MessageBox.Show("Não foi possível completar a operação!", "Erro ao deletar dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception(ex.Message);

                }
                finally
                {
                    GetUsersData(grid);
                    if (connection.State != ConnectionState.Closed) { connection.Close(); }
                }
            }

        }

        public static void UpdateUserStatus(DataGridView grid, string status)
        {
            string connectionString = @"Data Source=ceres-pc\sqlexpress;Initial Catalog=AutomotiveDb;Integrated Security=True";

            string getName = grid.CurrentRow.Cells["NOME"].Value.ToString();
            string getLastName = grid.CurrentRow.Cells["SOBRENOME"].Value.ToString();
            string getLogin = grid.CurrentRow.Cells["LOGIN"].Value.ToString();

            string selectPk = $"SELECT IDUSER FROM TBUSER WHERE NOME = '{getName}' AND SOBRENOME = '{getLastName}' AND LOGIN = '{getLogin}'";
            int pk;

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmdSelectPk = new SqlCommand(selectPk, sqlConnection);
            sqlConnection.Open();

            pk = Convert.ToInt32(cmdSelectPk.ExecuteScalar());

            string updateTable = $"UPDATE TBUSER SET STATUS = '{status}' WHERE IDUSER = '{pk}'";
            SqlCommand cmdUpdate = new SqlCommand(updateTable, sqlConnection);
            SqlTransaction transaction = null;

            try
            {
                transaction = sqlConnection.BeginTransaction();
                cmdUpdate.Transaction = transaction;
                cmdUpdate.ExecuteScalar();
                transaction.Commit();
                MessageBox.Show("Status atualizado com sucesso!", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("Não foi possível completar a operação!", "Erro ao atualizar dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);
            }
            finally
            {
                GetUsersData(grid);
                if (sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
            }


        }

        public static void InsertNewVehicle(string type, string brand, string model, string version)
        {
            string connectionString = @"Data Source=ceres-pc\sqlexpress;Initial Catalog=AutomotiveDb;Integrated Security=True";
            string insertVehicle = "INSERT INTO VEICULOSDB (TIPO, MARCA, MODELO, VERSAO) VALUES(@TIPO, @MARCA, @MODELO, @VERSAO);";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmdInsert = new SqlCommand(insertVehicle, sqlConnection);
            sqlConnection.Open();

            cmdInsert.Parameters.AddWithValue("@TIPO", type);
            cmdInsert.Parameters.AddWithValue("@MARCA", brand);
            cmdInsert.Parameters.AddWithValue("@MODELO", model);
            cmdInsert.Parameters.AddWithValue("@VERSAO", version);

            SqlTransaction transaction = null;

            try
            {
                transaction = sqlConnection.BeginTransaction();
                cmdInsert.Transaction = transaction;

                cmdInsert.ExecuteScalar();
                transaction.Commit();
                MessageBox.Show("Veículo inserido com sucesso!", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("Não foi possível completar a operação!", "Erro ao salvar dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
            }

        }

        public static void GetVehicleData(DataGridView grid, string type)
        {
            string connectionString = @"Data Source=ceres-pc\sqlexpress;Initial Catalog=AutomotiveDb;Integrated Security=True";
            string selectData = $"SELECT MARCA, MODELO, VERSAO FROM VEICULOSDB WHERE TIPO = '{type}';";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmdSelect = new SqlCommand(selectData, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect);
            DataSet dataSet = new DataSet();

            connection.Open();

            cmdSelect.ExecuteNonQuery();
            adapter.SelectCommand = cmdSelect;
            adapter.Fill(dataSet);

            grid.DataSource = dataSet;
            grid.DataMember = dataSet.Tables[0].TableName;

            if (connection.State != ConnectionState.Closed) { connection.Close(); }
        }

        public static void DeleteVehicle(DataGridView grid)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Deseja realmente deletar este veículo?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connectionString = @"Data Source=ceres-pc\sqlexpress;Initial Catalog=AutomotiveDb;Integrated Security=True";

                string brand = grid.CurrentRow.Cells["MARCA"].Value.ToString();
                string model = grid.CurrentRow.Cells["MODELO"].Value.ToString();
                string version = grid.CurrentRow.Cells["VERSAO"].Value.ToString();
                string selectPk = $"SELECT IDVEIDB FROM VEICULOSDB WHERE MARCA = '{brand}'AND MODELO = '{model}' AND VERSAO = '{version}';";
                int pk;

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmdSelectPk = new SqlCommand(selectPk, connection);
                SqlTransaction transaction = null;

                connection.Open();

                pk = Convert.ToInt32(cmdSelectPk.ExecuteScalar());
                string deleteVehicle = $"DELETE FROM VEICULOSDB WHERE IDVEIDB = '{pk}';";
                SqlCommand cmdDeleteVehicle = new SqlCommand(deleteVehicle, connection);

                try
                {
                    transaction = connection.BeginTransaction();
                    cmdDeleteVehicle.Transaction = transaction;
                    cmdDeleteVehicle.ExecuteScalar();
                    transaction.Commit();
                    MessageBox.Show("Usuário deletado com sucesso!", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Não foi possível completar a operação!", "Erro ao deletar dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    throw new Exception(ex.Message);
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed) { connection.Close(); }
                }
            }

        }

    }
}
