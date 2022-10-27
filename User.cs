using MySqlConnector;
using Dapper;
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

    public void AddUser(MySqlConnection connection, string firstName, string lastName, string email, string adress, int phonenumber)
    {
        connection.Query<User>($"INSERT INTO users(f_name, l_name, email, adress, phone_number) VALUES('{firstName}', '{lastName}', '{email}', '{adress}', '{phonenumber}')");
    }
}