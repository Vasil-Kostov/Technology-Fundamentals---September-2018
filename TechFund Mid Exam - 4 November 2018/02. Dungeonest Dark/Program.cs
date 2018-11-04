namespace _02._Dungeonest_Dark
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> rooms = Console.ReadLine()
                                 .Split("|")
                                 .ToList();

            int health = 100;
            int coins = 0;

            int roomCounter = 0;

            foreach (var room in rooms)
            {
                roomCounter++;

                string[] roomData = room.Split();

                if (roomData[0] == "potion")
                {
                    int heal = int.Parse(roomData[1]);

                    if(health == 100)
                    {
                        Console.WriteLine("You healed for 0 hp.");
                    }
                    else if (health + heal > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {heal} hp.");
                        health += heal;
                    }

                    Console.WriteLine($"Current health: {health} hp.");

                }
                else if (roomData[0] == "chest")
                {
                    int foundedCoins = int.Parse(roomData[1]);
                    Console.WriteLine($"You found {foundedCoins} coins.");
                    coins += foundedCoins;
                }
                else
                {
                    string monsterName = roomData[0];
                    int monsterPower = int.Parse(roomData[1]);

                    if (health - monsterPower > 0)
                    {
                        Console.WriteLine($"You slayed {monsterName}.");
                        health -= monsterPower;
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monsterName}.");
                        Console.WriteLine($"Best room: {roomCounter}");
                        return;
                    }
                }
                
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
