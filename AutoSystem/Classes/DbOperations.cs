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
        public static void LoginOperation(TextBox loginField, TextBox passwordField)
        {
            string login = loginField.Text;
            string password = passwordField.Text;
            string connectionString = @"Data Source=ceres-pc\sqlexpress;Initial Catalog=AutomotiveDb;Integrated Security=True";
            string selectLogin = $"SELECT LOGIN FROM TBUSER WHERE LOGIN = '{login}';;";
            string selectPassword = $"SELECT SENHA FROM TBUSER WHERE SENHA = '{password}'";
            string loginReturn, passwordReturn;

            SqlConnection connection = new SqlConnection(connectionString);            
            SqlCommand cmdSelectLogin = new SqlCommand(selectLogin,connection);
            SqlCommand cmdSelectPassword = new SqlCommand(selectPassword,connection);             

            connection.Open();
            SqlDataReader loginReader = cmdSelectLogin.ExecuteReader();
            //SqlDataReader passwordReader = cmdSelectPassword.ExecuteReader();
            if (loginReader.Read())
            {
                loginReturn = loginReader[0].ToString();
                MessageBox.Show("Funciona: " + loginReturn);
                
            }
            //todo: CAPTURAR O SELECT DO PASSWORD PARA FAZER A VALIDAÇÃO ANTES DE ABRIR O PRÓXIMO FORMULÁRIO
        }
    }
}
