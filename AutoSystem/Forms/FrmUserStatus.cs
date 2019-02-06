using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoSystem.Enums;
using AutoSystem.Classes;

namespace AutoSystem.Forms
{
    public partial class FrmUserStatus : Form
    {
        string getCbxStatus;

        public FrmUserStatus()
        {
            InitializeComponent();
            cbxUserStatus.DataSource = Enum.GetNames(typeof(UserStatus));
            cbxUserStatus.SelectedIndex = -1;
        }

        private void btnStatusSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxUserStatus.SelectedIndex != -1)
                {
                    getCbxStatus = cbxUserStatus.Text;
                    Global.GlobalUserStatus.Status = getCbxStatus;
                    this.Close();                    
                }               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
