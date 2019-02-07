namespace AutoSystem.Forms
{
    partial class FrmPartsReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartsReg));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPartCode = new System.Windows.Forms.TextBox();
            this.tbxPartDescription = new System.Windows.Forms.TextBox();
            this.tbxPartQuantity = new System.Windows.Forms.TextBox();
            this.mtbPartValue = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(530, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(437, 132);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade:";
            // 
            // tbxPartCode
            // 
            this.tbxPartCode.Location = new System.Drawing.Point(90, 27);
            this.tbxPartCode.Name = "tbxPartCode";
            this.tbxPartCode.Size = new System.Drawing.Size(152, 20);
            this.tbxPartCode.TabIndex = 6;
            // 
            // tbxPartDescription
            // 
            this.tbxPartDescription.Location = new System.Drawing.Point(90, 77);
            this.tbxPartDescription.Multiline = true;
            this.tbxPartDescription.Name = "tbxPartDescription";
            this.tbxPartDescription.Size = new System.Drawing.Size(515, 20);
            this.tbxPartDescription.TabIndex = 7;
            // 
            // tbxPartQuantity
            // 
            this.tbxPartQuantity.Location = new System.Drawing.Point(505, 27);
            this.tbxPartQuantity.Name = "tbxPartQuantity";
            this.tbxPartQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbxPartQuantity.TabIndex = 9;
            // 
            // mtbPartValue
            // 
            this.mtbPartValue.Location = new System.Drawing.Point(308, 27);
            this.mtbPartValue.Mask = "$";
            this.mtbPartValue.Name = "mtbPartValue";
            this.mtbPartValue.Size = new System.Drawing.Size(100, 20);
            this.mtbPartValue.TabIndex = 10;
            // 
            // FrmPartsReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 176);
            this.Controls.Add(this.mtbPartValue);
            this.Controls.Add(this.tbxPartQuantity);
            this.Controls.Add(this.tbxPartDescription);
            this.Controls.Add(this.tbxPartCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPartsReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Peças";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPartCode;
        private System.Windows.Forms.TextBox tbxPartDescription;
        private System.Windows.Forms.TextBox tbxPartQuantity;
        private System.Windows.Forms.MaskedTextBox mtbPartValue;
    }
}