namespace ExpediaSystem.Models;

public class Amenity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }

    public List<HotelAmenity> HotelAmenities { get; set; } = new List<HotelAmenity>();
    public List<RoomTypeAmenity> RoomTypeAmenities { get; set; } = new List<RoomTypeAmenity>();
    public Amenity(int id, string name, string category)
    {
        Id = id;
        Name = name;
        Category = category;
    }
    
}