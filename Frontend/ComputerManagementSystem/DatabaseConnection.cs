using System;
using System.Data.SqlClient;

public class DatabaseConnection
{
    private string connectionString;
    private SqlConnection connection;

    public DatabaseConnection(string server, string database, string userId, string password)
    {
        // Erstellen des Connection Strings
        connectionString = $"Server={server};Database={database};User Id={userId};Password={password};";
        connection = new SqlConnection(connectionString);
    }

    public void OpenConnection()
    {
        try
        {
            connection.Open();
            Console.WriteLine("Verbindung zur Datenbank erfolgreich.");
        }
        catch (Exception)
        {
            Console.WriteLine("Fehler beim Öffnen der Verbindung.");
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
        catch (Exception)
        {
            Console.WriteLine("Fehler beim Schließen der Verbindung.");
        }
    }

    public SqlConnection GetConnection()
    {
        return connection;
    }
}