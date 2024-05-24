
namespace sd_common
{
    public class Income : Transaction, IIdentifiable, ITransaction
    {
        public decimal Tax { get; set; }
    }
}
