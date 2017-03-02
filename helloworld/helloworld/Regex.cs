using System;

namespace helloworld
{
    class RegEx
    {
        static void Main()
        {
            String[] words = { "C# code","Chapter 2: Writing Code", "Unicode", "no match here" };

            String patt = "Code";

            foreach (var s in words)
            {
                try
                {
                    Console.WriteLine("{0}", s);
                    if (System.Text.RegularExpressions.Regex.IsMatch(s, patt))
                    {
                        Console.WriteLine("(match for {0} found)", patt);
                    }
                    else
                    {
                        Console.WriteLine("(no match)");
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
