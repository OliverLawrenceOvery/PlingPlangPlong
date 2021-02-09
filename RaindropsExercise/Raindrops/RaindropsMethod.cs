using System;
using System.Text;

namespace Raindrops
{
    public static class RaindropsMethod
    {
        public static string FactorFinder(int n)
        {
            StringBuilder result = new StringBuilder();

            if (n % 3 == 0) result.Append("Pling");
            if (n % 5 == 0) result.Append("Plang");
            if (n % 7 == 0) result.Append("Plong");
            if (result.ToString() == "") return n.ToString();
            return result.ToString();
        }
    }
}
