
namespace sd_common
{
    public class Item : IIdentifiable
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
