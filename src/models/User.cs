
namespace sd_common
{
    public class User : IIdentifiable
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
