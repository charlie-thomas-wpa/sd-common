
namespace sd_common
{
    public class RecurringExpense : Transaction, IIdentifiable, ITransaction
    {
        public RecurranceFrequency RecurranceFrequency { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
