namespace eCommerceDotNetCoreMVC.web.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string UserId { get; set; } // Link to the User model
        public int ProductId { get; set; } // Link to the Product model
        public int Rating { get; set; }
        public string Comment { get; set; }
     }
}
