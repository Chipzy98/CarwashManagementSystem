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
    public partial class FrmAddNewEmplyoyee : Form
    {
        public FrmAddNewEmplyoyee()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            FrmAddEmployee form16 = new FrmAddEmployee();
            form16.Show();
            this.Close();
        }
    }
}
