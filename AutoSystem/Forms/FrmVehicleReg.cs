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
                string type = cbxType.Text.ToUpper();
                string brand = cbxBrand.Text.ToUpper();
                string model = tbxModel.Text.ToUpper();
                string version = tbxVersion.Text.ToUpper();

                DbOperations.InsertNewVehicle(type, brand, model, version);
                Clear.ClearComboBoxes(this);
                Clear.ClearTextBoxes(this);
                cbxType.Focus();
                //todo: CORRIGIR ERRO DE DOIS RETORNOS SEGUIDOS
                // Criar tabela para exibir veiculos cadastrados e metodo para deletar
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
