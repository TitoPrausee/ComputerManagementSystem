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

    // Methode zur Authentifizierung eines Benutzers
    public User AuthenticateUser(string username, string password)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM users WHERE username = @username AND password = @password";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password); // Beachte: Passwörter sollten gehasht gespeichert werden!

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2) // Passwörter sollten nicht zurückgegeben werden!
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}

// Benutzerklasse
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; } // Beachte: Passwörter sollten nicht in der Anwendung gespeichert werden!
}