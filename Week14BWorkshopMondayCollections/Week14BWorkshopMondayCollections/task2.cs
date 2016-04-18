using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14BWorkshopMondayCollections
{
    class task2
    {
        char[] stringArray;


        public task2(string textToReverse)
        {
            this.stringArray = textToReverse.ToCharArray();
        }

        public string ReturnReversedString()
        {
            Stack stack = new Stack();
            string result = "";
            foreach (var intChar in stringArray)
            {
                stack.Push(intChar);
            }

            foreach (var stackTop in stack)
            {
                result += stackTop.ToString();
            }
            return result;
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToString();
            task2 test = new task2(text);
            Console.WriteLine(test.ReturnReversedString());
            Console.ReadLine();
        }
    }
}
