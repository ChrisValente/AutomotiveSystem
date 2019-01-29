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

namespace AutoSystem.Forms
{
    public partial class FrmUserView : Form
    {
        public FrmUserView()
        {
            InitializeComponent();
        }

        private void FrmUserView_Load(object sender, EventArgs e)
        {
            DbOperations.GetUsersData(dgvUsers);
        }

        private void btnUserStatus_Click(object sender, EventArgs e)
        {
            //todo: Alterar Status dE ativo para inativo
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            //todo: Delete Usuário
        }
    }
}
