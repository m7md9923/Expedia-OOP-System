namespace ExpediaSystem.Models;

public class Room
{
    public int Id { get; set; }
    public string RoomNumber { get; set; }
    public int Floor { get; set; }
    public string Status { get; set; }
    public int RoomTypeId { get; set; }  // FK
    
    // Navigation property
    public RoomType? RoomType { get; set; } 
    
    public Room(int id, string roomNumber, int floor, string status, int roomTypeId)
    {
        Id = id;
        RoomNumber = roomNumber;
        Floor = floor;
        Status = status;
        RoomTypeId = roomTypeId;
    }
}