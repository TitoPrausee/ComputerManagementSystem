using System;
using System.Windows.Forms;

namespace ComputerManagementSystem
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            // Hier kannst du Initialisierungen für die Benutzer- und PC-Verwaltung vornehmen.
        }

        private void btnUser Management_Click(object sender, EventArgs e)
        {
            // Logik zur Benutzerverwaltung
            MessageBox.Show("Benutzerverwaltung geöffnet.");
            // Hier kannst du ein neues Formular für die Benutzerverwaltung öffnen
            // oder die Benutzerverwaltung im aktuellen Formular implementieren.
        }

        private void btnPCManagement_Click(object sender, EventArgs e)
        {
            // Logik zur PC-Verwaltung
            MessageBox.Show("PC-Verwaltung geöffnet.");
            // Hier kannst du ein neues Formular für die PC-Verwaltung öffnen
            // oder die PC-Verwaltung im aktuellen Formular implementieren.
        }
    }
}