namespace AutoSystem.Forms
{
    partial class FrmInternalControl
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
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVehicle
            // 
            this.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicle.Location = new System.Drawing.Point(188, 93);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnVehicle.TabIndex = 0;
            this.btnVehicle.Text = "Veículos";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnStock
            // 
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Location = new System.Drawing.Point(188, 160);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(75, 23);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Estoque";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnServices
            // 
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Location = new System.Drawing.Point(188, 224);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(75, 23);
            this.btnServices.TabIndex = 2;
            this.btnServices.Text = "Serviços";
            this.btnServices.UseVisualStyleBackColor = true;
            // 
            // FrmInternalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 313);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnVehicle);
            this.Name = "FrmInternalControl";
            this.Text = "FrmInternalControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnServices;
    }
}