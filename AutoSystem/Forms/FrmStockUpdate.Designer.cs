namespace AutoSystem.Forms
{
    partial class FrmStockUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockUpdate));
            this.tbcStockUpd = new System.Windows.Forms.TabControl();
            this.tabInsertItem = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxVehicleVersion = new System.Windows.Forms.ComboBox();
            this.cbxVehicleModel = new System.Windows.Forms.ComboBox();
            this.cbxVehicleBrand = new System.Windows.Forms.ComboBox();
            this.cbxVehicleType = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.mtbValuePart = new System.Windows.Forms.MaskedTextBox();
            this.tbxQtdPart = new System.Windows.Forms.TextBox();
            this.tbxDescPart = new System.Windows.Forms.TextBox();
            this.tbxCodPart = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.tabUpdateStock = new System.Windows.Forms.TabPage();
            this.lvUpdResume = new System.Windows.Forms.ListView();
            this.btnSaveUpd = new System.Windows.Forms.Button();
            this.mtbValueUpd = new System.Windows.Forms.MaskedTextBox();
            this.tbxQtdUpd = new System.Windows.Forms.TextBox();
            this.tbxDescUpd = new System.Windows.Forms.TextBox();
            this.lblQtdUpd = new System.Windows.Forms.Label();
            this.lblValueUpd = new System.Windows.Forms.Label();
            this.lblDescUpd = new System.Windows.Forms.Label();
            this.btnSearchPartUpd = new System.Windows.Forms.Button();
            this.tbxSearchPartUpd = new System.Windows.Forms.TextBox();
            this.lblCodUpd = new System.Windows.Forms.Label();
            this.tbcStockUpd.SuspendLayout();
            this.tabInsertItem.SuspendLayout();
            this.tabUpdateStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcStockUpd
            // 
            this.tbcStockUpd.Controls.Add(this.tabInsertItem);
            this.tbcStockUpd.Controls.Add(this.tabUpdateStock);
            this.tbcStockUpd.Location = new System.Drawing.Point(1, 1);
            this.tbcStockUpd.Name = "tbcStockUpd";
            this.tbcStockUpd.SelectedIndex = 0;
            this.tbcStockUpd.Size = new System.Drawing.Size(623, 316);
            this.tbcStockUpd.TabIndex = 0;
            // 
            // tabInsertItem
            // 
            this.tabInsertItem.Controls.Add(this.label4);
            this.tabInsertItem.Controls.Add(this.label3);
            this.tabInsertItem.Controls.Add(this.label2);
            this.tabInsertItem.Controls.Add(this.label1);
            this.tabInsertItem.Controls.Add(this.cbxVehicleVersion);
            this.tabInsertItem.Controls.Add(this.cbxVehicleModel);
            this.tabInsertItem.Controls.Add(this.cbxVehicleBrand);
            this.tabInsertItem.Controls.Add(this.cbxVehicleType);
            this.tabInsertItem.Controls.Add(this.btnClear);
            this.tabInsertItem.Controls.Add(this.btnSave);
            this.tabInsertItem.Controls.Add(this.mtbValuePart);
            this.tabInsertItem.Controls.Add(this.tbxQtdPart);
            this.tabInsertItem.Controls.Add(this.tbxDescPart);
            this.tabInsertItem.Controls.Add(this.tbxCodPart);
            this.tabInsertItem.Controls.Add(this.lblQtd);
            this.tabInsertItem.Controls.Add(this.lblValue);
            this.tabInsertItem.Controls.Add(this.lblDesc);
            this.tabInsertItem.Controls.Add(this.lblCod);
            this.tabInsertItem.Location = new System.Drawing.Point(4, 22);
            this.tabInsertItem.Name = "tabInsertItem";
            this.tabInsertItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsertItem.Size = new System.Drawing.Size(615, 290);
            this.tabInsertItem.TabIndex = 0;
            this.tabInsertItem.Text = "Inserir Itens";
            this.tabInsertItem.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Versão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Veículo:";
            // 
            // cbxVehicleVersion
            // 
            this.cbxVehicleVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxVehicleVersion.FormattingEnabled = true;
            this.cbxVehicleVersion.Location = new System.Drawing.Point(409, 158);
            this.cbxVehicleVersion.Name = "cbxVehicleVersion";
            this.cbxVehicleVersion.Size = new System.Drawing.Size(166, 21);
            this.cbxVehicleVersion.TabIndex = 15;
            // 
            // cbxVehicleModel
            // 
            this.cbxVehicleModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxVehicleModel.FormattingEnabled = true;
            this.cbxVehicleModel.Location = new System.Drawing.Point(409, 117);
            this.cbxVehicleModel.Name = "cbxVehicleModel";
            this.cbxVehicleModel.Size = new System.Drawing.Size(166, 21);
            this.cbxVehicleModel.TabIndex = 13;
            this.cbxVehicleModel.SelectedIndexChanged += new System.EventHandler(this.cbxVehicleModel_SelectedIndexChanged);
            // 
            // cbxVehicleBrand
            // 
            this.cbxVehicleBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxVehicleBrand.FormattingEnabled = true;
            this.cbxVehicleBrand.Location = new System.Drawing.Point(409, 76);
            this.cbxVehicleBrand.Name = "cbxVehicleBrand";
            this.cbxVehicleBrand.Size = new System.Drawing.Size(166, 21);
            this.cbxVehicleBrand.TabIndex = 11;
            this.cbxVehicleBrand.SelectedIndexChanged += new System.EventHandler(this.cbxVehicleBrand_SelectedIndexChanged);
            // 
            // cbxVehicleType
            // 
            this.cbxVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxVehicleType.FormattingEnabled = true;
            this.cbxVehicleType.Location = new System.Drawing.Point(409, 35);
            this.cbxVehicleType.Name = "cbxVehicleType";
            this.cbxVehicleType.Size = new System.Drawing.Size(166, 21);
            this.cbxVehicleType.TabIndex = 9;
            this.cbxVehicleType.SelectedIndexChanged += new System.EventHandler(this.cbxVehicleType_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(409, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(500, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mtbValuePart
            // 
            this.mtbValuePart.Location = new System.Drawing.Point(106, 158);
            this.mtbValuePart.Name = "mtbValuePart";
            this.mtbValuePart.Size = new System.Drawing.Size(146, 20);
            this.mtbValuePart.TabIndex = 7;
            this.mtbValuePart.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbxQtdPart
            // 
            this.tbxQtdPart.Location = new System.Drawing.Point(106, 117);
            this.tbxQtdPart.Name = "tbxQtdPart";
            this.tbxQtdPart.Size = new System.Drawing.Size(146, 20);
            this.tbxQtdPart.TabIndex = 5;
            // 
            // tbxDescPart
            // 
            this.tbxDescPart.Location = new System.Drawing.Point(106, 76);
            this.tbxDescPart.Name = "tbxDescPart";
            this.tbxDescPart.Size = new System.Drawing.Size(146, 20);
            this.tbxDescPart.TabIndex = 3;
            // 
            // tbxCodPart
            // 
            this.tbxCodPart.Location = new System.Drawing.Point(106, 35);
            this.tbxCodPart.Name = "tbxCodPart";
            this.tbxCodPart.Size = new System.Drawing.Size(146, 20);
            this.tbxCodPart.TabIndex = 1;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(35, 120);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(65, 13);
            this.lblQtd.TabIndex = 4;
            this.lblQtd.Text = "Quantidade:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(35, 161);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 6;
            this.lblValue.Text = "Valor:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(35, 79);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descrição:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(35, 38);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // tabUpdateStock
            // 
            this.tabUpdateStock.Controls.Add(this.lvUpdResume);
            this.tabUpdateStock.Controls.Add(this.btnSaveUpd);
            this.tabUpdateStock.Controls.Add(this.mtbValueUpd);
            this.tabUpdateStock.Controls.Add(this.tbxQtdUpd);
            this.tabUpdateStock.Controls.Add(this.tbxDescUpd);
            this.tabUpdateStock.Controls.Add(this.lblQtdUpd);
            this.tabUpdateStock.Controls.Add(this.lblValueUpd);
            this.tabUpdateStock.Controls.Add(this.lblDescUpd);
            this.tabUpdateStock.Controls.Add(this.btnSearchPartUpd);
            this.tabUpdateStock.Controls.Add(this.tbxSearchPartUpd);
            this.tabUpdateStock.Controls.Add(this.lblCodUpd);
            this.tabUpdateStock.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateStock.Name = "tabUpdateStock";
            this.tabUpdateStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateStock.Size = new System.Drawing.Size(615, 290);
            this.tabUpdateStock.TabIndex = 1;
            this.tabUpdateStock.Text = "Atualizar Estoque";
            this.tabUpdateStock.UseVisualStyleBackColor = true;
            // 
            // lvUpdResume
            // 
            this.lvUpdResume.Location = new System.Drawing.Point(376, 11);
            this.lvUpdResume.Name = "lvUpdResume";
            this.lvUpdResume.Size = new System.Drawing.Size(208, 144);
            this.lvUpdResume.TabIndex = 15;
            this.lvUpdResume.UseCompatibleStateImageBehavior = false;
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(509, 178);
            this.btnSaveUpd.Name = "btnSaveUpd";
            this.btnSaveUpd.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUpd.TabIndex = 14;
            this.btnSaveUpd.Text = "Salvar";
            this.btnSaveUpd.UseVisualStyleBackColor = true;
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // mtbValueUpd
            // 
            this.mtbValueUpd.Location = new System.Drawing.Point(88, 94);
            this.mtbValueUpd.Mask = "$";
            this.mtbValueUpd.Name = "mtbValueUpd";
            this.mtbValueUpd.Size = new System.Drawing.Size(146, 20);
            this.mtbValueUpd.TabIndex = 13;
            // 
            // tbxQtdUpd
            // 
            this.tbxQtdUpd.Location = new System.Drawing.Point(88, 135);
            this.tbxQtdUpd.Name = "tbxQtdUpd";
            this.tbxQtdUpd.Size = new System.Drawing.Size(146, 20);
            this.tbxQtdUpd.TabIndex = 12;
            // 
            // tbxDescUpd
            // 
            this.tbxDescUpd.Location = new System.Drawing.Point(88, 53);
            this.tbxDescUpd.Name = "tbxDescUpd";
            this.tbxDescUpd.Size = new System.Drawing.Size(146, 20);
            this.tbxDescUpd.TabIndex = 11;
            // 
            // lblQtdUpd
            // 
            this.lblQtdUpd.AutoSize = true;
            this.lblQtdUpd.Location = new System.Drawing.Point(17, 138);
            this.lblQtdUpd.Name = "lblQtdUpd";
            this.lblQtdUpd.Size = new System.Drawing.Size(65, 13);
            this.lblQtdUpd.TabIndex = 10;
            this.lblQtdUpd.Text = "Quantidade:";
            // 
            // lblValueUpd
            // 
            this.lblValueUpd.AutoSize = true;
            this.lblValueUpd.Location = new System.Drawing.Point(17, 97);
            this.lblValueUpd.Name = "lblValueUpd";
            this.lblValueUpd.Size = new System.Drawing.Size(34, 13);
            this.lblValueUpd.TabIndex = 9;
            this.lblValueUpd.Text = "Valor:";
            // 
            // lblDescUpd
            // 
            this.lblDescUpd.AutoSize = true;
            this.lblDescUpd.Location = new System.Drawing.Point(17, 56);
            this.lblDescUpd.Name = "lblDescUpd";
            this.lblDescUpd.Size = new System.Drawing.Size(58, 13);
            this.lblDescUpd.TabIndex = 8;
            this.lblDescUpd.Text = "Descrição:";
            // 
            // btnSearchPartUpd
            // 
            this.btnSearchPartUpd.Location = new System.Drawing.Point(270, 9);
            this.btnSearchPartUpd.Name = "btnSearchPartUpd";
            this.btnSearchPartUpd.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPartUpd.TabIndex = 2;
            this.btnSearchPartUpd.Text = "Pesquisar";
            this.btnSearchPartUpd.UseVisualStyleBackColor = true;
            // 
            // tbxSearchPartUpd
            // 
            this.tbxSearchPartUpd.Location = new System.Drawing.Point(88, 11);
            this.tbxSearchPartUpd.Name = "tbxSearchPartUpd";
            this.tbxSearchPartUpd.Size = new System.Drawing.Size(146, 20);
            this.tbxSearchPartUpd.TabIndex = 1;
            // 
            // lblCodUpd
            // 
            this.lblCodUpd.AutoSize = true;
            this.lblCodUpd.Location = new System.Drawing.Point(17, 18);
            this.lblCodUpd.Name = "lblCodUpd";
            this.lblCodUpd.Size = new System.Drawing.Size(43, 13);
            this.lblCodUpd.TabIndex = 0;
            this.lblCodUpd.Text = "Código:";
            // 
            // FrmStockUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 313);
            this.Controls.Add(this.tbcStockUpd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStockUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizações de Estoque";
            this.Load += new System.EventHandler(this.FrmStockUpdate_Load);
            this.tbcStockUpd.ResumeLayout(false);
            this.tabInsertItem.ResumeLayout(false);
            this.tabInsertItem.PerformLayout();
            this.tabUpdateStock.ResumeLayout(false);
            this.tabUpdateStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcStockUpd;
        private System.Windows.Forms.TabPage tabInsertItem;
        private System.Windows.Forms.TabPage tabUpdateStock;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.MaskedTextBox mtbValuePart;
        private System.Windows.Forms.TextBox tbxQtdPart;
        private System.Windows.Forms.TextBox tbxDescPart;
        private System.Windows.Forms.TextBox tbxCodPart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lvUpdResume;
        private System.Windows.Forms.Button btnSaveUpd;
        private System.Windows.Forms.MaskedTextBox mtbValueUpd;
        private System.Windows.Forms.TextBox tbxQtdUpd;
        private System.Windows.Forms.TextBox tbxDescUpd;
        private System.Windows.Forms.Label lblQtdUpd;
        private System.Windows.Forms.Label lblValueUpd;
        private System.Windows.Forms.Label lblDescUpd;
        private System.Windows.Forms.Button btnSearchPartUpd;
        private System.Windows.Forms.TextBox tbxSearchPartUpd;
        private System.Windows.Forms.Label lblCodUpd;
        private System.Windows.Forms.ComboBox cbxVehicleBrand;
        private System.Windows.Forms.ComboBox cbxVehicleType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxVehicleVersion;
        private System.Windows.Forms.ComboBox cbxVehicleModel;
    }
}