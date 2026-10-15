namespace ExpediaSystem.Models;

public class RoomTypeAmenity
{
    public int RoomTypeId { get; set; }  // PK, FK
    public int AmenityId { get; set; }  // PK, FK
    
    public RoomType? RoomType { get; set; }
    public Amenity? Amenity { get; set; }
    
    public RoomTypeAmenity(int roomTypeId, int amenityId)
    {
        RoomTypeId = roomTypeId;
        AmenityId = amenityId;
    }
    
}