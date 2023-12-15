namespace eCommerceDotNetCoreMVC.web.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string UserId { get; set; } // Link to the User model
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
     }
}
