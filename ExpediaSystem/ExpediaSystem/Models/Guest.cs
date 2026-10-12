namespace ExpediaSystem.Models;

public class Guest
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public Guest(int id, string name, string email, string phoneNumber)
    {
        Id = id;
        FullName = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}