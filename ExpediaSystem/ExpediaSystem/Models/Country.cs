namespace ExpediaSystem.Models;

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string CurrencyCode { get; set; }

    public Country(int id, string name, string currencyCode)
    {
        Id = id;
        Name = name;
        CurrencyCode = currencyCode;
    }
}