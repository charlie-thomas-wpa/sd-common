
namespace sd_common
{
    public class Income : Transaction, IIdentifiable, ITransaction
    {
        public RecurranceFrequency RecurranceFrequency { get; set; }
        public decimal Tax { get; set; }
        public new static string ToString() { return typeof(Income).Name; }
        public static string ForeignKey() { return "UserId"; }
    }
}
