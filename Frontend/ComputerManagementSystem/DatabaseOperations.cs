using Npgsql; // Verwenden Sie Npgsql für PostgreSQL
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComputerManagementSystem
{
    public class DatabaseOperations
    {
        private string connectionString = "Host=217.160.76.103;Port=5432;Database=jomi;Username=jomi;Password=init123$;";

        public List<ComputerSystem> GetHardwareInfo()
        {
            List<ComputerSystem> systems = new List<ComputerSystem>();
            string query = "SELECT cpu_name, cpu_processor_id, hdd_serial_number, hdd_capacity, hdd_type, ram_serial_number, ram_size, motherboard_serial, gpu_name, monitor_port FROM hardware_info";

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
                                ComputerSystem system = new ComputerSystem
                                {
                                    CpuName = reader.GetString(0),
                                    CpuProcessorId = reader.GetString(1),
                                    HddSerialNumber = reader.GetString(2),
                                    HddCapacity = reader.GetString(3),
                                    HddType = reader.GetString(4),
                                    RamSerialNumber = reader.GetString(5),
                                    RamSize = reader.GetString(6),
                                    MotherboardSerial = reader.GetString(7),
                                    GpuName = reader.GetString(8),
                                    MonitorPort = reader.GetString(9)
                                };
                                systems.Add(system);
                            }
                        }
                    }
                    MessageBox.Show("Daten erfolgreich geladen.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Fehler beim Abrufen der Daten: " + ex.Message, "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Allgemeiner Fehler: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return systems;
        }

        public User AuthenticateUser(string username, string password)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Username FROM users WHERE username = @username AND password = @password";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = reader.GetInt32(0),
                                Username = reader.GetString(1)
                            };
                        }
                        else
                        {
                            return null; // Benutzer nicht gefunden
                        }
                    }
                }
            }
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}