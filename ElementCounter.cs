using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._3
{
    public class ElementCounter
    {
        int[] Elements;
        public ElementCounter(int[] elements)
        {
            Elements = elements;
        }

        public ElementCounter()
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            
            Elements = new int[arrayLength];
            Console.WriteLine($"Input {arrayLength} elements in the array: ");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Element {i}: ");
                Elements[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public Dictionary<int, int> Count()
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();
            foreach (int i in Elements)
            {
                try { counter.Add(i, 0); }
                catch { }
            }
            foreach (int i in Elements)
            {
                counter[i]++;
            }
            return counter;
        }
        public static void DisplayCount(Dictionary<int,int> dict)
        {
            foreach (int i in dict.Keys)
            {
                Console.WriteLine($"{i} occurs {dict[i]} times");
            }
        }

        public int[] UniqueElements()
        {
            var dict = Count();
            List<int> uniqueElements = [];
            foreach(int i in dict.Keys)
            {
                if (dict[i]==1)
                {
                    uniqueElements.Add(i);
                }
            }
            var uniqueArray = uniqueElements.ToArray();
            Console.Write("The unique elements found in the array are: ");
            foreach(int i in uniqueArray)
            {
                Console.Write($"{i}, ");
            }

            return uniqueArray;
        }

    }
}
