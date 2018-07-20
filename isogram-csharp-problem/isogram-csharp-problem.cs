using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace isogram_csharp_problem
{
    public class Class1
    {
        public static bool isIsogram(string input)
        {
            Regex skip = new Regex("[^A-Za-z]");
            string x = skip.Replace(input, "");
            return ((x.Length == x.Distinct().Count()));
        }
    }
}
