// DatabaseOperations.cs
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
     ComputerManagement.monitor AS monitor ON hw.id = monitor.hardware_info_id;
";

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
    }
}