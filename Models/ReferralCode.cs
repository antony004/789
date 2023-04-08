namespace _789.Models
{
    public class ReferralCode
    {
        public Guid Id { get; init; }
        public string Code { get; set; }
        public bool IsUsed { get; set; } = false;
    }
}
