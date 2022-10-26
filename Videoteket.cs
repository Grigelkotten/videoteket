using MySqlConnector;
using Dapper;

class Videoteket
{
    private List<Movie> Movies = new();


    public void MoviesFromDataBase(MySqlConnection connection)
    {
        
            var movies = connection.Query<Movie>("SELECT genre AS Genre,title AS Title,id AS Id,is_old AS IsOld, release_date AS ReleaseDate FROM movies;").ToList();

            foreach (Movie movie in movies)
            {
                Movies.Add(movie);
            }
        
    }
    public void PrintAllMovies()
    {
        foreach (Movie movie in Movies)
        {
            Console.WriteLine(movie.Title);
        }
    }
     
}