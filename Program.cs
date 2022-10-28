using Dapper;
using MySqlConnector;

internal class Program
{
    private static void Main(string[] args)
    {
        Videoteket video = new();
        User testUser = new();

        //test utav metoden IsMovieOld för att se ifall den returnerade 0 / 1 baserat på databasen.
        // Movie testMovie = new();
        // while (true)
        // {
        //     Console.WriteLine("Sök efter en video");
        //     string input = Console.ReadLine();
        //     int result = testMovie.IsMovieOld(Database.Connect(), input);
        //     Console.WriteLine($"videon är {result}");

        //     // test för att se hur metoden LateReturn beter sig.
        //     Console.WriteLine("skriv in barcode siffra");
        //     string input2 = Console.ReadLine();
        //     int converter = Convert.ToInt32(input2);
        //     int barcode = testMovie.LateReturn(Database.Connect(), converter);
        //     Console.WriteLine($"totalsum: {barcode}");
        // }



        //testUser.AddUser(Database.Connect(), "alexander", "asplen", "något@mail.com", " salangsgatan 8", 0736644828);

        //video.MoviesFromDataBase(Database.Connect());
        //video.PrintAllMovies();

        //gjorde en loop för att testa att meetoden SearchForUser fungerade

        {
            try
            {
                Console.WriteLine("skriv in en person att söka på");
                string searchInput = Console.ReadLine().ToLower();

                string searchForPerson = testUser.SearchForUser(Database.Connect(), searchInput);
                Console.WriteLine($"Found user {searchForPerson}");
                Thread.Sleep(1000);
            }
            catch (System.Exception)
            {
                Console.WriteLine("user doesn't exists in database.");
                Thread.Sleep(1000);
            }
        }


        // List<Movie> movielist = video.SearchForMovies(Database.Connect(), searchInput);
        // foreach (Movie item in movielist)
        // {
        //     Console.WriteLine(item.Title);
        // }

        // int count = video.IsMovieAvalible(Database.Connect(), searchInput);
        // Console.WriteLine($"found number of movies {count}");


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