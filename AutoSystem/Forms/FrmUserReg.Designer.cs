namespace AutoSystem.Forms
{
    partial class FrmUserReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserReg));
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxUserLastName = new System.Windows.Forms.TextBox();
            this.tbxUserLogin = new System.Windows.Forms.TextBox();
            this.tbxUserPassword = new System.Windows.Forms.TextBox();
            this.tbxUserDepartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxUserStatus = new System.Windows.Forms.ComboBox();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.btnUserClearForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(63, 27);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(161, 20);
            this.tbxUserName.TabIndex = 1;
            // 
            // tbxUserLastName
            // 
            this.tbxUserLastName.Location = new System.Drawing.Point(347, 27);
            this.tbxUserLastName.Name = "tbxUserLastName";
            this.tbxUserLastName.Size = new System.Drawing.Size(276, 20);
            this.tbxUserLastName.TabIndex = 3;
            // 
            // tbxUserLogin
            // 
            this.tbxUserLogin.Location = new System.Drawing.Point(63, 68);
            this.tbxUserLogin.Name = "tbxUserLogin";
            this.tbxUserLogin.Size = new System.Drawing.Size(161, 20);
            this.tbxUserLogin.TabIndex = 5;
            // 
            // tbxUserPassword
            // 
            this.tbxUserPassword.Location = new System.Drawing.Point(347, 68);
            this.tbxUserPassword.Name = "tbxUserPassword";
            this.tbxUserPassword.Size = new System.Drawing.Size(135, 20);
            this.tbxUserPassword.TabIndex = 7;
            // 
            // tbxUserDepartment
            // 
            this.tbxUserDepartment.Location = new System.Drawing.Point(347, 107);
            this.tbxUserDepartment.Name = "tbxUserDepartment";
            this.tbxUserDepartment.Size = new System.Drawing.Size(135, 20);
            this.tbxUserDepartment.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Departamento:";
            // 
            // cbxUserStatus
            // 
            this.cbxUserStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUserStatus.FormattingEnabled = true;
            this.cbxUserStatus.Location = new System.Drawing.Point(63, 107);
            this.cbxUserStatus.Name = "cbxUserStatus";
            this.cbxUserStatus.Size = new System.Drawing.Size(68, 21);
            this.cbxUserStatus.TabIndex = 9;
            // 
            // btnUserSave
            // 
            this.btnUserSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSave.Location = new System.Drawing.Point(545, 160);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(69, 23);
            this.btnUserSave.TabIndex = 12;
            this.btnUserSave.Text = "Salvar";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // btnUserClearForm
            // 
            this.btnUserClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserClearForm.Location = new System.Drawing.Point(458, 160);
            this.btnUserClearForm.Name = "btnUserClearForm";
            this.btnUserClearForm.Size = new System.Drawing.Size(69, 23);
            this.btnUserClearForm.TabIndex = 13;
            this.btnUserClearForm.Text = "Limpar";
            this.btnUserClearForm.UseVisualStyleBackColor = true;
            this.btnUserClearForm.Click += new System.EventHandler(this.btnUserClearForm_Click);
            // 
            // FrmUserReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 206);
            this.Controls.Add(this.btnUserClearForm);
            this.Controls.Add(this.btnUserSave);
            this.Controls.Add(this.cbxUserStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxUserDepartment);
            this.Controls.Add(this.tbxUserPassword);
            this.Controls.Add(this.tbxUserLogin);
            this.Controls.Add(this.tbxUserLastName);
            this.Controls.Add(this.tbxUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUserReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuário do sistema";
            this.Load += new System.EventHandler(this.FrmUserReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxUserLastName;
        private System.Windows.Forms.TextBox tbxUserLogin;
        private System.Windows.Forms.TextBox tbxUserPassword;
        private System.Windows.Forms.TextBox tbxUserDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxUserStatus;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Button btnUserClearForm;
    }
}