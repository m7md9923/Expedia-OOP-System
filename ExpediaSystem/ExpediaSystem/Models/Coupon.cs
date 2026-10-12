namespace ExpediaSystem.Models;

public class Coupon
{
    public int Id { get; set; }
    public string Code { get; set; }
    public decimal DiscountPercent { get; set; }
    public decimal MaxDiscount { get; set; }
    public DateTime ExpirationDate { get; set; }
    public bool IsActive { get; set; }
    
    public Coupon(int id, string code, decimal discountPercent, decimal maxDiscount, DateTime expirationDate, bool isActive)
    {
        Id = id;
        Code = code;
        DiscountPercent = discountPercent;
        MaxDiscount = maxDiscount;
        ExpirationDate = expirationDate;
        IsActive = isActive;
    }
    
}