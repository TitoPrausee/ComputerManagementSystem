using Npgsql; // Verwenden Sie Npgsql für PostgreSQL
using System;
using System.Collections.Generic;

namespace ComputerManagementSystem
{
    public class DatabaseOperations
    {
        private string connectionString = "Host=217.160.76.103;Port=5432;Database=jomi;Username=jomi;Password=init123$;";

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
                    Console.WriteLine("PostgreSQL Fehler: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Allgemeiner Fehler: " + ex.Message);
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