
namespace sd_common
{
    public class Expense : Transaction, IIdentifiable, ITransaction
    {
        public new static string ToString() { return typeof(Expense).Name; }
        public static string ForeignKey() { return "UserId"; }
    }
}
