using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class FthOperation
    {
        public void FirstNumber()
        {

            string str1 = Console.ReadLine();

            string str2 = string.Empty;
            int val = 0;
            Console.WriteLine($"String with number: {str1}");
            for (int i = 0; i < str1.Length; i++)
            {
                if (Char.IsDigit(str1[i]))
                    str2 += str1[i];
            }
            if (str2.Length > 0)
                val = int.Parse(str2);
            Console.WriteLine($"Extracted Number: {val}");
            Console.ReadLine();
        }
    }
}
