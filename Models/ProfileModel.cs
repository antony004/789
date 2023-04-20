namespace _789.Models
{
    public class ProfileModel
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime DOB { get; set; }
        public virtual string? UserId { get; set; }
    }
}
