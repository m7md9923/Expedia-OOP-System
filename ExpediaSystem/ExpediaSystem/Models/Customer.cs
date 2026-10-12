namespace ExpediaSystem.Models;

public class Customer : User
{
    public Customer(int id, string name, string email, string password, string phoneNumber) : 
        base(id, name, email, password, "Customer", phoneNumber, true)
    {
    }
    
}