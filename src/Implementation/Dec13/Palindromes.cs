namespace Implementation.Dec13
{
    public static class Palindromes
    {
        public static bool almostPalindrome(string s)
        {
            int wrongCount = 0;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    wrongCount++;
                    // Short circuit to avoid unnecessary checks
                    if (wrongCount > 1)
                    {
                        return false;
                    }
                }
            }
            return (wrongCount <= 1);
        }
    }
}