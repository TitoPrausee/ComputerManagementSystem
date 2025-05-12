using System;
using System.Windows.Forms;

namespace ComputerManagement3
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Benutzername und Passwort dürfen nicht leer sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var connector = new Connector("Host=217.160.76.103;Port=5432;Database=jomi;Username=jomi;Password=init123$;");

                // Überprüfen, ob der Benutzername bereits existiert
                string checkQuery = $"SELECT COUNT(*) FROM login WHERE username = '{username.Replace("'", "''")}'";
                int userCount = Convert.ToInt32(connector.ExecuteScalar(checkQuery));

                if (userCount > 0)
                {
                    MessageBox.Show("Der Benutzername existiert bereits.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Benutzer einfügen (ohne die Spalte "id")
                string query = $"INSERT INTO login (username, password, created_at) VALUES ('{username.Replace("'", "''")}', '{password.Replace("'", "''")}', NOW())";
                connector.ExecuteQuery(query);

                MessageBox.Show("Nutzer erfolgreich hinzugefügt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Hinzufügen des Nutzers: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AddUser_Load(object sender, EventArgs e)
        {
            // Optional: Initialisierungslogik hier hinzufügen
        }
        private new void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
