
namespace sd_common
{
    public class RecurringExpense : Transaction, IIdentifiable, ITransaction
    {
        public RecurranceFrequency RecurranceFrequency { get; set; }
        public DateTime? EndDate { get; set; }
        public new static string ToString() { return typeof(RecurringExpense).Name; }
        public static string ForeignKey() { return "UserId"; }
    }
}
