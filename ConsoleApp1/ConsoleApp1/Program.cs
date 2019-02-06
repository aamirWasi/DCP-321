using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_254
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split('\n');
                string res = InvertCasing(line);
                Console.WriteLine($"{res}");
            }
        }
        static string InvertCasing(string s)
        {
            char[] c = s.ToCharArray();
            char[] cUpper = s.ToUpper().ToCharArray();
            char[] cLower = s.ToLower().ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == cUpper[i])
                {
                    c[i] = cLower[i];
                }
                else
                {
                    c[i] = cUpper[i];
                }
            }
            return new string(c);
        }
    }
}
