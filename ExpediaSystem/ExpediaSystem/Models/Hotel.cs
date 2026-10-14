namespace ExpediaSystem.Models;

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public  string Address { get; set; }
    
    public string Description { get; set; }
    public decimal Rating { get; set; }
    public string Phone { get; set; }
    public bool IsActive { get; set; }
    public int CityId { get; set; } // FK
    
    public City? City { get; set; }
    
    public List<RoomType> RoomTypes { get; set; } = new List<RoomType>();
    
    public Hotel(int id, string name, string address, string description, 
        decimal rating, string phone, bool isActive, int cityId)
    {
        Id = id;
        Name = name;
        Address = address;
        Description = description;
        Rating = rating;
        Phone = phone;
        IsActive = isActive;
        CityId = cityId;
    }
}