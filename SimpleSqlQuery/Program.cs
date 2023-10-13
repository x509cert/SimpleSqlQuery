using Microsoft.Data.SqlClient;

// Replace with your server name
string serverName = "127.0.0.1,1433";
string connectionString = $"Server={serverName};Trusted_Connection=yes;Encrypt=no";

string queryString = "SELECT name FROM sys.databases;";

using (var connection = new SqlConnection(connectionString))
{
    var command = new SqlCommand(queryString, connection);
    connection.Open();

    var reader = command.ExecuteReader();
    Console.WriteLine("List of Databases:");
    while (reader.Read())
        Console.WriteLine(reader[0]);

    reader.Close();
    connection.Close();
}
 