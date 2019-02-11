namespace AutoSystem.Forms
{
    partial class FrmStockView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockView));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPartSearch = new System.Windows.Forms.Button();
            this.tbxPartSearch = new System.Windows.Forms.TextBox();
            this.dgvShowParts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código da peça:";
            // 
            // btnPartSearch
            // 
            this.btnPartSearch.Location = new System.Drawing.Point(252, 8);
            this.btnPartSearch.Name = "btnPartSearch";
            this.btnPartSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPartSearch.TabIndex = 1;
            this.btnPartSearch.Text = "Pesquisar";
            this.btnPartSearch.UseVisualStyleBackColor = true;
            // 
            // tbxPartSearch
            // 
            this.tbxPartSearch.Location = new System.Drawing.Point(104, 10);
            this.tbxPartSearch.Name = "tbxPartSearch";
            this.tbxPartSearch.Size = new System.Drawing.Size(130, 20);
            this.tbxPartSearch.TabIndex = 2;
            // 
            // dgvShowParts
            // 
            this.dgvShowParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowParts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvShowParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowParts.Location = new System.Drawing.Point(14, 41);
            this.dgvShowParts.Name = "dgvShowParts";
            this.dgvShowParts.Size = new System.Drawing.Size(608, 300);
            this.dgvShowParts.TabIndex = 3;
            // 
            // FrmStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 353);
            this.Controls.Add(this.dgvShowParts);
            this.Controls.Add(this.tbxPartSearch);
            this.Controls.Add(this.btnPartSearch);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStockView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conteúdo em estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPartSearch;
        private System.Windows.Forms.TextBox tbxPartSearch;
        private System.Windows.Forms.DataGridView dgvShowParts;
    }
}