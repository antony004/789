using _789.Models;

namespace _789.Services
{
    public interface IDataService
    {
        Task<ReferralCode> GenerateRefCode();
        Task VerifyReferralCode(string ReferralCode, bool MarkAsUsed = false);
        Task<IEnumerable<QuizModel>> RetreiveQuizzes();
        Task InsertQuiz(QuizModel quiz);
        Task<ProfileModel> RetreiveProfile(string UserId);
        Task UpdateProfile(ProfileModel profile);
    }
}