using System;
using System.Collections.Generic;
using System.Linq;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '.', ',', ':', ';', ' ', (','), };  
            var text = Console.ReadLine().ToLower().Split(separators);
            var words = text.Where(x => x.Length < 5).OrderBy(x => x).Distinct();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
