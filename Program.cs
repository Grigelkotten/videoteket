using Dapper;
using MySqlConnector;

internal class Program
{
    private static void Main(string[] args)
    {
        Videoteket video = new();
        User testUser = new();
        testUser.AddUser(Database.Connect(), "alexander", "asplen", "något@mail.com", " salangsgatan 8", 0736644828);

        video.MoviesFromDataBase(Database.Connect());
        video.PrintAllMovies();

        // using (var connection = new MySqlConnection("Server = localhost;Database = videoteket;Uid=root"))
        // {
        //     var users = connection.Query<User>("SELECT f_name AS FirstName,l_name AS LastName,adress AS Adress FROM users;").ToList();

        //     foreach (User u in users)
        //     {
        //         Console.WriteLine(u.FirstName + " " + u.LastName + " " + u.Adress);
        //     }
        // }
    }
}