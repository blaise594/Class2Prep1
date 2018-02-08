using System;
using System.Collections.Generic;

namespace Class2Prep1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> intList = new List<int>        
            {
                2,
                4,
                6,
                8,
                10,
                12,
                14,
                16,
                18,
                20
            };
            
            int[] intArray = intList.ToArray();
            Add(intArray);

        }
       public static void Add(int[] intArray)
       {          
            int sum = 0;
            Array.ForEach(intArray, delegate (int i) { sum += i; });
            Console.WriteLine(sum);
            Console.ReadLine();
       }

    }
}
