using _789.Models;
using _789.Services;

namespace _789.Business_Logic
{
    public class QuizMatching
    {
        private readonly IDataService service;

        public QuizMatching(IDataService service)
        {
            this.service = service;
        }

        public async Task<List<QuizModel>> QuizMatch(QuizModel userQuiz)
        {
            var Quizzes = await service.RetreiveQuizzes();
            var GradedQuiz = new List<QuizModel>();
            GradedQuiz = QuizCalc(userQuiz, Quizzes.ToList());
            return GradedQuiz;
        }
        public static List<QuizModel> QuizCalc(QuizModel quiz, List<QuizModel> quizzes)
        {
            var GradedQuiz = new List<QuizModel>();
            foreach (var Quizz in quizzes)
            {
                int RatingNo = Quizz.CompareTo(quiz, Quizz);
                float Rating = (50 / 25 * RatingNo);
                Quizz.CurrentRating += Rating;
                Quizz.CurrentRating += ZodiacMatching.Zodiac(quiz.Sign.ToString(), Quizz.Sign.ToString());
                Quizz.CurrentRating += BriggsMatching.Zodiac(quiz.SMTP.ToString(), Quizz.SMTP.ToString());
                GradedQuiz.Add(Quizz);
            }
            return GradedQuiz;
        }
    }
}
