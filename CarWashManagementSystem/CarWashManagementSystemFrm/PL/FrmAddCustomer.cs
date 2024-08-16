using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarWashManagementSystem
{
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void Nametxt_TextChanged(object sender, EventArgs e) { }
        private void Nictxt_TextChanged(object sender, EventArgs e) { }
        private void Mobiletxt_TextChanged(object sender, EventArgs e) { }
        private void Emailtxt_TextChanged(object sender, EventArgs e) { }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            FrmCarWash form = new FrmCarWash();
            form.Show();
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-4GLGIVD\\SQLEXPRESS;Initial Catalog=CarWash_DB;Integrated Security=True;"))
                {
                    con.Open();
                    // Assuming 'id' is not an identity column and you need to insert a value for it.
                    // Ensure you have a datetime column like 'created_at' for storing the current date and time.
                    string query = "INSERT INTO AddCustomer (nic, name, mobile, email) VALUES ( @nic, @name, @mobile, @email)";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        // Add parameters for each value
                        command.Parameters.AddWithValue("@nic", Nictxt.Text);
                        command.Parameters.AddWithValue("@name", Nametxt.Text);
                        command.Parameters.AddWithValue("@mobile", Mobiletxt.Text);
                        command.Parameters.AddWithValue("@email", Emailtxt.Text);

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
            Nictxt.Text = string.Empty;
            Nametxt.Text = string.Empty;
            Mobiletxt.Text = string.Empty;
            Emailtxt.Text = string.Empty;
        }
    }
}
