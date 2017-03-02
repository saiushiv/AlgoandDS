using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class MergeList
    {
        static void Main()
        {
            //  int[] nums1 = { 7, 8, 9, 4,0,0,0};
            int[] nums1 = new int[7];
            int[] nums2 = {1,2,3};

            List<int> list1 = new List<int>(nums1);
            List<int> list2 = new List<int>(nums2);
            var output = new List<int>();
            //    list1.Insert(0,6);   //Inserts element at first

            list1[0] = 4;
            list1[1] = 5;
            list1[2] = 6;
            list1[3] = 7;

            if (list1[0] < list2[2])
            {
                output = list1.Concat(list2).ToList();

            }
            else
            {
              output = list2.Concat(list1).ToList();
            }



           
            //        var loops = list2.Count;
            //           var loopb = list1.Count;

            //***  var output  = list1.Zip(list2, (x, y) => x + y).ToList();   // Method to add two lists

            //***var output = list1.Concat(list2);   // Method 1 to merge two lists
            //***var output  = list1.Union(list2).OrderBy(i => i);  // Method 2 to merge two lists

            //List<int> output = new List<int>();

            //for (int i = 0; i < 3; i++)
            //{
            //    if (list1[i] != 0)
            //    {
            //        if (list1[i] < list2[i])
            //        {
            //            output[i] = list1[i];
            //            Console.WriteLine(output[i]);
            //        }
            //        else
            //        {
            //            output[i] = list2[i];
            //            Console.WriteLine(output[i]);
            //        }

            //    }

            //}

            //while (loops < loopb)
            //{
            //    if (list1[loops] != 0)
            //    {
            //        output[loops++] = list1[loops];
            //        }
            //}

            foreach (var s in output)
            {
                Console.WriteLine(s);
                Console.ReadLine();
            }

        }

            
        }

    }
