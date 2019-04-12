using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoSystem.Classes;

namespace AutoSystem.Forms
{
    public partial class FrmStockView : Form
    {
        public FrmStockView()
        {
            InitializeComponent();
        }

        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            DbOperations.SearchStockItem(tbxPartSearch, dgvShowParts);
        }

        private void FrmStockView_Load(object sender, EventArgs e)
        {
            DbOperations.GetStockData(dgvShowParts);
        }
    }
}
