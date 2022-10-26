using MySqlConnector;
using Dapper;

class Videoteket
{
    private List<Movie> Movies = new();


    private void MoviesFromDataBase()
    {
        using (var connection = new MySqlConnection("Server = localhost;Database = videoteket;Uid=root"))
        {
            var movies = connection.Query<Movie>("SELECT genre AS Genre,title AS Title,id AS Id,is_old AS IsOld, release_date AS ReleaseDate FROM users;").ToList();

            foreach (Movie movie in movies)
            {
                Movies.Add(movie);
            }
        }
        return movie;
    }
}