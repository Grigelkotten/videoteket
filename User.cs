class User
{
    public int Id { get; set; }
    public int PhoneNumber { get; set; }

    public string Adress { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }


    public override string ToString()
    {
        return $"{FirstName} {Id}";
    }
}