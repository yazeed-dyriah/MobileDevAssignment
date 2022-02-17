using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class SecOperation
    {
        public void reverse()
        {
            int number, reverse = 0, reversenum;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                reversenum = number % 10;
                reverse = reverse * 10 + reversenum;
                number /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
