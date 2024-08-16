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
    public partial class FrmViewPayments : Form
    {
        public FrmViewPayments()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string appointmentId = Appoint2txt.Text;

            if (string.IsNullOrEmpty(appointmentId))
            {
                MessageBox.Show("Please enter an Appointment ID.");
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-4GLGIVD\\SQLEXPRESS;Initial Catalog=CarWash_DB;Integrated Security=True;"))
                {
                    con.Open();
                    string query = "SELECT a.appointmentId, c.name, s.serviceName, s.servicePrice " +
                                   "FROM Appointment a " +
                                   "JOIN Service s ON a.serviceId = s.serviceId " +
                                   "JOIN AddCustomer c ON a.nic = c.nic"; // Adjust this join according to your schema

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Debugging: Output the number of rows fetched
                        MessageBox.Show("Number of rows fetched: " + dataTable.Rows.Count);

                        // Ensure the DataGridView is properly bound
                        paymentGridView.DataSource = dataTable;
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No records found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void Backbtn_Click(object sender, EventArgs e)
        {
            FrmAddEmployee form17 = new FrmAddEmployee();
            form17.Show();
            this.Close();
        }
    }
}
