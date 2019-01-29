using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoSystem.Classes;
using System.Globalization;
using System.Threading;
using AutoSystem.Enums;

namespace AutoSystem.Forms
{
    public partial class FrmUserReg : Form
    {
        public FrmUserReg()
        {
            InitializeComponent();
            cbxUserStatus.DataSource = Enum.GetNames(typeof(UserStatus));
            cbxUserStatus.SelectedIndex = -1;
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool validation;

                validation = Validations.EmptyFieldValidation(tbxUserName, tbxUserLastName, tbxUserLogin, 
                                                              tbxUserPassword, cbxUserStatus, tbxUserDepartment);
                if (validation == true)
                {
                    CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                    TextInfo textInfo = cultureInfo.TextInfo;

                    string userName = textInfo.ToTitleCase(tbxUserName.Text);
                    string userLastname = textInfo.ToTitleCase(tbxUserLastName.Text);
                    string userLogin = tbxUserLogin.Text;
                    string userPassword = tbxUserPassword.Text;
                    string userFunction = tbxUserDepartment.Text;
                    string userStatus = cbxUserStatus.Text;

                    DbOperations.InsertNewUser(userName, userLastname, userLogin, userPassword, userStatus, userFunction);
                    Clear.ClearUserRegForm(tbxUserName, tbxUserLastName, tbxUserLogin, tbxUserPassword, tbxUserDepartment, cbxUserStatus);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnUserClearForm_Click(object sender, EventArgs e)
        {
            try
            {
                Clear.ClearUserRegForm(tbxUserName, tbxUserLastName, tbxUserLogin, tbxUserPassword, tbxUserDepartment, cbxUserStatus);          
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
