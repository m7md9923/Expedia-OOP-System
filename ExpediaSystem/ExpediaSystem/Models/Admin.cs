namespace ExpediaSystem.Models;

public class Admin : User
{
    public Admin(int id, string name, string email, string password, string phoneNumber) :
        base(id, name, email, password, "Admin", phoneNumber, true)
    {

    }
}