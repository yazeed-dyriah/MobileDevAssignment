using System;
using Assignment1;

namespace Assignment1
{
    class Assigument1
    {
        static public void Main(String[] args)
        {
            Console.WriteLine("1.Operation: Find Largest Number Among given numbers by users.");
            Console.WriteLine("2.Operation: reverse a given number");
            Console.WriteLine("3.Operation: find the largest digit of a number");
            Console.WriteLine("4.Operation: search for the first int number inside a given text by user.");

            FOperation X = new FOperation();
            SecOperation Y = new SecOperation();
            ThOperation Z = new ThOperation();
            FthOperation C = new FthOperation();

            int Choice = 0;
            Console.WriteLine("Please choose the number of oberation: ");

        Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    X.FindNumber();
                    break;

                case 2:
                    Y.reverse();
                    break;
            
                case 3:
                    Z.LargestDigit();
                    break;

                case 4:
                    C.FirstNumber();
                    break;
                   
            }
        }
    }
}