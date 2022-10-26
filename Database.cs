using MySqlConnector;
using Dapper;
class Database
{
    public static MySqlConnection Connect()
    {
       var connection = new MySqlConnection("Server = localhost;Database = videoteket;Uid=root");
       return connection;
    }
}