namespace _03._Quests_Journal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> quests = Console.ReadLine()
                                  .Split(", ")
                                  .ToList();

            string input = Console.ReadLine();

            while (input != "Retire!")
            {
                string[] inputArr = input.Split(" - ");

                string command = inputArr[0];
                string quest = inputArr[1];

                switch (command)
                {
                    case "Start":
                        if (!quests.Contains(quest))
                        {
                            quests.Add(quest);
                        }
                        break;

                    case "Complete":
                        if (quests.Contains(quest))
                        {
                            quests.Remove(quest);
                        }
                        break;

                    case "Side Quest":
                        string[] questArr = quest.Split(':');
                        quest = questArr[0];
                        string sideQuest = questArr[1];

                        if (quests.Contains(quest))
                        {
                            int index = quests.IndexOf(quest);

                            if (!quests.Contains(sideQuest))
                            {
                                quests.Insert(index + 1, sideQuest);
                            }
                        }
                        break;

                    case "Renew":
                        if (quests.Contains(quest))
                        {
                            quests.Remove(quest);
                            quests.Add(quest);
                        }
                        break;

                    default:
                        break;
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", quests));
        }
    }
}
