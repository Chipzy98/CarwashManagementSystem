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
    public partial class FrmCardPayment : Form
    {
        public FrmCardPayment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            FrmPayment form9 = new FrmPayment();
            form9.Show();
            this.Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string appointmentId = Appoint1txt.Text;

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
                    string query = "SELECT a.appointmentId, s.serviceName AS ServiceType, s.servicePrice " +
                                   "FROM Appointment a " +
                                   "JOIN Service s ON a.serviceId = s.serviceId";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Debugging: Output the number of rows fetched
                        MessageBox.Show("Number of rows fetched: " + dataTable.Rows.Count);

                        // Ensure the DataGridView is properly bound
                        cashPaymenttbl.DataSource = dataTable;
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

        private void Paybtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Successful");
            Appoint1txt.Text = string.Empty;
        }
    }
}
