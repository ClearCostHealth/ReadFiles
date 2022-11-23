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
    var sql = @"Select top 2 IsNull(a.Line1, ''), IsNull(a.Line2, ''), IsNull(a.Line3, ''), IsNull(a.CityName, ''), IsNull(a.UspsCode, ''), 
                        IsNull(a.ZipPostalCode, ''), a.Coordinates.Lat, a.Coordinates.Long
                        From NpiAddress n 
                        inner join vwAddress a on n.AddressId = a.AddressId 
						Where n.Npi = @Npi and n.employerPayerID = @employerPayerID
                        order by n.AddressPriority";
    using (SqlConnection conn = new SqlConnection(connectionString)) ;
    {
        using (SqlCommand cmd = new SqlCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@Npi", Npi);
            cmd.Parameters.AddWithValue("@employerPayerID", employerPayerID);
            using (SqlDataReader rdr = await cmd.ExecuteReaderUncommitedAsync().ConfigureAwait(false))
            {
                while (await rdr.ReadAsync().ConfigureAwait(false))
                {
                }
            }
        }
    }
                }
