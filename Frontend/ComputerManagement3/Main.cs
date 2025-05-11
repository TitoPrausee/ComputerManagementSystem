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
    }
}
