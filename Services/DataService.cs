using _789.Data;
using _789.Data.Referral;
using _789.Models;

namespace _789.Services
{
    public class DataService : IDataService
    {
        private ApplicationDbContext dbContext;

        public DataService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task VerifyReferralCode(string ReferralCode, bool MarkAsUsed = false)
        {
            try
            {
                var ReferralCodes = dbContext.ReferralCodes.Where(e => e.Code == ReferralCode).ToList();
                if (ReferralCodes.Count > 0)
                {
                    var RefCode = ReferralCodes[0];
                    if (RefCode.IsUsed == true)
                    {
                        throw new ArgumentException("Referral Code has already been used");
                    }
                    if (MarkAsUsed == true)
                    {
                        RefCode.IsUsed = true;
                        dbContext.ReferralCodes.Update(RefCode);
                        dbContext.SaveChanges();
                    }
                    return;
                }
                throw new ArgumentException($"Invalid Code");
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"{ex.Message}, Code does not exist");
            }
        }

        public async Task<ReferralCode> GenerateRefCode()
        {
            try
            {
                var RefCode = ReferralCodeGenerator.GenerateCode();
                await dbContext.ReferralCodes.AddAsync(RefCode);
                dbContext.SaveChanges();
                return RefCode;
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"{ex.Message}, Error Generating Referral Code");
            }
        }
    }
}
