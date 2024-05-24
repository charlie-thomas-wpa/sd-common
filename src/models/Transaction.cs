
namespace sd_common
{
    public class Transaction
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
    }
}
