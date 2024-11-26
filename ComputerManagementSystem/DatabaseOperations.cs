using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class DatabaseOperations
{
    // Korrigierte Verbindungszeichenfolge
    private string connectionString = "Server=localhost;Database=computermanagementsystem;Uid=Tiberius;Pwd=123456;";

    public List<ComputerSystem> GetComputerSystems()
    {
        List<ComputerSystem> systems = new List<ComputerSystem>();
        string query = "SELECT Id, Name, IPAddress, OperatingSystem, LastUpdated, Motherboard, GPU, RAM, Storage FROM ComputerSystems";

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ComputerSystem system = new ComputerSystem
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                IPAddress = reader.GetString(2),
                                OperatingSystem = reader.GetString(3),
                                LastUpdated = reader.GetDateTime(4),
                                Motherboard = reader.GetString(5),
                                GPU = reader.GetString(6),
                                RAM = reader.GetInt32(7),
                                Storage = reader.GetInt32(8)
                            };
                            systems.Add(system);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Fehlerbehandlung für MySQL-spezifische Fehler
                Console.WriteLine("MySQL Fehler: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Allgemeine Fehlerbehandlung
                Console.WriteLine("Allgemeiner Fehler: " + ex.Message);
            }
        }

        return systems;
    }
}