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
    public partial class FrmVehicleControl : Form
    {
        public FrmVehicleControl()
        {
            InitializeComponent();
            cbxType.DataSource = Enum.GetNames(typeof(VehicleTypes));
            cbxType.SelectedIndex = -1;
            cbxSelectVehicleType.DataSource = Enum.GetNames(typeof(VehicleTypes));
            cbxSelectVehicleType.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validations.EmptyComboBoxes(this);
                Validations.EmptyTextBoxes(this);
                string type = cbxType.Text.ToUpper();
                string brand = cbxBrand.Text.ToUpper();
                string model = tbxModel.Text.ToUpper();
                string version = tbxVersion.Text.ToUpper();

                DbOperations.InsertNewVehicle(type, brand, model, version);
                Clear.ClearComboBoxes(this.tabReg);
                Clear.ClearTextBoxes(this.tabReg);
                cbxType.Focus();
                
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
                Clear.ClearTextBoxes(this.tabReg);
                Clear.ClearComboBoxes(this.tabReg);
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

        private void tabConsult_Click(object sender, EventArgs e)
        {
            try
            {
                cbxSelectVehicleType.DataSource = Enum.GetNames(typeof(VehicleTypes));
                cbxSelectVehicleType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string type = cbxSelectVehicleType.Text;
                DbOperations.GetVehicleData(dgvShowCars, type);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DbOperations.DeleteVehicle(dgvShowCars);
                string type = cbxSelectVehicleType.Text;
                DbOperations.GetVehicleData(dgvShowCars, type);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}
