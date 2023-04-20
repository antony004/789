using _789.Models;

namespace _789.Business_Logic
{
    public class ZodiacMatching
    {
        public static int Zodiac(string UserSign, string GuestSign)
        {
            switch (UserSign)
            {
                case "Aries":
                    return Aries(GuestSign) * 5;
                case "Aquarius":
                    return Aquarius(GuestSign) * 5;
                case "Cancer":
                    return Cancer(GuestSign) * 5;
                case "Capricorn":
                    return Capricorn(GuestSign) * 5;
                case "Gemini":
                    return Gemini(GuestSign) * 5;
                case "Leo":
                    return Leo(GuestSign) * 5;
                case "Libra":
                    return Libra(GuestSign) * 5;
                case "Pisces":
                    return Pisces(GuestSign) * 5;
                case "Sagittaurus":
                    return Sagittaurus(GuestSign) * 5;
                case "Scorpio":
                    return Scorpio(GuestSign) * 5;
                case "Taurus":
                    return Taurus(GuestSign) * 5;
                case "Virgo":
                    return Virgo(GuestSign) * 5;
                default:
                    return 0;
            }
        }
        //1
        private static int Virgo(string guestSign)
        {
            switch (guestSign)
            {
                case "Taurus":
                case "Virgo":
                case "Capricorn":
                case "Cancer":
                case "Scorpio":
                    return 3;
                case "Leo":
                case "Aquarius":
                case "Pisces":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int Taurus(string guestSign)
        {
            switch (guestSign)
            {
                case "Taurus":
                case "Virgo":
                case "Capricorn":
                case "Cancer":
                case "Scorpio":
                case "Pisces":
                    return 3;
                case "Leo":
                case "Libra":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int Capricorn(string guestSign)
        {
            switch (guestSign)
            {
                case "Taurus":
                case "Virgo":
                case "Capricorn":
                case "Cancer":
                case "Scorpio":
                case "Pisces":
                    return 3;
                case "Leo":
                case "Libra":

                    return 2;
                default:
                    return 1;
            }
        }
        //2
        private static int Scorpio(string guestSign)
        {
            switch (guestSign)
            {
                case "Taurus":
                case "Virgo":
                case "Capricorn":
                case "Cancer":
                case "Pisces":
                case "Scorpio":
                    return 3;
                case "Leo":
                case "Aries":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int Pisces(string guestSign)
        {
            switch (guestSign)
            {
                case "Taurus":
                case "Capricorn":
                case "Cancer":
                case "Scorpio":
                case "Pisces":
                    return 3;
                case "Leo":
                case "Virgo":
                case "Aries":
                case "Sagittaurus":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int Cancer(string guestSign)
        {
            switch (guestSign)
            {
                case "Taurus":
                case "Virgo":
                case "Capricorn":
                case "Cancer":
                case "Scorpio":
                case "Pisces":
                    return 3;
                case "Leo":
                case "Sagittaurus":
                    return 2;
                default:
                    return 1;
            }
        }
        //3
        private static int Sagittaurus(string guestSign)
        {
            switch (guestSign)
            {
                case "Leo":
                case "Aquarius":
                case "Aries":
                case "Gemini":
                case "Libra":
                case "Sagittaurus":
                    return 3;
                case "Scorpio":
                case "Cancer":
                case "Pisces":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int Leo(string guestSign)
        {
            switch (guestSign)
            {
                case "Leo":
                case "Aries":
                case "Gemini":
                case "Libra":
                case "Sagittaurus":
                    return 3;
                case "Aquarius":
                case "Scorpio":
                case "Cancer":
                case "Pisces":
                case "Taurus":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int Aries(string guestSign)
        {
            switch (guestSign)
            {
                case "Leo":
                case "Aquarius":
                case "Aries":
                case "Gemini":
                case "Libra":
                case "Sagittaurus":
                    return 3;
                case "Virgo":
                case "Pisces":
                    return 2;
                default:
                    return 1;
            }
        }
        //4
        private static int Gemini(string guestSign)
        {
            switch (guestSign)
            {
                case "Leo":
                case "Aquarius":
                case "Aries":
                case "Gemini":
                case "Libra":
                    return 3;
                case "Sagittaurus":
                case "Virgo":
                case "Capricorn":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int Libra(string guestSign)
        {
            switch (guestSign)
            {
                case "Leo":
                case "Aquarius":
                case "Gemini":
                case "Libra":
                case "Sagittaurus":
                    return 3;
                case "Aries":
                case "Taurus":
                case "Pisces":
                    return 2;
                default:
                    return 1;
            }
        }

        private static int Aquarius(string guestSign)
        {
            switch (guestSign)
            {
                case "Leo":
                case "Aquarius":
                case "Aries":
                case "Gemini":
                case "Libra":
                case "Sagittaurus":
                    return 3;
                case "Scorpio":
                case "Pisces":
                    return 2;
                default:
                    return 1;
            }
        }
    }
}
