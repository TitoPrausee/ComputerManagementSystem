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
            string query = "SELECT cpu_name, cpu_processor_id, hdd_serial_number, hdd_capacity, hdd_type, ram_serial_number, ram_size, motherboard_serial, gpu_name, monitor_port FROM hardware_info";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ComputerSystem system = new ComputerSystem
                            {
                                CpuName = reader.GetString(0),
                                CpuProcessorId = reader.GetString(1),
                                HddSerialNumber = reader.GetString(2),
                                HddCapacity = reader.GetInt32(3),
                                HddType = reader.GetString(4),
                                RamSerialNumber = reader.GetString(5),
                                RamSize = reader.GetInt32(6),
                                MotherboardSerial = reader.GetString(7),
                                GpuName = reader.GetString(8),
                                MonitorPort = reader.GetString(9)
                            };
                            systems.Add(system);
                        }
                    }
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