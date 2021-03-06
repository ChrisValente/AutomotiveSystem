﻿using System;
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
    public partial class FrmInternalControl : Form
    {
        public FrmInternalControl()
        {
            InitializeComponent();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVehicleControl frmVehicle = new FrmVehicleControl();
                frmVehicle.Show();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            try
            {
                FrmStock stock = new FrmStock();
                stock.Show();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
