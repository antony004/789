using Microsoft.AspNetCore.Identity;

namespace _789.Models
{
    public class CustomIdentityModel : IdentityUser
    {
        public QuizModel? Quiz { get; set; }
        public ProfileModel? UserProfile { get; set; }
    }
}
