class Movie
{
    public int Id { get; set; }
    public int IsOld { get; set; }
    public int ReleaseDate { get; set; }

    public string Title { get; set; }
    public string Genre { get; set; }

    public override string ToString()
    {
        return $"{Title} {Genre}";
    }
}