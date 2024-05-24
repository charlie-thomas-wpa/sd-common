
namespace sd_common
{
    // Potential to add enum to track transaction types for expenses
    public interface ITransaction
    {
        Guid UserId { get; set; }
        decimal Amount { get; set; }
        DateTime Date { get; set; }
        string? Description { get; set; }
    }
}
