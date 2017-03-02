using System;
using System.Collections.Generic;

namespace helloworld
{
    class Occurences
    {
        static void Main()
        {
            int[] numbers = { 5, 5, 5, 7, 7, 7, 9, 7, 9, 9, 9, 1 };
            var dictionary = new Dictionary<int, int>();
            //        var numbersWithFour = new List<int>();

            foreach (var number in numbers)
            {
                if (dictionary.ContainsKey(number))
                    dictionary[number]++;
                else
                    dictionary.Add(number, 1);
            }

            foreach (var k in dictionary)
            {
                Console.WriteLine(k);
            }
        }
    }   

}

