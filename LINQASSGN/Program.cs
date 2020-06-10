using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace LINQASSGN
{
    class Program
    {
        static void Main(string[] args)
        {
            // display the number and frequency of number from giving array.
            IList<int> numberList = new List<int>()
            { 1,2,3,5,3,4,1,3,5,9,1,5,2};

            var groups = numberList.GroupBy(n=>n).ToList();
            foreach(var n in groups)
            {
                Console.WriteLine("Number {0} appears {1} time(s)", n.Key,n.Count());
            }

            // display the top nth records
            IList<int> numberList2 = new List<int>()
            {5,7,13,24,6,9,8,7};
            var sortedList = numberList2.OrderByDescending(n => n).ToList();
            Console.WriteLine("How many records you want to display ?");
            int toPrint = int.Parse(Console.ReadLine());
            Console.WriteLine($"The top {toPrint} records from the list are :");
            for(int i=0; i < toPrint; i++)
            {
                Console.Write(sortedList[i] + " ");
                
            }
        }
    }
}
