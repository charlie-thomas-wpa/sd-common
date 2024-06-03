
namespace sd_common
{
    public class SavingGoal : IIdentifiable
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Label { get; set; }
        public decimal TargetAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime TargetDate { get; set; }
        public new static string ToString() { return typeof(SavingGoal).Name; }
        public static string ForeignKey() { return "UserId"; }
    }
}
