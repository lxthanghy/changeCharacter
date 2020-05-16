using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLearn
{
    class Program
    {
        static string ChangeCharacter(string s)
        {
            string ans = "";
            int len = s.Length;
            int d = 0;
            for (int i = 0; i < len; ++i)
            {
                int x = s[i];
                if (x == 40) ++d;
                else if (x == 41) --d;
                else
                {
                    if (d % 2 == 1)
                    {
                        if (x >= 65 && x <= 90)
                            x += 32;
                        else if (x >= 97 && x <= 122)
                            x -= 32;
                    }
                    ans += Convert.ToChar(x);
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ChangeCharacter(""));
            Console.ReadKey();
        }
    }
}
