using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class reverseString
    {
        static void Main(String[] args)
        {
            String S = "hi Sai";
            Console.WriteLine("Original String:" + S);
            Console.WriteLine("reversing the string");
            String rs = reverseStrings(S);
            Console.WriteLine(rs);
        }

        private static String reverseStrings(String S) {
            if ((null == S) || (S.Length <= 1)) {
                return S;
            }

            return reverseStrings(S.Substring(1)) + S.ElementAt(0);
        }
    }
}
