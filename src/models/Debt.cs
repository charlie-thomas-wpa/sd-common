
namespace sd_common
{
    public class Debt : IIdentifiable
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Label { get; set; }
        public decimal Balance { get; set; }
        public decimal RepaymentAmount { get; set; }
        public RecurranceFrequency RepaymentFrequency { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime StartDate { get; set; }
        public new static string ToString() { return typeof(Debt).Name; }
        public static string ForeignKey() { return "UserId"; }
    }
}
