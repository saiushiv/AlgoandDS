using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class ZerosEnd
    {
        static void Main()
        {
            int[] number = { 1,0,0,0,0,0,2,5 };
            
            int zerocount = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] !=0) 
                {
                    number[zerocount++] = number[i];
                }   
             }

            while (zerocount < number.Length)
            {
                number[zerocount++] = 0;
            }

            //To print
            foreach (var s in number)
            {
                Console.WriteLine(s);
            }

        }

            
        
    }
}
