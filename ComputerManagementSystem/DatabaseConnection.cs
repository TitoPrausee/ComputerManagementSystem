using System;
using System.Data.SqlClient;

public class DatabaseConnection
{
    private string connectionString;
    private SqlConnection connection;

    public DatabaseConnection(string server, string database, string userId, string password)
    {
        // Erstellen des Connection Strings
        connectionString = $"Server={server};Database={database};User  Id={userId};Password={password};";
        connection = new SqlConnection(connectionString);
    }

    public void OpenConnection()
    {
        try
        {
            connection.Open();
            Console.WriteLine("Verbindung zur Datenbank erfolgreich hergestellt.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler beim Öffnen der Verbindung: {ex.Message}");
        }
    }

    public void CloseConnection()
    {
        try
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Verbindung zur Datenbank geschlossen.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler beim Schließen der Verbindung: {ex.Message}");
        }
    }

    public SqlConnection GetConnection()
    {
        return connection;
    }
}