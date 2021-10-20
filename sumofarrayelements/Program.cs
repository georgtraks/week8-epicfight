using System;

namespace sumofarrayelements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7000, 5000, 1000, 6000, 10000, 10000, 2475294, 5000 };
            Console.WriteLine($"sum of all elements: {sumofelements(numbers)}");
        }

        private static int sumofelements(int[] somearray)
        {
            int sum = 0;

            for(int i = 0; i < somearray.Length; i++)
            {
                sum = sum + somearray[i];
            }

            return sum;
        }
    }
}
