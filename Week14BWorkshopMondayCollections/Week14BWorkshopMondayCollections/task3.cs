using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14BWorkshopMondayCollections
{
    class task3
    {
        Dictionary<string,string> pairs = new Dictionary<string, string>();
        char[] stringArray;


        public task3(string textConvert)
        {
            this.stringArray = textConvert.ToCharArray();
        }

        public string Convert()
        {
            string result = "";
            pairs.Add("1", "One");
            pairs.Add("2", "Two");
            pairs.Add("3", "Three");
            pairs.Add("4", "Four");
            pairs.Add("5", "Five");
            pairs.Add("6", "Six");
            pairs.Add("7", "Seven");
            pairs.Add("8", "Eight");
            pairs.Add("9", "Nine");
            foreach (var character in stringArray)
            {
                if (pairs.ContainsKey(character.ToString()))
                {
                    result += pairs[character.ToString()];
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToString();
            task3 test = new task3(text);
            Console.WriteLine(test.Convert());
            Console.ReadLine();
        }
    }
}
