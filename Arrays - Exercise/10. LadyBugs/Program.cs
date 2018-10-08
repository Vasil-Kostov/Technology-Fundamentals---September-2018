namespace _10.LadyBugs
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());

            if (fieldSize == 0)
            {
                return;
            }

            int[] field = new int[fieldSize];
            int[] indexesOfLadyBygs = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .Where(i => i >= 0 && i < fieldSize)
                                      .ToArray();

            for (int i = 0; i < indexesOfLadyBygs.Length; i++)
            {
                field[indexesOfLadyBygs[i]] = 1;
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currentComand = command.Split();
                int index = int.Parse(currentComand[0]);
                string direction = currentComand[1];
                int flyLength = int.Parse(currentComand[2]);

                if (index >= 0 && index < fieldSize)
                {
                    if (direction == "left")
                    {
                        flyLength = -flyLength;
                    }

                    Fly(field, index, flyLength);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));

        }

        static void Fly(int[] field, int index, int flyLength)
        {
            if (field[index] == 1 && flyLength != 0)
            {
                field[index] = 0;



                bool notLended = true;
                bool notOutOfField = true;

                while (notLended && notOutOfField)
                {
                    if (index + flyLength < 0 || index + flyLength >= field.Length)
                    {
                        notOutOfField = false;
                    }
                    else
                    {
                        if (field[index + flyLength] == 0)
                        {
                            field[index + flyLength] = 1;
                            notOutOfField = false;
                        }
                        else
                        {
                            index = index + flyLength;
                        }

                    }

                }

            }
        }
    }
}