namespace AutoSystem.Forms
{
    partial class FrmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsult
            // 
            this.btnConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsult.Location = new System.Drawing.Point(83, 51);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(75, 57);
            this.btnConsult.TabIndex = 0;
            this.btnConsult.Text = "Consultar";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(198, 51);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 57);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 167);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnConsult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStock";
            this.Text = "Estoque";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnUpdate;
    }
}