using System;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int array,  iterating over an array with for loop
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 21;
            numbers[2] = 3;
            numbers[3] = 45;
            numbers[4] = 59;
            Console.WriteLine("Element: {0}", numbers[3]);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("____________________");

            // string array
            string[] names = new string[] { "Arthur", "Bob", "John", "Alex" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("____________________");

            // int array filling with random numbers
            int[] nums = new int[5];
            int summ = 0;
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(5, 15);
                Console.WriteLine("Element: {0}", nums[i]);
                summ = summ + nums[i];
            }
            Console.WriteLine("Summ: {0}", summ);
            Console.WriteLine("____________________");

            // int double array filling with random numbers
            int[,] doubleArray = new int[10, 6];
            Random random2 = new Random();
            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {

                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    doubleArray[i,j] = random2.Next(5, 20);
                    Console.Write(doubleArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
        }
    }
}
