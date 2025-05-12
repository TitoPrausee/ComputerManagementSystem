using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace ComputerManagement3
{
    public partial class Add : Form
    {
        private readonly string hardwareTable; // Non-Nullable-Feld mit Standardwert initialisieren
        private readonly Connector connector; // Instanz der Connector-Klasse
        private int currentIndex = 0; // Index für das aktuelle Textfeld
        private Guna2TextBox[] textBoxes; // Array für die Textfelder

        public Add()
        {
            hardwareTable = "hardware_info"; // Initialisierung des Non-Nullable-Felds
            connector = new Connector("Host=217.160.76.103;Port=5432;Database=jomi;Username=jomi;Password=init123$;"); // Verbindung konfigurieren
            InitializeComponent();

            // Initialisiere das Array mit den Textfeldern, die den tatsächlichen Tabellenspalten entsprechen
            textBoxes = new Guna2TextBox[]
            {
                txtCpuName,
                txtCpuProcessorId,
                txtHddSerialNumber,
                txtHddCapacity,
                txtHddType,
                txtRamSerialNumber,
                txtRamSize,
                txtMotherboardSerial,
                txtGpuName,
                txtMonitorPort
            };

            // Zeige nur das erste Textfeld an
            foreach (var textBox in textBoxes)
            {
                textBox.Visible = false;
            }
            textBoxes[currentIndex].Visible = true;

            // Der Zurück-Button ist standardmäßig unsichtbar
            btnBack.Visible = false;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // Prüfe, ob das aktuelle Textfeld ausgefüllt ist
            if (string.IsNullOrWhiteSpace(textBoxes[currentIndex].Text))
            {
                MessageBox.Show("Bitte füllen Sie das Feld aus, bevor Sie fortfahren.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Blende das aktuelle Textfeld aus
            textBoxes[currentIndex].Visible = false;
            currentIndex++;

            if (currentIndex < textBoxes.Length)
            {
                // Zeige das nächste Textfeld an
                textBoxes[currentIndex].Visible = true;

                // Zeige den Zurück-Button an, wenn wir nicht mehr beim ersten Textfeld sind
                btnBack.Visible = true;
            }
            else
            {
                // Wenn alle Textfelder durchlaufen sind, zeige den Speichern-Button an
                btnNext.Visible = false;
                btnSave.Visible = true;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Blende das aktuelle Textfeld aus
            textBoxes[currentIndex].Visible = false;
            currentIndex--;

            // Zeige das vorherige Textfeld an
            textBoxes[currentIndex].Visible = true;

            // Blende den Speichern-Button aus, wenn wir nicht mehr beim letzten Textfeld sind
            btnSave.Visible = false;
            btnNext.Visible = true;

            // Blende den Zurück-Button aus, wenn wir beim ersten Textfeld sind
            if (currentIndex == 0)
            {
                btnBack.Visible = false;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // SQL-Abfrage zum Einfügen der Daten
                string query = $"INSERT INTO {hardwareTable} (cpu_name, cpu_processor_id, hdd_serial_number, hdd_capacity, hdd_type, ram_serial_number, ram_size, motherboard_serial, gpu_name, monitor_port) " +
                               "VALUES (@CpuName, @CpuProcessorId, @HddSerialNumber, @HddCapacity, @HddType, @RamSerialNumber, @RamSize, @MotherboardSerial, @GpuName, @MonitorPort)";

                using (var connection = connector.GetConnection())
                {
                    using (var command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        // Parameter hinzufügen
                        command.Parameters.AddWithValue("@CpuName", txtCpuName.Text);
                        command.Parameters.AddWithValue("@CpuProcessorId", txtCpuProcessorId.Text);
                        command.Parameters.AddWithValue("@HddSerialNumber", txtHddSerialNumber.Text);
                        command.Parameters.AddWithValue("@HddCapacity", txtHddCapacity.Text);
                        command.Parameters.AddWithValue("@HddType", txtHddType.Text);
                        command.Parameters.AddWithValue("@RamSerialNumber", txtRamSerialNumber.Text);
                        command.Parameters.AddWithValue("@RamSize", txtRamSize.Text);
                        command.Parameters.AddWithValue("@MotherboardSerial", txtMotherboardSerial.Text);
                        command.Parameters.AddWithValue("@GpuName", txtGpuName.Text);
                        command.Parameters.AddWithValue("@MonitorPort", txtMonitorPort.Text);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Daten erfolgreich hinzugefügt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Schließt die Form nach erfolgreichem Speichern
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Hinzufügen der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close(); // Schließt die Form
        }
    }
}
