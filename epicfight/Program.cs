using System;

namespace epicfight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = pickhero();
            string villain = pickvillain();
            int herohp = generatehp(hero);
            int villainhp = generatehp(villain);

            Console.WriteLine($"{hero} will fight {villain}.");

            string heroweapon = pickweapon();
            string villainweapon = pickweapon();
            Console.WriteLine($"{hero} picked {heroweapon}. {villain} picked {villainweapon}.");

            while(herohp > 0 && villainhp > 0)
            {
                herohp = herohp - Hit(villain, hero, villainweapon);
                villainhp = villainhp - Hit(hero, villain, heroweapon);

            }
            if (herohp > 0)
            {
                Console.WriteLine("darkside wins");
            }
            else
            {
                Console.WriteLine($"{hero} saves the day!");
            }

            

        }

        private static int Hit(string charecterone, string charectertwo, string someweapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, someweapon.Length / 2);

            Console.WriteLine($"{charecterone} hit {strike}");
            if(strike == someweapon.Length / 2)
            {
                Console.WriteLine($"awesome! {charectertwo} made a critical hit!");
            }
            else if (strike == 0)
            {
                Console.WriteLine($"{charectertwo} dodged the attack!");
            }
            return strike;

        }




        private static int generatehp(string somename)
        {
            Random rnd = new Random();
            return rnd.Next(somename.Length, somename.Length + 10);
        }

        private static string pickweapon()
        {
            string[] weapon = { "dogge", "beniz", "ak-47", "keyboard", "banana" };
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
