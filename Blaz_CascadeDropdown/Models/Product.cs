namespace Blaz_CascadeDropdown.Models
{
    public class Product
    {
        public int ProductRowId { get; set; }
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int BasePrice { get; set; }
    }
}
