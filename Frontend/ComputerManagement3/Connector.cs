using System;
using System.Data;
using Npgsql;

namespace ComputerManagement3
{
    public class Connector
    {
        private readonly string _connectionString;

        // Konstruktor für benutzerdefinierte Verbindungsdetails
        public Connector(string host, string database, string username, string password, int port = 5432)
        {
            _connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password}";
        }

        // Konstruktor für eine vollständige Verbindungszeichenfolge
        public Connector(string connectionString)
        {
            _connectionString = connectionString;
        }

        public NpgsqlConnection GetConnection()
        {
            try
            {
                var connection = new NpgsqlConnection(_connectionString);
                connection.Open();
                Console.WriteLine("Verbindung zur Datenbank erfolgreich hergestellt.");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Herstellen der Verbindung: {ex.Message}");
                throw;
            }
        }

        public void ExecuteQuery(string query)
        {
            using (var connection = GetConnection())
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Abfrage erfolgreich ausgeführt.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Fehler beim Ausführen der Abfrage: {ex.Message}");
                        throw;
                    }
                }
            }
        }

        // Ergänzung: DataTable für DataGridView
        public DataTable GetDataTable(string query)
        {
            using (var connection = GetConnection())
            using (var command = new NpgsqlCommand(query, connection))
            using (var adapter = new NpgsqlDataAdapter(command))
            {
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
