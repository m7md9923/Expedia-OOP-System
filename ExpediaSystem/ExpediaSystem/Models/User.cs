namespace ExpediaSystem.Models;

public abstract class User
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsActive { get; set; }

    public User (int id, string name, string email, string password, string role, string phoneNumber, bool isActive)
    {
        Id = id;
        FullName = name;
        Email = email;
        Password = password;
        Role = role;
        PhoneNumber = phoneNumber;
        IsActive = isActive;
    }
    
    
}