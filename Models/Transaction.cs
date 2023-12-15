namespace eCommerceDotNetCoreMVC.web.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string UserId { get; set; } // Link to the User model
        public int OrderId { get; set; } // Link to the Order model
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
     }
}
