namespace ExpediaSystem.Models;

public class HotelAmenity
{
    public int HotelId { get; set; }  // PK, FK
    public int AmenityId { get; set; }  // PK, FK
    public Hotel? Hotel { get; set; }
    public Amenity? Amenity { get; set; }


    public HotelAmenity(int hotelId, int amenityId)
    {
        HotelId = hotelId;
        AmenityId = amenityId;
    }
}