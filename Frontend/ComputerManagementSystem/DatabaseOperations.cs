using Npgsql; // Verwenden Sie Npgsql für PostgreSQL
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComputerManagementSystem
{
    public class DatabaseOperations
    {
        private string connectionString = "Host=217.160.76.103;Port=5432;Database=jomi;Username=jomi;Password=init123$;";

        // Methode zum Abrufen der Hardwareinformationen
        public List<ComputerSystem> GetHardwareInfo()
        {
            List<ComputerSystem> systems = new List<ComputerSystem>();
            string query = @"
            SELECT 
                cpu.cpu_name, 
                cpu.cpu_processor_id::text,  -- Konvertiere in String
                hdd.hdd_serial_number::text,  -- Konvertiere in String
                hdd.hdd_capacity::text,        -- Konvertiere in String
                hdd.hdd_type, 
                ram.ram_serial_number::text,   -- Konvertiere in String
                ram.ram_size::text,            -- Konvertiere in String
                motherboard.motherboard_serial::text,  -- Konvertiere in String
                gpu.gpu_name, 
                monitor.monitor_port 
            FROM 
                ComputerManagement.hardware_info AS hw
            JOIN 
                ComputerManagement.cpu AS cpu ON hw.cpu_processor_id = cpu.cpu_processor_id
            JOIN 
                ComputerManagement.hdd AS hdd ON hw.hdd_serial_number = hdd.hdd_serial_number
            JOIN 
                ComputerManagement.ram AS ram ON hw.ram_serial_number = ram.ram_serial_number
            JOIN 
                ComputerManagement.motherboard AS motherboard ON hw.motherboard_serial = motherboard.motherboard_serial
            JOIN 
                ComputerManagement.gpu AS gpu ON hw.id = gpu.hardware_info_id
            JOIN 
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
                                ComputerSystem system = new ComputerSystem
                                {
                                    CpuName = reader.GetString(0),
                                    CpuProcessorId = reader.GetString(1), // Hier als String
                                    HddSerialNumber = reader.GetString(2), // Hier als String
                                    HddCapacity = reader.GetString(3), // Hier als String
                                    HddType = reader.GetString(4),
                                    RamSerialNumber = reader.GetString(5), // Hier als String
                                    RamSize = reader.GetString(6), // Hier als String
                                    MotherboardSerial = reader.GetString(7), // Hier als String
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

        // Methode zur Authentifizierung eines Benutzers
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

    // Benutzerklasse zur Speicherung der Benutzerdaten
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}