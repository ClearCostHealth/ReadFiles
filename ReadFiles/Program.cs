// See https://aka.ms/new-console-template for more information
using ReadFiles.Models;
using System.Data.SqlClient;
using System.Text.Json;

var path = args[0];
Console.WriteLine(path);
DirectoryInfo dir = new DirectoryInfo(path);
var files = dir.GetFiles();
foreach (var file in files)
{
    Console.WriteLine(file.FullName);
    StreamReader r = new StreamReader(file.FullName);
    string jsonString = r.ReadToEnd();
    var contents  = JsonSerializer.Deserialize<Payload>(jsonString);
    string connectionString = "";
    var sql = @"Select *";
    using (SqlConnection connection = new SqlConnection(connectionString)) 
    {
        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandText = sql;
            //cmd.Parameters.AddWithValue("@Npi", Npi);
            command.ExecuteNonQuery();

            using (SqlDataReader rdr = command.ExecuteReader())
            {
                while (await rdr.ReadAsync().ConfigureAwait(false))
                {
                }
            }
        }
    }
                }
