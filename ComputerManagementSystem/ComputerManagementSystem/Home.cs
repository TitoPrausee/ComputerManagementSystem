using System;
using System.Windows.Forms;

namespace ComputerManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Hier kannst du Code hinzufügen, der beim Laden der Startseite ausgeführt werden soll.
        }

        private void btnBenutzerverwaltung_Click(object sender, EventArgs e)
        {
            // Hier kannst du das Benutzerverwaltungsformular öffnen.
            Benutzerverwaltung benutzerVerwaltung = new Benutzerverwaltung();
            benutzerVerwaltung.Show();
            this.Hide(); // Optional: Verstecken der Startseite
        }

        private void btnPCVerwaltung_Click(object sender, EventArgs e)
        {
            // Hier kannst du das PC-Verwaltungsformular öffnen.
            PCVerwaltung pcVerwaltung = new PCVerwaltung();
            pcVerwaltung.Show();
            this.Hide(); // Optional: Verstecken der Startseite
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Hier kannst du die Anmelde-Logik implementieren.
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login erfolgreich!");
                ShowMainApplication();
            }
            else
            {
                lblMessage.Text = "Ungültiger Benutzername oder Passwort.";
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Implementiere hier deine Authentifizierungslogik.
            // Zum Beispiel: Überprüfen gegen eine Datenbank oder eine vordefinierte Liste.
            return username == "admin" && password == "password"; // Beispielüberprüfung
        }

        private void ShowMainApplication()
        {
            // Hier kannst du die Hauptanwendungsfunktionen anzeigen.
            // Zum Beispiel: Zeige Benutzerverwaltung und PC-Verwaltung.
            btnBenutzerverwaltung.Visible = true;
            btnPCVerwaltung.Visible = true;
            txtUsername.Visible = false;
            txtPassword.Visible = false;
            btnLogin.Visible = false;
            lblMessage.Visible = false;
        }
    }
}