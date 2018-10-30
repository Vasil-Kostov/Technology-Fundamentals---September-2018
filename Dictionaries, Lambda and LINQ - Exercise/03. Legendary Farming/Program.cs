namespace _03._Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("fragments", 0);
            materials.Add("shards", 0);
            materials.Add("motes", 0);

            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool legendaryItemObtained = false;
            string legendaryItemObtainedFrom = string.Empty;

            while (!legendaryItemObtained)
            {
                string[] inputLine = Console.ReadLine().Split();

                for (int i = 0; i < inputLine.Length - 1; i += 2) 
                {
                    string material = inputLine[i + 1].ToLower();
                    int quantity = int.Parse(inputLine[i]);

                    if (materials.ContainsKey(material))
                    {
                        materials[material] += quantity;

                        if (materials[material] >= 250)
                        {
                            legendaryItemObtained = true;
                            legendaryItemObtainedFrom = material;
                            break;
                        }

                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }

                        junk[material] += quantity;

                    }
                }
            }

            PrintTheLegendaryItem(legendaryItemObtainedFrom, materials);

            PrintRemainingMaterialsAndJunk(materials, junk);

        }

        private static void PrintRemainingMaterialsAndJunk(Dictionary<string, int> materials, Dictionary<string, int> junk)
        {
            foreach (var kvp in materials.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }

        private static void PrintTheLegendaryItem(string legendaryItemObtainedFrom, Dictionary<string, int> materials)
        {
            if (legendaryItemObtainedFrom == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (legendaryItemObtainedFrom == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (legendaryItemObtainedFrom == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
            
            materials[legendaryItemObtainedFrom] -= 250;
        }
    }
}
