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
        

        public FrmUserStatus()
        {
            InitializeComponent();
            cbxUserStatus.DataSource = Enum.GetNames(typeof(UserStatus));
            cbxUserStatus.SelectedIndex = -1;

            //todo: acrescentar o método de update
        }

        internal void LoadOrders(string name, string lastName, string login)
        {
            
        }

        private void btnStatusSave_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUserView frmUserView = new FrmUserView();
                
               
                // código para salvar o update de status
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
