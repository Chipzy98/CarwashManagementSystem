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
    public partial class FrmAddEmployee : Form
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            FrmCarWash form13 = new FrmCarWash();
            form13.Show();
            this.Close();
        }

        private void addEmpbtn_Click(object sender, EventArgs e)
        {
            FrmAddNewEmplyoyee form15 = new FrmAddNewEmplyoyee();
            form15.Show();
            this.Close();
        }
    }
}
