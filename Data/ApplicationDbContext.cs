using _789.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _789.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomIdentityModel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }
        public DbSet<QuizModel> Quizzes { get; set; }
        public DbSet<ReferralCode> ReferralCodes { get; set; }
    }
}