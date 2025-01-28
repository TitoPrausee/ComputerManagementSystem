using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;
using ComputerManagementSystem;
using ComputerManagementSystem.Forms; // Add this using directive

namespace ComputerManagementSystem
{
    public partial class MainForm : Form
    {
        private DatabaseOperations dbOperations;
        private PictureBox pictureBox; // PictureBox-Variable hinzufügen

        public MainForm()
        {
            InitializeComponent();
            dbOperations = new DatabaseOperations();
            pictureBox = new PictureBox(); // PictureBox initialisieren

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Willkommen im Computer Management System!", "Willkommen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadComputerSystems();
        }

        private void LoadComputerSystems()
        {
            try
            {
                MessageBox.Show("Lade Daten, bitte warten...", "Laden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<ComputerSystem> systems = dbOperations.GetHardwareInfo();
                listViewComputerSystems.Items.Clear(); // Alte Einträge löschen

                foreach (var system in systems)
                {
                    ListViewItem item = new ListViewItem(system.CpuName);
                    item.SubItems.Add(system.CpuProcessorId);
                    item.SubItems.Add(system.HddSerialNumber);
                    item.SubItems.Add(system.HddCapacity.ToString()); // Konvertieren in String
                    item.SubItems.Add(system.HddType);
                    item.SubItems.Add(system.RamSerialNumber);
                    item.SubItems.Add(system.RamSize.ToString()); // Konvertieren in String
                    item.SubItems.Add(system.MotherboardSerial);
                    item.SubItems.Add(system.GpuName);
                    item.SubItems.Add(system.MonitorPort);
                    listViewComputerSystems.Items.Add(item);
                }

                MessageBox.Show("Daten erfolgreich geladen.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Datenbankfehler: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Allgemeiner Fehler: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadComputerSystems();
        }

        private void listViewComputerSystems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event-Handler für die Auswahländerung im ListView
            if (listViewComputerSystems.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewComputerSystems.SelectedItems[0];
                string cpuName = selectedItem.SubItems[0].Text;
                // Hier kannst du weitere Aktionen basierend auf der Auswahl durchführen
                MessageBox.Show($"Ausgewähltes System: {cpuName}", "Auswahl", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoadData_Click_1(object sender, EventArgs e)
        {
            LoadComputerSystems();
        }

        private void openAddScrean_Click(object sender, EventArgs e)
        {
            New newForm = new New();
            newForm.Show();
            this.Hide();
        }
    }
}
