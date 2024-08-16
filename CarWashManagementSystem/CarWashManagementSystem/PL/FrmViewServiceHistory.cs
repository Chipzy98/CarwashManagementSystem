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
    public partial class FrmViewServiceHistory : Form
    {
        public FrmViewServiceHistory()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            FrmCustomer form11 = new FrmCustomer();
            form11.Show();
            this.Close();
        }
    }
}
