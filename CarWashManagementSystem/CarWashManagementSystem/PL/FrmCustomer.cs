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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void addchome_Click(object sender, EventArgs e)
        {
            FrmCarWash form = new FrmCarWash();
            form.Show();
            this.Close();
        }

        private void Appointbtn_Click(object sender, EventArgs e)
        {
            FrmAppointment form2 = new FrmAppointment();
            form2.Show();
            this.Close();
        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            FrmPayment form4 = new FrmPayment();
            form4.Show();
            this.Close();
        }

        private void vhisbtn_Click(object sender, EventArgs e)
        {
            FrmViewServiceHistory form12 = new FrmViewServiceHistory();
            form12.Show();
            this.Close();
        }
    }
}
