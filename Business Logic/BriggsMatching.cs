namespace _789.Business_Logic
{
    public class BriggsMatching
    {
        public static int Zodiac(string UserType, string GuestType)
        {
            switch (UserType)
            {
                case "INFP":
                    return INFP(GuestType) * 7;
                case "ENFP":
                    return ENFP(GuestType) * 7;
                case "INFJ":
                    return INFJ(GuestType) * 7;
                case "ENFJ":
                    return ENFJ(GuestType) * 7;
                case "INTJ":
                    return INTJ(GuestType) * 7;
                case "ENTJ":
                    return ENTJ(GuestType) * 7;
                case "INTP":
                    return INTP(GuestType) * 7;
                case "ENTP":
                    return ENTP(GuestType) * 7;
                case "ISFP":
                    return ISFP(GuestType) * 7;
                case "ESFP":
                    return ESFP(GuestType) * 7;
                case "ISTP":
                    return ISTP(GuestType) * 7;
                case "ESTP":
                    return ESTP(GuestType) * 7;
                case "ISFJ":
                    return ISFJ(GuestType) * 7;
                case "ESFJ":
                    return ESFJ(GuestType) * 7;
                case "ISTJ":
                    return ISTJ(GuestType) * 7;
                case "ESTJ":
                    return ESTJ(GuestType) * 7;
                default:
                    return 0;
            }
        }
        //1
        private static int ESTJ(string guestType)
        {
            switch (guestType)
            {
                case "ISTP":
                case "INTP":
                case "ISFP":
                    return 5;
                case "ISFJ":
                case "ESFJ":
                case "ISTJ":
                case "ESTJ":
                    return 4;
                case "ESTP":
                case "ENTJ":
                case "ESFP":
                    return 3;
                case "INTJ":
                case "ENTP":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int ISTJ(string guestType)
        {
            switch (guestType)
            {
                case "ESTP":

                case "ESFP":
                    return 5;
                case "ISFJ":
                case "ESFJ":
                case "ISTJ":
                case "ESTJ":
                    return 4;
                case "ISTP":
                case "ENTJ":
                case "ISFP":
                    return 3;
                case "INTJ":
                case "ENTP":
                case "INTP":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int ESFJ(string guestType)
        {
            switch (guestType)
            {
                case "ISTP":
                case "ISFP":
                    return 5;
                case "ISFJ":
                case "ESFJ":
                case "ISTJ":
                case "ESTJ":
                    return 4;
                case "ESTP":
                case "ENTJ":
                case "ESFP":
                    return 3;
                case "INTJ":
                case "INTP":
                case "ENTP":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int ISFJ(string guestType)
        {
            switch (guestType)
            {
                case "ESTP":
                case "ESFP":
                    return 5;
                case "ISFJ":
                case "ESFJ":
                case "ISTJ":
                case "ESTJ":
                    return 4;
                case "ISTP":
                case "ENTJ":
                case "ISFP":
                    return 3;
                case "INTJ":
                case "ENTP":
                case "INTP":
                    return 2;
                default:
                    return 1;
            }
        }
        //2
        private static int ESTP(string GuestType)
        {
            switch (GuestType)
            {
                case "ISTJ":
                case "ISFJ":
                    return 5;
                case "ENTJ":
                case "ESFJ":
                case "INTJ":
                case "ESTJ":
                case "ENTP":
                case "INTP":
                    return 3;
                case "ISFP":
                case "ISTP":
                case "ESTP":
                case "ESFP":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int ISTP(string GuestType)
        {
            switch (GuestType)
            {
                case "ESTJ":
                case "ESFJ":
                    return 5;
                case "ENTJ":
                case "ISFJ":
                case "INTJ":
                case "ISTJ":
                case "ENTP":
                case "INTP":
                    return 3;
                case "ISFP":
                case "ISTP":
                case "ESTP":
                case "ESFP":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int ESFP(string GuestType)
        {
            switch (GuestType)
            {
                case "ISTJ":
                case "ISFJ":
                    return 5;
                case "ENTJ":
                case "ESFJ":
                case "INTJ":
                case "ESTJ":
                case "ENTP":
                case "INTP":
                    return 3;
                case "ISFP":
                case "ISTP":
                case "ESTP":
                case "ESFP":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int ISFP(string GuestType)
        {
            switch (GuestType)
            {
                case "ESTJ":
                case "ESFJ":
                case "ENFJ":
                    return 5;
                case "ENTJ":
                case "ISFJ":
                case "INTJ":
                case "ISTJ":
                case "ENTP":
                case "INTP":
                    return 3;
                case "ISFP":
                case "ISTP":
                case "ESTP":
                case "ESFP":
                    return 2;
                default:
                    return 1;
            }
        }
        //3
        private static int ENTP(string GuestType)
        {
            switch (GuestType)
            {
                case "INFJ":
                case "INTJ":
                    return 5;
                case "INFP":
                case "ENFP":
                case "ENTJ":
                case "ENFJ":
                case "INTP":
                case "ENTP":
                    return 4;
                case "ESFP":
                case "ISTP":
                case "ISFP":
                case "ESTP":
                    return 3;
                case "ISFJ":
                case "ESFJ":
                case "ISTJ":
                case "ESTJ":
                    return 2;
                default:
                    return 1;
            }
        }
        private static int INTP(string GuestType)
        {
            switch (GuestType)
            {
                case "ESTJ":
                case "ENTJ":
                    return 5;
                case "INFP":
                case "ENFP":
                case "INTJ":
                case "ENFJ":
                case "INTP":
                case "ENTP":
                case "INFJ":
                    return 4;
                case "ESFP":
                case "ISTP":
                case "ISFP":
                case "ESTP":
                    return 3;
                case "ISFJ":
                case "ESFJ":
                case "ISTJ":
                    return 2;
                default:
                    return 1;
            }
        }
        private static int ENTJ(string GuestType)
        {
            switch (GuestType)
            {
                case "INFP":
                case "INTP":
                    return 5;
                case "INFJ":
                case "ENFP":
                case "ENTJ":
                case "ENFJ":
                case "INTJ":
                case "ENTP":
                    return 4;
                case "ESFP":
                case "ISTP":
                case "ISFP":
                case "ESTP":
                case "ISFJ":
                case "ESFJ":
                case "ISTJ":
                case "ESTJ":
                    return 3;
                default:
                    return 1;
            }
        }
        private static int INTJ(string GuestType)
        {
            switch (GuestType)
            {
                case "ENFP":
                case "ENTP":
                    return 5;
                case "INFP":
                case "INFJ":
                case "ENTJ":
                case "ENFJ":
                case "INTP":
                case "INTJ":
                    return 4;
                case "ESFP":
                case "ISTP":
                case "ISFP":
                case "ESTP":
                    return 3;
                case "ISFJ":
                case "ESFJ":
                case "ISTJ":
                case "ESTJ":
                    return 2;
                default:
                    return 1;
            }
        }
        //4
        private static int ENFJ(string GuestType)
        {
            switch (GuestType)
            {
                case "INFP":
                case "ISFP":
                    return 5;
                case "ENFP":
                case "INFJ":
                case "ENFJ":
                case "INTJ":
                case "ENTJ":
                case "INTP":
                case "ENTP":
                    return 4;
                default:
                    return 1;
            }
        }

        private static int INFJ(string GuestType)
        {
            switch (GuestType)
            {
                case "ENTP":
                case "ENFP":
                    return 5;
                case "INFP":
                case "INFJ":
                case "ENFJ":
                case "INTJ":
                case "ENTJ":
                case "INTP":
                    return 4;
                default:
                    return 1;
            }
        }

        private static int ENFP(string GuestType)
        {
            switch (GuestType)
            {
                case "INFJ":
                case "INTJ":
                    return 5;
                case "ENFP":
                case "INFP":
                case "ENFJ":
                case "ENTJ":
                case "INTP":
                case "ENTP":
                    return 4;
                default:
                    return 1;
            }
        }

        private static int INFP(string GuestType)
        {
            switch (GuestType)
            {
                case "ENFJ":
                case "ENTJ":
                    return 5;
                case "ENFP":
                case "INFJ":
                case "INFP":
                case "INTJ":
                case "INTP":
                case "ENTP":
                    return 4;
                default:
                    return 1;
            }
        }
    }
}
