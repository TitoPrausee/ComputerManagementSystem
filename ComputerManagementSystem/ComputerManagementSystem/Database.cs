using System;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace ComputerManagementSystem
{
    public class Database
    {
        // Verbindung zur Datenbank (bitte die Datenbankdetails anpassen)
        private string connectionString = "server=localhost;uid=root;database=projekt3;";

        public void Connect()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Verbindung zur Datenbank erfolgreich!");

                    // Beispiel für das Einfügen eines Benutzers
                    // InsertBenutzer(conn, "Max Mustermann", "max@example.com", "0123456789", "passwort123");

                    // Beispiel für das Abrufen von Benutzern
                    GetBenutzer(conn);
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Fehler: " + ex.Message);
                }
            }
        }

        public void InsertBenutzer(MySqlConnection conn, string name, string email, string telefonnummer, string password)
        {
            string hashedPassword = HashPassword(password); // Passwort hashen
            string insertQuery = "INSERT INTO Benutzer (Name, Email, Telefonnummer, Password) VALUES (@Name, @Email, @Telefonnummer, @Password)";
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Telefonnummer", telefonnummer);
                cmd.Parameters.AddWithValue("@Password", hashedPassword); // Gehashtes Passwort speichern
                cmd.ExecuteNonQuery();
                Console.WriteLine("Benutzer erfolgreich hinzugefügt.");
            }
        }

        public void GetBenutzer(MySqlConnection conn)
        {
            string selectQuery = "SELECT * FROM Benutzer";
            using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["Benutzer_ID"]}, Name: {reader["Name"]}, Email: {reader["Email"]}, Telefonnummer: {reader["Telefonnummer"]}");
                    }
                }
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Password FROM Benutzer WHERE Name = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        string storedHash = cmd.ExecuteScalar() as string;

                        if (storedHash != null)
                        {
                            // Vergleiche das eingegebene Passwort (gehasht) mit dem gespeicherten Hash
                            return VerifyPassword(password, storedHash);
                        }
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Fehler: " + ex.Message);
                    return false;
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool VerifyPassword(string password, string storedHash)
        {
            string hashOfInput = HashPassword(password);
            return hashOfInput.Equals(storedHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}