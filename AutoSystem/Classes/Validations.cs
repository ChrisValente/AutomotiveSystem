using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSystem
{
    static class Validations
    {
        public static bool EmptyFieldValidation (TextBox userNameField,TextBox userLastNameField,TextBox userLoginField, 
                                                 TextBox userPasswordField, ComboBox userStatusField, TextBox userDepartmentField)
        {
            if (userNameField.Text == string.Empty || userLastNameField.Text == string.Empty 
                || userLoginField.Text == string.Empty || userPasswordField.Text == string.Empty 
                || userStatusField.Text == string.Empty || userDepartmentField.Text == string.Empty)
            {
               string x = Convert.ToString( MessageBox.Show("É necessário preencher todos os campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));
               userNameField.Focus();
               return false;
            }
            else
            {
               return true;
            }
        }


        public static void EmptyTextBoxes(Control controls)
        {
            foreach (Control ctl in controls.Controls)
            {
                if (ctl is TextBox)
                {
                    if (((TextBox)ctl).Text == string.Empty)
                    {
                        MessageBox.Show("Todos os campos são de preenchimento obrigatório!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break; ;
                    }    
                                   
                }
            }
        }

        public static void EmptyComboBoxes(Control controls)
        {
            foreach (Control ctl in controls.Controls)
            {
                if (ctl is ComboBox)
                {
                    if (((ComboBox)ctl).SelectedIndex == -1)
                    {
                        MessageBox.Show("Todos os campos são de preenchimento obrigatório!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                }
            }
        }




        
    }
}
