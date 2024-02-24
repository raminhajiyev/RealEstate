namespace RealEstate_Dapper_UI.DTOs.ProductDto
{
    public class CreateProductDto
    {
        public string title { get; set; }
        public decimal price { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string categoryId { get; set; }
        public string coverImage { get; set; }
        public string description { get; set; }
    }
}
