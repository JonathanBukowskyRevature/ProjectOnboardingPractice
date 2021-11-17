namespace Implementation.TimeInWords
{
    public class TimeInWords
    {
        public static string ConvertDigit(int d) => d switch
        {
            0 => "zero",
            1 => "one",
            2 => "two",
            3 => "three",
            4 => "four",
            5 => "five",
            6 => "six",
            7 => "seven",
            8 => "eight",
            9 => "nine",
            10 => "ten",
            11 => "eleven",
            12 => "twelve",
            _ => ""
        };

        public static string ConvertMinutes(int minutes)
        {
            var tens = minutes / 10;
            var ones = minutes % 10;
            var tensStr = tens switch
            {
                1 => "ten",
                2 => "twenty",
                3 => "thirty",
                4 => "forty",
                5 => "fifty",
                _ => ""
            };
            var onesStr = ConvertDigit(ones);
            string minStr;
            var suffix = (minutes > 30) ? "to" : "past";
            switch (minutes)
            {
                case 0:
                    minStr = "o' clock";
                    break;
                case 15:
                    minStr = "quarter past";
                    break;
                case 30:
                    minStr = "half past";
                    break;
                case 45:
                    minStr = "quarter to";
                    break;
                default:
                    minStr = $"{tensStr} {onesStr} minutes {suffix}";
                    break;
            }
            return minStr;
        }

        public static string Convert(int hour, int minutes)
        {
            var mins = ConvertMinutes(minutes);
            if (minutes == 0)
            {
                return $"{hour} o' clock";
            }
            else
            {
                return $"{mins} {ConvertDigit(hour)}";
            }
        }
    }
}