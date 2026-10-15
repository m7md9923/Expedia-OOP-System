namespace ExpediaSystem.Models;

public class RoomType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; }
    public decimal BasePrice { get; set; }
    public int HotelId { get; set; }  // FK
    
    // Navigation properties
    public Hotel? Hotel { get; set; }  
    public List<Room> Rooms { get; set; } = new List<Room>();
    public List<RoomTypeAmenity> RoomTypeAmenities { get; set; } = new List<RoomTypeAmenity>();
    
    public RoomType(int id, string name, string description, int capacity, decimal basePrice, int hotelId)
    {
        Id = id;
        Name = name;
        Description = description;
        Capacity = capacity;
        BasePrice = basePrice;
        HotelId = hotelId;
    }
}