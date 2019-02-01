﻿using System;
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
            try
            {
                DbOperations.GetUsersData(dgvUsers);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnUserStatus_Click(object sender, EventArgs e)
        {
            try
            {
                //todo: Alterar Status dE ativo para inativo
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DbOperations.DeleteUserSystem(dgvUsers);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //FrmUserStatus frmUserStatus = new FrmUserStatus();
                //frmUserStatus.Show();
                string teste = "ativo";
                DbOperations.UpdateUserStatus(dgvUsers,teste); 
                //todo: VERIFICAR COMO TRAZER O VALOR DO STATUS DO OUTRO FORMULARIO PARA ESTE FORM
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
    }
}
