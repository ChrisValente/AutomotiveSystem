using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AutoSystem.Classes;
using AutoSystem.Forms;


namespace AutoSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInitial frmInitial = new FrmInitial();
                DbOperations.LoginOperation(tbxLogin, tbxPassword,frmInitial);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Todo corrigir este evento!
            }
        }
    }
}
