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

        //internal static void ClearTextBoxe(Control.ControlCollection controls)
        //{
        //    throw new NotImplementedException();
        //}

        public static void ClearTextBoxes(Control controls)
        {
            foreach (Control ctl in controls.Controls)
            {
                if (ctl is TextBox)
                {
                    ((TextBox)ctl).Clear();
                }
            }
        }

        public static void ClearComboBoxes(Control controls)
        {
            foreach (Control ctl in controls.Controls)
            {
                if (ctl is ComboBox)
                {
                    ((ComboBox)ctl).SelectedIndex = -1;
                }
            }
        }

        public static void ClearMaskedBoxes(Control controls)
        {
            foreach  (Control ctl in controls.Controls)
            {
                if (ctl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctl).Clear();
                }
            }
        }

    }
}
