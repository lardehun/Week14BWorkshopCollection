using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14BWorkshopMondayCollections
{
    class task1
    {
        char[] stringArray;
        public task1(string textToSort)
        {
            this.stringArray = textToSort.ToCharArray();
        }

        public string ReturnSortedString()
        {
            Array.Sort(stringArray);
            return new string(stringArray);
        }

        static void Main(string[] args)
        {   
            string text = Console.ReadLine().ToString();
            task1 test = new task1(text);
            Console.WriteLine(test.ReturnSortedString());
            Console.ReadLine();
        }
    }
}
