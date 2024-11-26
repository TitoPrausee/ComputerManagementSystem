using System;
using System.Drawing;
using System.Windows.Forms;
 

namespace ComputerManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SetPlaceholderText();
        }

        private void SetPlaceholderText()
        {
            // Platzhaltertext für Benutzername
            txtUsername.Text = "Benutzername";
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Text = "Benutzername";
                    txtUsername.ForeColor = Color.Gray;
                }
            };
            txtUsername.Enter += (s, e) => {
                if (txtUsername.Text == "Benutzername")
                {
                    txtUsername.Text = "";
                    txtUsername.ForeColor = Color.Black;
                }
            };

            // Platzhaltertext für Passwort
            txtPassword.Text = "Passwort";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false; // Zeige den Platzhaltertext an
            txtPassword.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.Text = "Passwort";
                    txtPassword.ForeColor = Color.Gray;
                    txtPassword.UseSystemPasswordChar = false; // Zeige den Platzhaltertext an
                }
            };
            txtPassword.Enter += (s, e) => {
                if (txtPassword.Text == "Passwort")
                {
                    txtPassword.Text = "";
                    txtPassword.ForeColor = Color.Black;
                    txtPassword.UseSystemPasswordChar = true; // Verstecke das Passwort
                }
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            DatabaseOperations db = new DatabaseOperations();
            User user = db.AuthenticateUser(username, password);

            if (user != null)
            {
                MessageBox.Show("Willkommen, " + user.Username + "!");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); // Schließe das Login-Formular
            }
            else
            {
                MessageBox.Show("Ungültiger Benutzername oder Passwort.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Hier kannst du Code hinzufügen, der beim Laden des Formulars ausgeführt werden soll
        }
    }
}