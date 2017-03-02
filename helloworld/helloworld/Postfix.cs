using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class ConvertToPostFix
    {
        static void Main()
        {
            var a = new ConvertToPostFix();
            String validexpr = "1+2*3-1/2";
            var output = a.ConvertToPostfix(validexpr);
            Console.WriteLine(output);
        }



        public string ConvertToPostfix(string strValidExpression)
        {

            StringBuilder sbPostFix = new StringBuilder();
        Stack<Char> stkTemp = new Stack<char>();

        for (int i = 0; i<strValidExpression.Length; i++)
        {
            char chExp = strValidExpression[i];

            if (chExp == '+' || chExp == '-' || chExp == '*' || chExp == '/')
            {
                sbPostFix.Append(" ");

                if (stkTemp.Count <= 0)
                    stkTemp.Push(chExp);
                else if (stkTemp.Peek() == '*' || stkTemp.Peek() == '/')
                {
                    sbPostFix.Append(stkTemp.Pop()).Append(" ");
        i--;
                }
                else if (chExp == '+' || chExp == '-')
                {
                    sbPostFix.Append(stkTemp.Pop()).Append(" ");
    stkTemp.Push(chExp);
                }
                else
                {
                    stkTemp.Push(chExp);
                }
            }
            else
            {
                sbPostFix.Append(chExp);
            }
        }

        for (int j = 0; j <= stkTemp.Count; j++)
        {
            sbPostFix.Append(" ").Append(stkTemp.Pop());
        }

        string strPostFix = sbPostFix.ToString();
        strPostFix = System.Text.RegularExpressions.Regex.Replace(strPostFix, @"[ ]{2,}", @" ");
        return strPostFix;
    }



    }
}
