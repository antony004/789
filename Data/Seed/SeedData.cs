using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.WebUtilities;
using System.Security.Policy;
using System.Text.Encodings.Web;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using _789.Models;

namespace _789.Data.Seed
{
    public class SeedData
    {
        private readonly ApplicationDbContext dbContext;

        public SeedData(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //private readonly UserManager<CustomIdentityModel> _userManager;
        //private readonly IUserStore<CustomIdentityModel> _userStore;
        //private readonly IUserEmailStore<CustomIdentityModel> _emailStore;
        //private readonly ILogger<SeedData> _logger;

        //public SeedData(UserManager<CustomIdentityModel> userManager, IUserStore<CustomIdentityModel> userStore, IUserEmailStore<CustomIdentityModel> emailStore, ILogger<SeedData> logger)
        //{
        //    _userManager = userManager;
        //    _userStore = userStore;
        //    _emailStore = emailStore;
        //    _logger = logger;
        //}

        //public async Task RunSeed()
        //{
        //    var Name1 = "admin";
        //    var email1 = "admin1@gm.com";
        //    var Name2 = "admin2";
        //    var email2 = "admin2@gm.com";
        //    var Password = "aDMIN123@";

        //    var user1 = CreateUser();

        //    await _userStore.SetUserNameAsync(user1, Name1, CancellationToken.None);
        //    await _emailStore.SetEmailAsync(user1, email1, CancellationToken.None);
        //    var result = await _userManager.CreateAsync(user1, Password);

        //    var user2 = CreateUser();

        //    await _userStore.SetUserNameAsync(user2, Name2, CancellationToken.None);
        //    await _emailStore.SetEmailAsync(user2, email2, CancellationToken.None);
        //    var result2 = await _userManager.CreateAsync(user2, Password);

        //    if (result.Succeeded && result2.Succeeded)
        //    {
        //        _logger.LogInformation("User created a new account with password.");
        //        var userId = await _userManager.GetUserIdAsync(user1);
        //        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user1);
        //        var userId2 = await _userManager.GetUserIdAsync(user2);
        //        var code2 = await _userManager.GenerateEmailConfirmationTokenAsync(user2);
        //    }
        //    foreach (var error in result.Errors)
        //    {
        //        Console.WriteLine(string.Empty, error.Description);
        //    }
        //}
        public void RunSeed()
        {
            dbContext.Database.EnsureCreated();
            if (!dbContext.ReferralCodes.Any())
            {
                dbContext.ReferralCodes.Add(new ReferralCode { Code = "HNCKeg8Hjc9VkZA/" });
                dbContext.ReferralCodes.Add(new ReferralCode { Code = "TIAkcMjvbEWhr7AM" });
                dbContext.ReferralCodes.Add(new ReferralCode { Code = "tZiI/xPJDNcZ9TYu" });
                dbContext.ReferralCodes.Add(new ReferralCode { Code = "nk/b8kAufpOTrDOz" });
                dbContext.SaveChanges();
            }
        }
        private CustomIdentityModel CreateUser()
        {
            try
            {
                return Activator.CreateInstance<CustomIdentityModel>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(CustomIdentityModel)}'. " +
                    $"Ensure that '{nameof(CustomIdentityModel)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }
    }
}
