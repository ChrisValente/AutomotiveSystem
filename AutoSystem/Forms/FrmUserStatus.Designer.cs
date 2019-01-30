namespace AutoSystem.Forms
{
    partial class FrmUserStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserStatus));
            this.btnStatusSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxUserStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnStatusSave
            // 
            this.btnStatusSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusSave.Location = new System.Drawing.Point(80, 98);
            this.btnStatusSave.Name = "btnStatusSave";
            this.btnStatusSave.Size = new System.Drawing.Size(75, 23);
            this.btnStatusSave.TabIndex = 0;
            this.btnStatusSave.Text = "Salvar";
            this.btnStatusSave.UseVisualStyleBackColor = true;
            this.btnStatusSave.Click += new System.EventHandler(this.btnStatusSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o status do usuário";
            // 
            // cbxUserStatus
            // 
            this.cbxUserStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUserStatus.FormattingEnabled = true;
            this.cbxUserStatus.Location = new System.Drawing.Point(57, 55);
            this.cbxUserStatus.Name = "cbxUserStatus";
            this.cbxUserStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxUserStatus.TabIndex = 2;
            // 
            // FrmUserStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 133);
            this.Controls.Add(this.cbxUserStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatusSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUserStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alteração de Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStatusSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxUserStatus;
    }
}