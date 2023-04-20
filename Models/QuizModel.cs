namespace _789.Models
{
    public class QuizModel
    {
        public Guid Id { get; set; }
        public bool Question1 { get; set; }
        public bool Question3 { get; set; }
        public bool Question2 { get; set; }
        public bool Question4 { get; set; }
        public bool Question5 { get; set; }
        public bool Question6 { get; set; }
        public bool Question7 { get; set; }
        public bool Question8 { get; set; }
        public bool Question9 { get; set; }
        public bool Question10 { get; set; }
        public Question1 Question11 { get; set; }
        public Question2 Question12 { get; set; }
        public Question3 Question13 { get; set; }
        public Question4 Question14 { get; set; }
        public Question5 Question15 { get; set; }
        public Question6 Question16 { get; set; }
        public Question7 Question17 { get; set; }
        public Question8 Question18 { get; set; }
        public Question9 Question19 { get; set; }
        public Question10 Question20 { get; set; }
        public Question11 Question21 { get; set; }
        public Question12 Question22 { get; set; }
        public Question13 Question23 { get; set; }
        public Question14 Question24 { get; set; }
        public Question15 Question25 { get; set; }
        public Zodiac Sign { get; set; }
        public MyerBriggs SMTP { get; set; }
        public virtual string? UserId { get; set; }
        public float CurrentRating = 0.0f;

        public int CompareTo(QuizModel? x, QuizModel? y)
        {
            if (x == null || y == null) return 0;
            int similar = 0;
            for (int i = 1; i <= 25; i++)
            {
                if (i < 11)
                {
                    bool? xAnswer = (bool?)typeof(QuizModel).GetProperty($"Question{i}")?.GetValue(x) ?? false;
                    bool? yAnswer = (bool?)typeof(QuizModel).GetProperty($"Question{i}")?.GetValue(y) ?? false;
                    if (xAnswer == yAnswer)
                    {
                        similar++;
                    }
                }
                else
                {
                    string? xAnswer = Enum.GetName(typeof(QuizModel).GetProperty($"Question{i}").PropertyType, (int)typeof(QuizModel).GetProperty($"Question{i}")?.GetValue(x));
                    string? yAnswer = Enum.GetName(typeof(QuizModel).GetProperty($"Question{i}").PropertyType, (int)typeof(QuizModel).GetProperty($"Question{i}")?.GetValue(y));
                    if (xAnswer == yAnswer)
                    {
                        similar++;
                    }
                }
            }
            return similar;
        }
    }
}
