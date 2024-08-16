using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-4GLGIVD\\SQLEXPRESS;Initial Catalog=CarWash_DB;Integrated Security=True;"))
                {
                    con.Open();
                    string query = "INSERT INTO AddEmployee (employeeId, name, role, contactInfo) VALUES ( @employeeId, @name, @role, @contactInfo)";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        // Add parameters for each value
                        command.Parameters.AddWithValue("@employeeId", empIdtxt.Text);
                        command.Parameters.AddWithValue("@name", empNametxt.Text);
                        command.Parameters.AddWithValue("@role", roletxt.Text);
                        command.Parameters.AddWithValue("@contactInfo", contactNumtxt.Text);
                        

                        // Execute the command
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Inserted");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            // Clear all text boxes
            empIdtxt.Text = string.Empty;
            empNametxt.Text = string.Empty;
            roletxt.Text = string.Empty;
            contactNumtxt.Text = string.Empty;
        }
    }
}
