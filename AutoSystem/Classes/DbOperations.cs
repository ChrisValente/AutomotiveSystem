using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace AutoSystem.Classes
{
    public class DbOperations
    {
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

                form.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha invalida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginField.Text = string.Empty;
                passwordField.Text = string.Empty;
                loginField.Focus();
            }
        }
    }
}
