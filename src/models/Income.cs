
namespace sd_common
{
    public class Income : Transaction, IIdentifiable, ITransaction
    {
        public RecurranceFrequency RecurranceFrequency { get; set; }
        public decimal Tax { get; set; }
    }
}
