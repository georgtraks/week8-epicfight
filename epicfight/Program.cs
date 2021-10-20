using System;

namespace epicfight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = pickhero();
            string villain = pickvillain();
            Console.WriteLine($"{hero} will fight {villain}.");

            string heroweapon = pickweapon();
            string villainweapon = pickweapon();
            Console.WriteLine($"{hero} will fight {villain}.");

        }
        private static string pickweapon()
        {
            string[] weapon = { "hamer", "hands", "bat", "bomb", "banana" };
            Random rnd = new Random();
            int randomindex = rnd.Next(0, weapon.Length);

            return weapon[randomindex];
        }
       
        


        private static string pickhero()
        {
            string[] superheroes = { "mihail wazovsky", "muhmad machmarad", "stalin", "su ema", "joe" };
            Random rnd = new Random();
            int randomindex = rnd.Next(0, superheroes.Length);

            return superheroes[randomindex];
        }
        private static string pickvillain()
        {
            string[] villain = { "piderman", "ahmed", "hitler", "thanos", "kevin" };
            Random rnd = new Random();
            int randomindex = rnd.Next(0, villain.Length);

            return villain[randomindex];
        }

    }
}
