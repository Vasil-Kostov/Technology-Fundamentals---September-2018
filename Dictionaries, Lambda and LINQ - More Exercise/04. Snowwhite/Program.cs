namespace _04._Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, int> drawfs = new Dictionary<string, int>();

            string inputLine = Console.ReadLine();

            while (inputLine != "Once upon a time")
            {
                string[] inpotArr = inputLine.Split(" <:> ");
                string hairColor = inpotArr[1];
                string name = inpotArr[0];
                int physics = int.Parse(inpotArr[2]);

                string key = $"({hairColor}) {name}";

                if (!drawfs.ContainsKey(key))
                {
                    drawfs.Add(key, 0);
                }

                if (drawfs[key] < physics)
                {
                    drawfs[key] = physics;
                }


                inputLine = Console.ReadLine();
            }

            foreach (var drawf in drawfs.OrderByDescending(kvp => kvp.Value)
                .ThenByDescending(c => drawfs.Where(kvp => kvp.Key.Split(")")[0] == c.Key.Split(")")[0]).Count()))
            {
                Console.WriteLine($"{drawf.Key} <-> {drawf.Value}");
            }

        }
    }
}
