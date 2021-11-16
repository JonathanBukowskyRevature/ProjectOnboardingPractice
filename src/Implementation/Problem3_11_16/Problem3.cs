using System.Linq;
namespace Implementation.Problem3_11_16
{
    public class Problem3
    {
        public static string FlipCase(string s)
        {
            return string.Join("", s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
        }
    }
}