using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the array with given numbers 
            int[] numbers = new int[6] { 1, 1, 2, 3, 5, 8 };

            //create a loop to print each number
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();



        }
    }
}
