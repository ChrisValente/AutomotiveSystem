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
using AutoSystem.Enums;

namespace AutoSystem.Forms
{
    public partial class FrmVehicleReg : Form
    {
        public FrmVehicleReg()
        {
            InitializeComponent();
            cbxType.DataSource = Enum.GetNames(typeof(VehicleTypes));
            cbxType.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validations.EmptyComboBoxes(this);
                Validations.EmptyTextBoxes(this);
                //todo: CORRIGIR ERRO DE DOIS RETORNOS SEGUIDOS
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear.ClearTextBoxes(this);
                Clear.ClearComboBoxes(this);
                cbxType.Focus();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.SelectedIndex == 0)
            {
                cbxBrand.DataSource = Enum.GetNames(typeof(CarsBrands));
                cbxBrand.SelectedIndex = -1;
            }
            else
            {
                cbxBrand.DataSource = Enum.GetNames(typeof(BikesBrands));
                cbxBrand.SelectedIndex = -1;
            }
        }
    }
}
