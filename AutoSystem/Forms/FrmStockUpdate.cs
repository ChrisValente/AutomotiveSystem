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

            cbxVehicleType.DataSource = Enum.GetNames(typeof(VehicleTypes)).OrderBy(x => (string)x).ToList(); 
            cbxVehicleType.SelectedIndex = -1;
            cbxVehicleVersion.DataSource = Enum.GetNames(typeof(VehicleVersionGeneric)).OrderBy(x => (string)x).ToList(); 
            cbxVehicleVersion.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            try
            {
                Clear.ClearTextBoxes(this.tabInsertItem);
                Clear.ClearMaskedBoxes(this.tabInsertItem);
                Clear.ClearComboBoxes(this.tabInsertItem);
                tbxCodPart.Focus();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validations.EmptyTextBoxes(this.tabInsertItem);                
                Validations.EmptyMaskedTextBoxes(this.tabInsertItem);
                Validations.EmptyComboBoxes(this.tabInsertItem);
                //todo: aparecendo item na cbxVersion quando veiculo é selecionado 
                //cbx model e version não limpam automaticamente

                string code = tbxCodPart.Text.ToUpper();
                decimal value = Convert.ToDecimal(mtbValuePart.Text.Replace('.',','));
                int amount = Convert.ToInt16(tbxQtdPart.Text);
                string description = tbxDescPart.Text.ToUpper();
                string vehicle = cbxVehicleType.Text.ToString().ToUpper();
                string brand = cbxVehicleBrand.Text.ToString().ToUpper();
                string model = cbxVehicleModel.Text.ToString().ToUpper();
                string version = cbxVehicleVersion.Text.ToString().ToUpper();
                
                DbOperations.InsertStockItem(code, value, amount, description, vehicle, brand, model, version);
                Clear.ClearComboBoxes(this.tabInsertItem);
                Clear.ClearTextBoxes(this.tabInsertItem);
                Clear.ClearMaskedBoxes(this.tabInsertItem);
                tbxCodPart.Focus();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Atenção");
                tbxCodPart.Focus();
            }
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            try
            {
                DbOperations.UpdateStock(tbxCodePartUpd, tbxDescUpd, tbxQtdUpd, mtbValueUpd,cbxVehicleUpd,cbxBrandUpd,cbxModelUpd,cbxVersionUpd);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void FrmStockUpdate_Load(object sender, EventArgs e)
        {

        }

        private void cbxVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVehicleType.SelectedIndex == 00)
            {
                cbxVehicleBrand.DataSource = Enum.GetNames(typeof(CarsBrands)).OrderBy(x => (string)x).ToList();
                cbxVehicleBrand.SelectedIndex = -1;
            }
            else
            {
                cbxVehicleBrand.DataSource = Enum.GetNames(typeof(BikesBrands)).OrderBy(x => (string)x).ToList();
                cbxVehicleBrand.SelectedIndex = -1;
            }
        }
        
        private void cbxVehicleBrand_SelectedIndexChanged(object sender, EventArgs e)
        {      
            try
            {
                DbOperations.FillComboBoxModel(cbxVehicleBrand, cbxVehicleModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void cbxVehicleModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DbOperations.FillComboBoxVersion(cbxVehicleModel, cbxVehicleVersion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnSearchPartUpd_Click(object sender, EventArgs e)
        {            
            try
            {
                DbOperations.FillUpdateStock(tbxCodePartUpd, tbxDescUpd, tbxQtdUpd, mtbValueUpd, cbxVehicleUpd, cbxBrandUpd, cbxModelUpd, cbxVersionUpd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
