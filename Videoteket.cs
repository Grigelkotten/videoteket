using MySqlConnector;
using Dapper;

class Videoteket
{
    private List<Movie> Movies = new();

    public void MoviesFromDataBase(MySqlConnection connection)
    {
        {
            var movies = connection.Query<Movie>("SELECT genre AS Genre,title AS Title,id AS Id,is_old AS IsOld, release_date AS ReleaseDate FROM movies;").ToList();

            foreach (Movie movie in movies)
            {
                Movies.Add(movie);
            }
        }
    }

    public void PrintAllMovies()
    {
        foreach (Movie item in Movies)
        {
            Console.WriteLine(item.Title);
        }
    }

    public List<Movie> SearchForMovies(MySqlConnection connection, string search)
    {
        var movies = connection.Query<Movie>($"SELECT title FROM movies WHERE title = '{search}';").ToList();
        return movies;
    }
    public bool IsMovieAvalible(MySqlConnection connection, string search)
    {
        int movieId = connection.Query<Movie>($"SELECT id FROM movies WHERE title = '{search}';");
        return movieId;
    }
}