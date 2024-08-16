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
    public partial class FrmCarWash : Form
    {
        public FrmCarWash()
        {
            InitializeComponent();
        }

        private void Addcusbtn_Click(object sender, EventArgs e)
        {
            FrmAddCustomer form1 = new FrmAddCustomer();
            form1.Show();
        }

        private void Custumerbtn_Click(object sender, EventArgs e)
        {
            FrmCustomer form2 = new FrmCustomer();
            form2.Show();
        }

        private void Staffbtn_Click(object sender, EventArgs e)
        {
            FrmAddEmployee form14 = new FrmAddEmployee();
            form14.Show();
        }

        private void CarWash_Load(object sender, EventArgs e)
        {

        }
    }
}
