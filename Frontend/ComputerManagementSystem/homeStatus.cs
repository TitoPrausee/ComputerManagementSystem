using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace ComputerManagementSystem
{
    public partial class homeStatus : Form
    {
        public homeStatus()
        {
            InitializeComponent();
        }

        private void homeStatus_Load(object sender, EventArgs e)
        {
            UpdateConnectionStatus();
        }

        private void UpdateConnectionStatus()
        {
            using (var connection = new NpgsqlConnection(DatabaseConfig.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    SetConnectionStatus(true);
                }
                catch (Exception)
                {
                    SetConnectionStatus(false);
                }
            }
        }

        private void SetConnectionStatus(bool isConnected)
        {
            if (isConnected)
            {
                panelRed.BackColor = Color.Gray;
                panelYellow.BackColor = Color.Gray;
                panelGreen.BackColor = Color.Green;
            }
            else
            {
                panelRed.BackColor = Color.Red;
                panelYellow.BackColor = Color.Gray;
                panelGreen.BackColor = Color.Gray;
            }
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddEllipse(0, 0, panel.Width, panel.Height);
                panel.Region = new Region(path);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connectionString = DatabaseConfig.GetConnectionString();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM login WHERE username=@username AND password=@password";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        // Login successful, open the next form
                        New  nextForm = new New(); // Replace NextForm with the actual form you want to open
                        nextForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Login failed, show error message
                        MessageBox.Show("Username or Password is incorrect.");
                    }
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    // Add the missing NextForm class
    public class NextForm : Form
    {
        public NextForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Initialize components for NextForm
        }
    }
}
