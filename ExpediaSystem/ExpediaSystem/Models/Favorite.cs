namespace ExpediaSystem.Models;

public class Favorite
{
    public int CustomerId { get; set; }  // PK, FK 
    public int HotelId { get; set; }   // PK, FK
    public DateTime CreatedAt { get; set; }
    
    // Navigation properties
    public Customer? Customer { get; set; }
    public Hotel? Hotel { get; set; }

    public Favorite(int customerId, int hotelId)
    {
        CustomerId = customerId;
        HotelId = hotelId;
        CreatedAt = DateTime.UtcNow;
    }
    
    
}