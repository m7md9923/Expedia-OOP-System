namespace ExpediaSystem.Models;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CountryId { get; set; }  // FK
    public Country? Country { get; set; }
    public List<Hotel> Hotels { get; set; } = new List<Hotel>();
    
    public City(int id, string name, int countryId)
    {
        Id = id;
        Name = name;
        CountryId = countryId;
    }
}