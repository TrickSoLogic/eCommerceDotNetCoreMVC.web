namespace eCommerceDotNetCoreMVC.web.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; } // Link to the Product model
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        // Other properties as needed
    }
}
