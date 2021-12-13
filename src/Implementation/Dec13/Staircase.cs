namespace Implementation.Dec13
{
    public static class Staircase
    {
        // return number of ways to climb a staircase with n steps, either 1 or 2 steps at a time
        public static int waysToClimb(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return waysToClimb(n - 1) + waysToClimb(n - 2);
            }
        }
    }
}