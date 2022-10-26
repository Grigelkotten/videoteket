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
    public void IsMovieOld()
    {
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
    }
}