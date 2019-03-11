using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using AutoSystem.Forms;
using AutoSystem.Classes;
using AutoSystem.Enums;

namespace AutoSystem.Forms
{
    public partial class FrmStockUpdate : Form
    {
        public FrmStockUpdate()
        {
            InitializeComponent();

            cbxVehicleType.DataSource = Enum.GetNames(typeof(VehicleTypes));
            cbxVehicleType.SelectedIndex = -1;
            cbxVehicleVersion.DataSource = Enum.GetNames(typeof(VehicleVersionGeneric));
            cbxVehicleVersion.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear.ClearTextBoxes(this.tabInsertItem);
            Clear.ClearComboBoxes(this.tabInsertItem);
            Clear.ClearMaskedBoxes(this.tabInsertItem);
            Clear.ClearComboBoxes(this);
            tbxCodPart.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string code = tbxCodPart.Text;
                decimal value = Convert.ToDecimal(mtbValuePart.Text.Replace('.',','));
                int amount = Convert.ToInt16(tbxQtdPart.Text);
                string description = tbxDescPart.Text;
                string vehicle = cbxVehicleType.Text.ToString();
                string brand = cbxVehicleBrand.Text.ToString();
                string model = cbxVehicleModel.Text.ToString();
                string version = cbxVehicleVersion.Text.ToString();

                //IMPLEMENTAR VERIFICAÇÃO DE CAMPOS VAZIOS ANTES DE SALVAR

                DbOperations.InsertStockItem(code, value, amount, description, vehicle, brand, model, version);
                Clear.ClearComboBoxes(this.tabInsertItem);
                Clear.ClearTextBoxes(this.tabInsertItem);
                Clear.ClearMaskedBoxes(this.tabInsertItem);
                tbxCodPart.Focus();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {

        }

        private void FrmStockUpdate_Load(object sender, EventArgs e)
        {

        }

        private void cbxVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVehicleType.SelectedIndex == 00)
            {
                cbxVehicleBrand.DataSource = Enum.GetNames(typeof(CarsBrands));
                cbxVehicleBrand.SelectedIndex = -1;
            }
            else
            {
                cbxVehicleBrand.DataSource = Enum.GetNames(typeof(BikesBrands));
                cbxVehicleBrand.SelectedIndex = -1;
            }
        }
        //CRIAR UM METODO PARA EVITAR EXIBIR EM DUPLICIDADE DE MODELOS, VERSÕES ETC.
        private void cbxVehicleBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbOperations.FillComboBoxModel(cbxVehicleBrand, cbxVehicleModel);
        }

        private void cbxVehicleModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbOperations.FillComboBoxVersion(cbxVehicleModel, cbxVehicleVersion);
        }
    }
}
