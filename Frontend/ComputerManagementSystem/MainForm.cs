using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ComputerManagementSystem;

namespace ComputerManagementSystem
{
    public partial class MainForm : Form
    {
        private DatabaseOperations dbOperations;

        public MainForm()
        {
            InitializeComponent();
            dbOperations = new DatabaseOperations();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadComputerSystems();
        }

        private void LoadComputerSystems()
        {
            try
            {
                // Stelle sicher, dass die Liste korrekt deklariert ist
                List<ComputerSystem> systems = dbOperations.GetComputerSystems();
                listViewComputerSystems.Items.Clear(); // Clear existing items

                foreach (var system in systems)
                {
                    ListViewItem item = new ListViewItem(system.Name);
                    item.SubItems.Add(system.IPAddress);
                    item.SubItems.Add(system.OperatingSystem);
                    item.SubItems.Add(system.LastUpdated.ToString());
                    item.SubItems.Add(system.Motherboard);
                    item.SubItems.Add(system.GPU);
                    item.SubItems.Add(system.RAM.ToString());
                    item.SubItems.Add(system.Storage.ToString());
                    listViewComputerSystems.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Daten: " + ex.Message);
            }
        }

        private void listViewComputerSystems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event-Handler für die Auswahländerung im ListView
        }
    }
}