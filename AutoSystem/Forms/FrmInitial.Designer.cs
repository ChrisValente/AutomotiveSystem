namespace AutoSystem.Forms
{
    partial class FrmInitial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInitial));
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnAtendance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccounts
            // 
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounts.Image = global::AutoSystem.Properties.Resources.Folder_Group_icon;
            this.btnAccounts.Location = new System.Drawing.Point(367, 80);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(133, 144);
            this.btnAccounts.TabIndex = 2;
            this.btnAccounts.Text = "CONTAS DE USUÁRIOS";
            this.btnAccounts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnControl
            // 
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.Image = global::AutoSystem.Properties.Resources.Control_Panel_icon;
            this.btnControl.Location = new System.Drawing.Point(203, 80);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(133, 144);
            this.btnControl.TabIndex = 1;
            this.btnControl.Text = "CONTROLE INTERNO";
            this.btnControl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnAtendance
            // 
            this.btnAtendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtendance.Image = global::AutoSystem.Properties.Resources.User_Files_icon__1_;
            this.btnAtendance.Location = new System.Drawing.Point(39, 80);
            this.btnAtendance.Name = "btnAtendance";
            this.btnAtendance.Size = new System.Drawing.Size(133, 144);
            this.btnAtendance.TabIndex = 0;
            this.btnAtendance.Text = "ATENDIMENTO";
            this.btnAtendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtendance.UseVisualStyleBackColor = true;
            this.btnAtendance.Click += new System.EventHandler(this.btnAtendance_Click);
            // 
            // FrmInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 304);
            this.Controls.Add(this.btnAccounts);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btnAtendance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInitial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto System V.0.1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtendance;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnAccounts;
    }
}