namespace AutoSystem.Forms
{
    partial class FrmVehicleControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehicleControl));
            this.tbcVehicle = new System.Windows.Forms.TabControl();
            this.tabReg = new System.Windows.Forms.TabPage();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxVersion = new System.Windows.Forms.TextBox();
            this.tabConsult = new System.Windows.Forms.TabPage();
            this.btnShow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSelectVehicleType = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.dgvShowCars = new System.Windows.Forms.DataGridView();
            this.tbcVehicle.SuspendLayout();
            this.tabReg.SuspendLayout();
            this.tabConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCars)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcVehicle
            // 
            this.tbcVehicle.Controls.Add(this.tabReg);
            this.tbcVehicle.Controls.Add(this.tabConsult);
            this.tbcVehicle.Location = new System.Drawing.Point(0, -2);
            this.tbcVehicle.Name = "tbcVehicle";
            this.tbcVehicle.SelectedIndex = 0;
            this.tbcVehicle.Size = new System.Drawing.Size(562, 230);
            this.tbcVehicle.TabIndex = 0;
            // 
            // tabReg
            // 
            this.tabReg.Controls.Add(this.cbxType);
            this.tabReg.Controls.Add(this.label4);
            this.tabReg.Controls.Add(this.label3);
            this.tabReg.Controls.Add(this.label2);
            this.tabReg.Controls.Add(this.label1);
            this.tabReg.Controls.Add(this.btnClear);
            this.tabReg.Controls.Add(this.btnSave);
            this.tabReg.Controls.Add(this.cbxBrand);
            this.tabReg.Controls.Add(this.tbxModel);
            this.tabReg.Controls.Add(this.tbxVersion);
            this.tabReg.Location = new System.Drawing.Point(4, 22);
            this.tabReg.Name = "tabReg";
            this.tabReg.Padding = new System.Windows.Forms.Padding(3);
            this.tabReg.Size = new System.Drawing.Size(554, 204);
            this.tabReg.TabIndex = 0;
            this.tabReg.Text = "Registrar";
            this.tabReg.UseVisualStyleBackColor = true;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(77, 22);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(149, 21);
            this.cbxType.TabIndex = 11;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Versão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo:";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(314, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(403, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(314, 22);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(164, 21);
            this.cbxBrand.TabIndex = 13;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(77, 73);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(149, 20);
            this.tbxModel.TabIndex = 15;
            // 
            // tbxVersion
            // 
            this.tbxVersion.Location = new System.Drawing.Point(314, 73);
            this.tbxVersion.Name = "tbxVersion";
            this.tbxVersion.Size = new System.Drawing.Size(164, 20);
            this.tbxVersion.TabIndex = 17;
            // 
            // tabConsult
            // 
            this.tabConsult.Controls.Add(this.btnShow);
            this.tabConsult.Controls.Add(this.label5);
            this.tabConsult.Controls.Add(this.cbxSelectVehicleType);
            this.tabConsult.Controls.Add(this.BtnDelete);
            this.tabConsult.Controls.Add(this.dgvShowCars);
            this.tabConsult.Location = new System.Drawing.Point(4, 22);
            this.tabConsult.Name = "tabConsult";
            this.tabConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsult.Size = new System.Drawing.Size(554, 204);
            this.tabConsult.TabIndex = 1;
            this.tabConsult.Text = "Consultar";
            this.tabConsult.UseVisualStyleBackColor = true;
            this.tabConsult.Click += new System.EventHandler(this.tabConsult_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(329, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Exibir";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Selecione o tipo de veículo:";
            // 
            // cbxSelectVehicleType
            // 
            this.cbxSelectVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSelectVehicleType.FormattingEnabled = true;
            this.cbxSelectVehicleType.Location = new System.Drawing.Point(143, 5);
            this.cbxSelectVehicleType.Name = "cbxSelectVehicleType";
            this.cbxSelectVehicleType.Size = new System.Drawing.Size(121, 21);
            this.cbxSelectVehicleType.TabIndex = 1;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(419, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Deletar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dgvShowCars
            // 
            this.dgvShowCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvShowCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowCars.Location = new System.Drawing.Point(6, 32);
            this.dgvShowCars.Name = "dgvShowCars";
            this.dgvShowCars.Size = new System.Drawing.Size(488, 158);
            this.dgvShowCars.TabIndex = 4;
            // 
            // FrmVehicleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 219);
            this.Controls.Add(this.tbcVehicle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVehicleControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículos";
            this.tbcVehicle.ResumeLayout(false);
            this.tabReg.ResumeLayout(false);
            this.tabReg.PerformLayout();
            this.tabConsult.ResumeLayout(false);
            this.tabConsult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcVehicle;
        private System.Windows.Forms.TabPage tabReg;
        private System.Windows.Forms.TabPage tabConsult;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSelectVehicleType;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView dgvShowCars;
        private System.Windows.Forms.Button btnShow;
    }
}