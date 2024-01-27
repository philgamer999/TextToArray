using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToArray
{
    internal class Program
    {
        static string sepSym = ",";
        static void Main(string[] args)
        {
            ArrayCreator();
        }

        private static void ArrayCreator()
        {
            Console.WriteLine($"The current seperation character is \"{sepSym}\".");
            Console.WriteLine($"Insert your desired character or NULL.");
            string ans = Console.ReadLine();
            if (ans != "NULL")
            {
                sepSym = ans;
            }
            Console.WriteLine($"");
            Console.WriteLine($"Input your list Format: [Item{sepSym}Item{sepSym}Item{sepSym}]");
            Console.WriteLine(Array(Console.ReadLine()));

            Console.WriteLine($"");
            Console.WriteLine($"Press any key to exit.");
            Console.ReadKey();
        }

        private static string Array(string input)
        {
            string output = "{";
            char[] chars = input.ToCharArray();
            string tempString = "";
            int i = 0;

            foreach (char c in chars)
            {
                if (c.ToString() != sepSym)
                {
                    tempString = tempString + c.ToString();
                }
                else if (c.ToString() == sepSym && i == chars.Length - 1)
                {
                    output = output + " \"" + tempString + "\" }";
                    return output;
                }
                else
                {
                    output = output + " \"" + tempString + "\",";
                    tempString = "";
                }
                i++;
            }

            return output;
        }
    }
}
