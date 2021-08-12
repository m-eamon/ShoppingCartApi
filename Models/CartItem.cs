namespace ShoppingCartApi.Models
{
    public class CartItem
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }

        public string Description { get; set; }

        public decimal Price {get; set;}

        public string Retailer {get; set;}
    }
}