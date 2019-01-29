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
    public partial class FrmSystemUsers : Form
    {
        public FrmSystemUsers()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUserReg frmUserReg = new FrmUserReg();
                frmUserReg.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUserView frmUserView = new FrmUserView();
                frmUserView.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
