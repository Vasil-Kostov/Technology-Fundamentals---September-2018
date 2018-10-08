namespace _09.Poke_Mon
{
    using System;

    class Program
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetwenTargets = int.Parse(Console.ReadLine());
            int exhoustionFactor = int.Parse(Console.ReadLine());

            decimal halfOfPower = pokePower / 2m;

            int pokedTargets = 0;

            while (pokePower >= distanceBetwenTargets)
            {
                pokePower -= distanceBetwenTargets;

                pokedTargets++;

                if (pokePower == halfOfPower)
                {
                    if (exhoustionFactor != 0)
                    {
                        pokePower /= exhoustionFactor;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargets);
        }
    }
}