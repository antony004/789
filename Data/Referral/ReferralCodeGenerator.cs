using _789.Models;
using System.Security.Cryptography;
using System.Text;

namespace _789.Data.Referral
{
    public class ReferralCodeGenerator
    {
        public static ReferralCode GenerateCode()
        {
            var newcode = new ReferralCode()
            {
                Id = new Guid(),
                Code = CreateSecureRandomString(),
            };

            return newcode;
        }
        public static string CreateSecureRandomString(int count = 12) =>
            Convert.ToBase64String(RandomNumberGenerator.GetBytes(count));
    }
}
