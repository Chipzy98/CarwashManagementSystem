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
        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-4GLGIVD\\SQLEXPRESS;Initial Catalog=CarWash_DB;Integrated Security=True;"))
                {
                    con.Open();
                    string query = "SELECT a.appointmentId, a.appDateTime, s.serviceName " +
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
                        viewServiceHistorytbl.DataSource = dataTable;
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


    }
}
