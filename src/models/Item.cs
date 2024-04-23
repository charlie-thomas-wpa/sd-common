
namespace sd_common
{
    internal class Item : IIdenfiable
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
