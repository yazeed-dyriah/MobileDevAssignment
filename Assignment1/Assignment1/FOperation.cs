using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class FOperation
    {
        public void FindNumber()
        {
            int count = 0;
            Console.WriteLine("Enter Total Number of Integers\n");
            count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];

            Console.WriteLine("Enter the numbers\n");
            for (int temp = 0; temp < count; temp++)
            {
                numbers[temp] = int.Parse(Console.ReadLine());
            }

            int largest = numbers[0];
            for (int big = 1; big < numbers.Length; big++)
            {
                if (largest < numbers[big])
                {
                    largest = numbers[big];
                }
            }
            Console.WriteLine("The Largest Number Is: ");
            Console.WriteLine(largest);
            Console.ReadKey();
        }
    }
}
