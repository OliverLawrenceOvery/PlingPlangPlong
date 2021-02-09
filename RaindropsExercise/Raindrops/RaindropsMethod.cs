using System;

namespace Raindrops
{
    public static class RaindropsMethod
    {
        public static string FactorFinder(int n)
        {
            string output = "";
            output += (n % 3 == 0) ? "Pling" : "";
            output += (n % 5 == 0) ? "Plang" : "";
            output += (n % 7 == 0) ? "Plong" : "";
            output += (output == "") ? n.ToString() : "";

            return output;
        }
    }
}
