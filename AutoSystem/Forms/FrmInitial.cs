using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSystem.Forms
{
    public partial class FrmInitial : Form
    {
        public FrmInitial()
        {
            InitializeComponent();
        }

        private void btnAtendance_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSystemUsers frmSystemUsers = new FrmSystemUsers();
                frmSystemUsers.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
