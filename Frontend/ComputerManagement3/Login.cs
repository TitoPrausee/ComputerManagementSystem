using System;
using System.Windows.Forms;
using Npgsql;

namespace ComputerManagement3
{
    public partial class Login : Form
    {
        private bool passwortSichtbar = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Passwort.PasswordChar = '●'; // Passwort wird als Punkt angezeigt
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            // Optional: Logik bei Namensänderung
        }

        private void Passwort_TextChanged(object sender, EventArgs e)
        {
            // Optional: Logik bei Passwortänderung
        }

        private void Weiter_Click(object sender, EventArgs e)
        {
            string benutzername = Name.Text;
            string passwort = Passwort.Text;

            var connector = new Connector("Host=217.160.76.103;Port=5432;Database=jomi;Username=jomi;Password=init123$;");

            try
            {
                using (var connection = connector.GetConnection())
                {
                    // 1. Prüfen, ob der Benutzername existiert
                    string userQuery = "SELECT COUNT(*) FROM login WHERE username = @username";
                    using (var userCmd = new NpgsqlCommand(userQuery, connection))
                    {
                        userCmd.Parameters.AddWithValue("@username", benutzername);
                        int userCount = Convert.ToInt32(userCmd.ExecuteScalar());

                        if (userCount == 0)
                        {
                            MessageBox.Show("Benutzername unbekannt.");
                            return;
                        }
                    }

                    // 2. Prüfen, ob das Passwort zum Benutzernamen passt
                    string pwQuery = "SELECT COUNT(*) FROM login WHERE username = @username AND password = @password";
                    using (var pwCmd = new NpgsqlCommand(pwQuery, connection))
                    {
                        pwCmd.Parameters.AddWithValue("@username", benutzername);
                        pwCmd.Parameters.AddWithValue("@password", passwort);

                        int pwCount = Convert.ToInt32(pwCmd.ExecuteScalar());
                        if (pwCount > 0)
                        {
                            MessageBox.Show("Login erfolgreich!");
                            // Main-Form öffnen und Login-Form schließen
                            MAin mainForm = new MAin();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Passwort falsch.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Anmeldung: " + ex.Message);
            }
        }

        // Der folgende Event-Handler ist optional und kann entfernt werden, wenn kein Auge-Button verwendet wird.
        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            passwortSichtbar = !passwortSichtbar;
            Passwort.PasswordChar = passwortSichtbar ? '\0' : '●';
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
