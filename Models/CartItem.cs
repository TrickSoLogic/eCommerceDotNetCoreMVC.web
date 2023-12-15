namespace eCommerceDotNetCoreMVC.web.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; } // Link to the Cart model
        public int ProductId { get; set; } // Link to the Product model
        public int Quantity { get; set; }
        // Other properties as needed
    }
}
