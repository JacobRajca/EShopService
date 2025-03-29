namespace EShopService.models
{
    public class Product : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Ean { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? Sku { get; set; }
        public Category? Category { get; set; }
    }

}
