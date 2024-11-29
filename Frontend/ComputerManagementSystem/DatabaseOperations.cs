using Npgsql; // Verwenden Sie Npgsql für PostgreSQL
using System;
using System.Collections.Generic;

public class DatabaseOperations
{
    // Korrigierte Verbindungszeichenfolge für PostgreSQL
    private string connectionString = "Host=217.160.76.103;Port=5432;Database=jomi;Username=jomi;Password=init123$;";

    // Methode zum Abrufen von ComputerSystemen
    public List<ComputerSystem> GetComputerSystems()
    {
        List<ComputerSystem> systems = new List<ComputerSystem>();
        string query = "SELECT Id, Name, IPAddress, OperatingSystem, LastUpdated, Motherboard, GPU, RAM, Storage FROM ComputerSystems";

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
            catch (NpgsqlException ex)
            {
                // Fehlerbehandlung für PostgreSQL-spezifische Fehler
                Console.WriteLine("PostgreSQL Fehler: " + ex.Message);
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
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            // Verwenden Sie Parameter, um SQL-Injection zu vermeiden
            string query = "SELECT Id, Username FROM users WHERE username = @username AND password = @password";

            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password); // Beachte: Passwörter sollten gehasht gespeichert werden!

                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id = reader.GetInt32(0),
                            Username = reader.GetString(1)
                            // Passwörter sollten nicht zurückgegeben werden!
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

// Benutzerklasse
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    // Passwörter sollten nicht in der Anwendung gespeichert werden!
}

// ComputerSystem-Klasse
public class ComputerSystem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string IPAddress { get; set; }
    public string OperatingSystem { get; set; }
    public DateTime LastUpdated { get; set; }
    public string Motherboard { get; set; }
    public string GPU { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }
}