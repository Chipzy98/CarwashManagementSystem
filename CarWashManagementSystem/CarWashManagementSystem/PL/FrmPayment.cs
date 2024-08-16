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
    public partial class FrmPayment : Form
    {
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            FrmCustomer form6 = new FrmCustomer();
            form6.Show();
            this.Close();
        }

        private void cashPaymentbtn_Click(object sender, EventArgs e)
        {
            FrmCashPayment form7 = new FrmCashPayment();
            form7.Show();
            this.Close();
        }

        private void cardPaymentbtn_Click(object sender, EventArgs e)
        {
            FrmCardPayment form8 = new FrmCardPayment();
            form8.Show();
            this.Close();
        }
    }
}
