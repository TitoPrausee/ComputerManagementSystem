using Npgsql; // Verwenden Sie Npgsql für PostgreSQL
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComputerManagementSystem
{
    public class DatabaseOperations
    {
        private string connectionString;

        public DatabaseOperations()
        {
            connectionString = DatabaseConfig.GetConnectionString();
        }

        // Methode zum Abrufen der Hardwareinformationen
        public List<ComputerSystem> GetHardwareInfo()
        {
            List<ComputerSystem> systems = new List<ComputerSystem>();
            string query = @"SELECT cpu.cpu_name                         AS CpuName,
       cpu.cpu_processor_id::text           AS CpuProcessorId,
       disk.hdd_serial_number::text          AS HddSerialNumber,
       disk.hdd_capacity                     AS HddCapacity,
       disk.hdd_type                         AS HddType,
       ram.ram_serial_number::text          AS RamSerialNumber,
       ram.ram_size                         AS RamSize,
       motherboard.motherboard_serial::text AS MotherboardSerial,
       gpu.gpu_name                         AS GpuName,
       monitor.monitor_port                 AS MonitorPort
FROM ComputerManagement.hardware_info AS hw
         LEFT JOIN 
    computermanagement.disk disk on hw.id = disk.hardware_info_id
         LEFT JOIN
     ComputerManagement.cpu AS cpu ON hw.cpu_id = cpu.id
         LEFT JOIN
     ComputerManagement.ram AS ram ON hw.id = ram.hardware_info_id
         LEFT JOIN
     ComputerManagement.motherboard AS motherboard ON hw.motherboard_id = motherboard.id
         LEFT JOIN
     ComputerManagement.gpu AS gpu ON hw.gpu_id = gpu.id
         LEFT JOIN
     ComputerManagement.monitor AS monitor ON hw.id = monitor.hardware_info_id;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    string cpuName = reader.GetString(0);
                                    string cpuProcessorId = reader.GetString(1);
                                    string hddSerialNumber = reader.GetString(2);
                                    int hddCapacity = reader.GetInt32(3);
                                    string hddType = reader.GetString(4);
                                    string ramSerialNumber = reader.GetString(5);
                                    int ramSize = reader.GetInt32(6);
                                    string motherboardSerial = reader.GetString(7);
                                    string gpuName = reader.GetString(8);
                                    string monitorPort = reader.GetString(9);

                                    ComputerSystem system = new ComputerSystem
                                    {
                                        CpuName = cpuName,
                                        CpuProcessorId = cpuProcessorId,
                                        HddSerialNumber = hddSerialNumber,
                                        HddCapacity = hddCapacity,
                                        HddType = hddType,
                                        RamSerialNumber = ramSerialNumber,
                                        RamSize = ramSize,
                                        MotherboardSerial = motherboardSerial,
                                        GpuName = gpuName,
                                        MonitorPort = monitorPort
                                    };
                                    systems.Add(system);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Fehler beim Lesen der Daten: {ex.Message}", "Lesefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    MessageBox.Show("Daten erfolgreich geladen.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show($"Fehler beim Abrufen der Daten: {ex.Message}", "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Allgemeiner Fehler: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return systems;
        }

        // Methode zum Einfügen eines neuen Motherboards
        public int InsertMotherboard(string motherboardSerial)


        {
            string query = @"INSERT INTO ComputerManagement.motherboard (motherboard_serial) 
                     VALUES (@motherboardSerial) RETURNING id";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("motherboardSerial", motherboardSerial);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        // Methode zum Einfügen einer neuen GPU
        public int InsertGpu(string gpuName)
        {
            string query = @"INSERT INTO ComputerManagement.gpu (gpu_name) 
                     VALUES (@gpuName) RETURNING id";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("gpuName", gpuName);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        // Methode zum Einfügen eines neuen Geräts
        public void InsertNewComputerSystem(int cpuId, int gpuId, int motherboardId)
        {
            string query = @"INSERT INTO ComputerManagement.hardware_info (cpu_id, gpu_id, motherboard_id)
                     VALUES (@cpuId, @gpuId, @motherboardId)";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("cpuId", cpuId);
                        command.Parameters.AddWithValue("gpuId", gpuId);
                        command.Parameters.AddWithValue("motherboardId", motherboardId);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Neues Gerät erfolgreich hinzugefügt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show($"Fehler beim Einfügen der Daten: {ex.Message}", "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Allgemeiner Fehler: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Methode zum Abrufen der CPU-ID
        public int GetCpuId(string cpuName, string cpuProcessorId)
        {
            string query = @"SELECT id FROM ComputerManagement.cpu WHERE cpu_name = @cpuName AND cpu_processor_id = @cpuProcessorId";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("cpuName", cpuName);
                    command.Parameters.AddWithValue("cpuProcessorId", cpuProcessorId);
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; // -1 bedeutet nicht gefunden
                }
            }
        }

        // Methode zum Abrufen der GPU-ID
        public int GetGpuId(string gpuName)
        {
            string query = @"SELECT id FROM ComputerManagement.gpu WHERE gpu_name = @gpuName";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("gpuName", gpuName);
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; // -1 bedeutet nicht gefunden
                }
            }
        }

        // Methode zum Abrufen der Motherboard-ID
        public int GetMotherboardId(string motherboardSerial)
        {
            string query = @"SELECT id FROM ComputerManagement.motherboard WHERE motherboard_serial = @motherboardSerial";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("motherboardSerial", motherboardSerial);
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; // -1 bedeutet nicht gefunden
                }
            }
        }

        // Methode zum Einfügen einer neuen CPU
        public int InsertCpu(string cpuName, string cpuProcessorId)
        {
            string query = @"INSERT INTO ComputerManagement.cpu (cpu_name, cpu_processor_id) 
                             VALUES (@cpuName, @cpuProcessorId) RETURNING id";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("cpuName", cpuName);
                    command.Parameters.AddWithValue("cpuProcessorId", cpuProcessorId);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }
    }
}