
namespace sd_common
{
    public class User : IIdentifiable
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public decimal? StartingBalance { get; set; }
        public new static string ToString() { return typeof(User).Name; }
    }
}
