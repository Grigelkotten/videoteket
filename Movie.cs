using MySqlConnector;
using Dapper;
class Movie
{
    public int Id { get; set; }
    public int IsOld { get; set; }
    public int ReleaseDate { get; set; }

    public string Title { get; set; }
    public string Genre { get; set; }
    public int Price { get; set; }
    public int LoanDays { get; set; }

    public override string ToString()
    {
        return $"{Title} {Genre}";
    }
    //har uppdaterat metoden så den kollar databasen ifall en film är IsOld enligt databasen, värde 0 eller 1.
    public int IsMovieOld(MySqlConnection connection, string search)
    {
        int IsOld = connection.QuerySingle<int>($"SELECT is_old FROM movies WHERE title = '{search}';");

        if (IsOld == 0)
        {
            Price = 29;
            LoanDays = 1;
        }
        else
        {
            Price = 49;
            LoanDays = 2;
        }
        return IsOld;
    }
    //behöver ses över.. (1)behöver ta in filmen, kolla ifall den är gammal (2) Räkna ut loandays och betämma priset därefter.
    public int LateReturn(MySqlConnection connection, int barcode)
    {
        int returnCase = connection.QuerySingle<int>($"SELECT barcode FROM video_case WHERE barcode = '{barcode}';");

        if (IsOld + LoanDays > 3)
        {
            IsOld += 29;
        }
        else if (IsOld + LoanDays > 2)
        {
            IsOld += 49;
        }
        return IsOld;
    }

}