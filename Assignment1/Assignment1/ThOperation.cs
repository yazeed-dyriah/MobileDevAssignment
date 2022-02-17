using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ThOperation
    {
        public void LargestDigit()
        {
            int number = 0;
            int largestigit = 0;
            int r = 0;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                r = number & 10;
                if (largestigit < r)
                {
                    largestigit = r;
                }
                number = number / 10;
            }
            Console.WriteLine("Largest Digit: " + largestigit);

        }
    }
}
