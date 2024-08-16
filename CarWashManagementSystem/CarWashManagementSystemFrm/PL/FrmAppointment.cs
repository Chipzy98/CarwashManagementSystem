using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace CarWashManagementSystem
{
    public partial class FrmAppointment : Form
    {
        public FrmAppointment()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            // Clear all text boxes
            Appointtxt.Text = string.Empty;
            Nic1txt.Text = string.Empty;
            Cusnametxt.Text = string.Empty;
            Mnum1txt.Text = string.Empty;
            Email1txt.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            comboBoxService.Items.Clear();  
        }

        private void Appointtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            FrmCustomer form3 = new FrmCustomer();
            form3.Show();
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-4GLGIVD\\SQLEXPRESS;Initial Catalog=CarWash_DB;Integrated Security=True;"))
                {
                    con.Open();
                    string query = "INSERT INTO Appointment (appointmentId, nic, cusName, mobile, email, appDateTime, serviceId) " +
                                   "VALUES (@appointmentId, @nic, @cusName, @mobile, @email, @appDateTime, @serviceId)";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@appointmentId", Appointtxt.Text);
                        command.Parameters.AddWithValue("@nic", Nic1txt.Text);
                        command.Parameters.AddWithValue("@cusName", Cusnametxt.Text);
                        command.Parameters.AddWithValue("@mobile", Mnum1txt.Text);
                        command.Parameters.AddWithValue("@email", Email1txt.Text);
                        command.Parameters.AddWithValue("@appDateTime", dateTimePicker1.Value);

                        var selectedService = comboBoxService.SelectedItem;
                        if (selectedService != null)
                        {
                            command.Parameters.AddWithValue("@serviceId", ((dynamic)selectedService).Value);
                        }
                        else
                        {
                            throw new Exception("Please select a service.");
                        }

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


        private void comboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedService = comboBoxService.SelectedItem;
            if (selectedService != null)
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-4GLGIVD\\SQLEXPRESS;Initial Catalog=CarWash_DB;Integrated Security=True;"))
                {
                    con.Open();
                    string query = "SELECT servicePrice FROM Service WHERE serviceId = @serviceId";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@serviceId", ((dynamic)selectedService).Value);
                        var price = command.ExecuteScalar();
                        if (price != null)
                        {
                            lblServicePrice.Text = $"Price: ${price.ToString()}";
                        }
                    }
                }
            }
        }

        private void FrmAppointment_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-4GLGIVD\\SQLEXPRESS;Initial Catalog=CarWash_DB;Integrated Security=True;"))
            {
                con.Open();
                string query = "SELECT serviceId, serviceName FROM Service";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxService.Items.Add(new { Text = reader["serviceName"].ToString(), Value = reader["serviceId"].ToString() });
                    }
                    comboBoxService.DisplayMember = "Text";
                    comboBoxService.ValueMember = "Value";
                }
            }
        }
    }
}
