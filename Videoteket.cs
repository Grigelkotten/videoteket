using MySqlConnector;
using Dapper;

class Videoteket
{
    private List<Movie> Movies = new();

    public void MoviesFromDataBase()
    {
        var connection = new MySqlConnection("Server = localhost;Database = videoteket;Uid=root");
        {
            var movies = connection.Query<Movie>("SELECT genre AS Genre, title AS Title,id AS Id,is_old AS IsOld, release_date AS ReleaseDate FROM movies;").ToList();

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

    public Movie SearchForAMovie(string search)
    {
        Movie result = new();

        foreach (Movie movie in Movies)
        {
            if (movie.Title.ToLower().Contains(search) || movie.Genre.ToLower().Contains(search) || movie.ReleaseDate.ToString().Contains(search))
            {
                result = movie;
                break;
            }
        }
        return result;
    }
}