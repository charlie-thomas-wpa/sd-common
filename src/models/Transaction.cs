
namespace sd_common
{
    public class Transaction : ITransaction
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Label { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
