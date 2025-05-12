using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace ComputerManagement3
{
    public partial class MAin : Form
    {
        private DataTable hardwareTable;

        public MAin()
        {
            InitializeComponent();
        }

        private void MAin_Load(object sender, EventArgs e)
        {
            var connector = new Connector("Host=217.160.76.103;Port=5432;Database=jomi;Username=jomi;Password=init123$;");
            string query = "SELECT cpu_name, cpu_processor_id, hdd_serial_number, hdd_capacity, hdd_type, ram_serial_number, ram_size, motherboard_serial, gpu_name, monitor_port FROM hardware_info";
            hardwareTable = connector.GetDataTable(query);
            guna2DataGridView1.AutoGenerateColumns = true;
            guna2DataGridView1.DataSource = hardwareTable;
        }

        private void btnSuche_Click(object sender, EventArgs e)
        {
            string filter = txtSuche.Text.Replace("'", "''");
            hardwareTable.DefaultView.RowFilter =
                $"cpu_name LIKE '%{filter}%' OR gpu_name LIKE '%{filter}%' OR cpu_processor_id LIKE '%{filter}%' OR hdd_serial_number LIKE '%{filter}%'";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(); // Instanziiere die Add-Form
            addForm.ShowDialog(); // Öffne die Add-Form als modales Fenster
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnExportCsv_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Es gibt keine Daten zum Exportieren.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Sortiere die Daten nach einer bestimmten Spalte (z. B. cpu_name)
            hardwareTable.DefaultView.Sort = "cpu_name ASC"; // Sortiere nach der Spalte 'cpu_name' aufsteigend
            DataTable sortedTable = hardwareTable.DefaultView.ToTable();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV-Datei (*.csv)|*.csv";
                saveFileDialog.Title = "Speicherort für CSV-Datei auswählen";
                saveFileDialog.FileName = "Export.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Spaltenüberschriften schreiben
                            for (int i = 0; i < sortedTable.Columns.Count; i++)
                            {
                                writer.Write($"\"{sortedTable.Columns[i].ColumnName}\"");
                                if (i < sortedTable.Columns.Count - 1)
                                    writer.Write(",");
                            }
                            writer.WriteLine();

                            // Zeilen schreiben
                            foreach (DataRow row in sortedTable.Rows)
                            {
                                for (int i = 0; i < sortedTable.Columns.Count; i++)
                                {
                                    writer.Write($"\"{row[i]?.ToString()}\"");
                                    if (i < sortedTable.Columns.Count - 1)
                                        writer.Write(",");
                                }
                                writer.WriteLine();
                            }
                        }

                        MessageBox.Show("Daten erfolgreich exportiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler beim Exportieren der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser(); // Neues Formular für Nutzer
            addUserForm.ShowDialog(); // Öffne das Formular als modales Fenster
        }


    }
}
