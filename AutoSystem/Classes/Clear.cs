using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSystem.Classes
{
     public static class Clear
    {
        public static void ClearUserRegForm(TextBox userNameField, TextBox userLastNameField, TextBox userLoginField, 
                                            TextBox userPasswordField, TextBox userDepartmentField, ComboBox userStatusField)
        {
            if (userNameField.Text != string.Empty || userLastNameField.Text != string.Empty 
                || userLoginField.Text != string.Empty || userPasswordField.Text != string.Empty 
                || userDepartmentField.Text != string.Empty || userStatusField.SelectedIndex != -1)
            {
               userNameField.Text = string.Empty;
               userLastNameField.Text = string.Empty;
               userLoginField.Text = string.Empty;
               userPasswordField.Text = string.Empty; 
               userDepartmentField.Text = string.Empty;
               userStatusField.SelectedIndex = -1;

               userNameField.Focus(); 
            }
        }



    }
}
