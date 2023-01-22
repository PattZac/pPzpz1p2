using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pPzpz1p2
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = ' ';
            int n, nMax = 0;
            Console.WriteLine("Unesite rečenicu: ");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                n = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        n++;
                    }
                }
                if (n > nMax)
                {
                    c = s[i];
                    nMax = n;
                }
            }
            Console.WriteLine(s+" -> "+c+", "+nMax+" puta.");
            Console.ReadKey();
        }
    }
}
