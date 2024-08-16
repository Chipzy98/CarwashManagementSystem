using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWashManagementSystem
{
    public partial class FrmCashPayment : Form
    {
        public FrmCashPayment()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            FrmPayment form10 = new FrmPayment();
            form10.Show();
            this.Close();
        }

        private void FrmCashPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
