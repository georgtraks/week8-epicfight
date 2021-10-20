using System;

namespace functionswitharrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green" };
            string randomcolor = pickrandomcolor(colors);
            Console.WriteLine($"arvuti valis {randomcolor}.");
            DisplayRandomColor(colors);
        }


        private static int generaterandomnumberforarray(string[]somearray)
        {
            Random rnd = new Random();
            return rnd.Next(0, somearray.Length);
        }

        private static string pickrandomcolor(string[] somearray)
        {
            return somearray[generaterandomnumberforarray(somearray)];
        }



        private static void DisplayRandomColor(string[] somearray)
        {
            Console.WriteLine(somearray[generaterandomnumberforarray(somearray)]);
        }



    }
}
