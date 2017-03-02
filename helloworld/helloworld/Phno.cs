using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class TestPhoneNo
    {
        static void Main()
        {
            String[] phno = { "123-456-7890", "123-45-7890", "13-456-7890", "123-456-78900" };

            String pat = "^\\d{3}-\\d{3}-\\d{4}$";

            foreach (var s in phno)
            {
                Console.WriteLine("{0}", s);
                if (System.Text.RegularExpressions.Regex.IsMatch(s, pat))
                {
                    Console.WriteLine("{0} is a phno", s);
                }
                else
                {
                    Console.WriteLine("No Match");
                }

            }
        }
    }
}
