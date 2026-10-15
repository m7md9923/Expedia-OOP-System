namespace ExpediaSystem.Models;

public class Review
{
    public int Id { get; set; }
    public int CustomerId { get; set; } // FK
    public int HotelId { get; set; }  // FK
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedAt { get; set; }
    
    // Navigation properties
    public Customer? Customer { get; set; }
    public Hotel? Hotel { get; set; }

    public Review(int id, int customerId, int hotelId, int rating, string comment)
    {
        Id = id;
        CustomerId = customerId;
        HotelId = hotelId;
        Rating = rating;
        Comment = comment;
        CreatedAt = DateTime.UtcNow;
    }
    
}