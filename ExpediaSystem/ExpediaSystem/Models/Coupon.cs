namespace ExpediaSystem.Models;

public class Coupon
{
    public int Id { get; set; }
    public string Code { get; set; }
    public decimal DiscountPercent { get; set; }
    public decimal MaxDiscount { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int MaxUsages { get; set; }
    public int UsedCount { get; set; }
    public bool IsActive { get; set; }
    
    public Coupon(int id, string code, decimal discountPercent, decimal maxDiscount, DateTime expirationDate, int maxUsages, int usedCount, bool isActive)
    {
        Id = id;
        Code = code.Trim().ToUpper();
        DiscountPercent = discountPercent;
        MaxDiscount = maxDiscount;
        ExpirationDate = expirationDate;
        MaxUsages = maxUsages;
        UsedCount = 0;
        IsActive = isActive;
    }
    
}