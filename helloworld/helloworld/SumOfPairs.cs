using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class SumOfPair
    {
        static void checkPairs(int[] input, int ksum)
        {
            Dictionary<int, int> Pairs = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Pairs.ContainsKey(input[i]))
                {
                    Console.WriteLine(input[i] + ", " + Pairs[input[i]]);
                }
                else
                {
                    Pairs[ksum - input[i]] = input[i];
                }
            }
        }
        static void Main()
        {
            int[] a = { 2, 45, 7, 3, 5, 1, 8, 9 };
            //method : codaddict's algorithm : O(n)
            checkPairs(a, 11);
            Console.Read();
        }
    }
}
