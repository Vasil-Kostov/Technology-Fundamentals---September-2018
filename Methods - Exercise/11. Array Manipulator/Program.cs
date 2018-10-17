namespace _11._Array_Manipulator
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandSequence = command.Split();

                switch (commandSequence[0])
                {
                    case "exchange":
                        array = ExchageTheSubArrays(commandSequence[1], array);
                        break;
                    case "max":
                        PrintIndexOfMaxEvenOrOdd(array, commandSequence[1]);
                        break;
                    case "min":
                        PrintIndexOfMinEvenOrOdd(array, commandSequence[1]);
                        break;
                    case "first":
                        PrintFirsNEvensOrOdds(array, commandSequence[1], commandSequence[2]);
                        break;
                    case "last":
                        PrintLastNEvensOrOdds(array, commandSequence[1], commandSequence[2]);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static void PrintLastNEvensOrOdds(int[] array, string numberOfMatches, string evensOrOdds)
        {
            int remainder = evensOrOdds == "even" ? 0 : 1;
            int count = int.Parse(numberOfMatches);
            int[] reversed = array.Reverse().ToArray();

            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] lastNEvensOrOdds = reversed.Where(n => n % 2 == remainder).ToArray();

                if (lastNEvensOrOdds.Length <= count)
                {
                    Console.WriteLine($"[{string.Join(", ", lastNEvensOrOdds.Reverse())}]");
                }
                else
                {
                    int[] result = new int[count];

                    for (int i = 0; i < count; i++)
                    {
                        result[i] = lastNEvensOrOdds[i];
                    }

                    Console.WriteLine($"[{string.Join(", ",result.Reverse())}]");

                }
            }

        }

        private static void PrintFirsNEvensOrOdds(int[] array, string numberOfMatches, string evensOrOdds)
        {
            int remainder = evensOrOdds == "even" ? 0 : 1;
            int count = int.Parse(numberOfMatches);

            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] firstNEvensOrOdds = array.Where(n => n % 2 == remainder).ToArray();

                if (firstNEvensOrOdds.Length <= count)
                {
                    Console.WriteLine($"[{string.Join(", ", firstNEvensOrOdds)}]");
                }
                else
                {
                    Console.Write("[");
                    for (int i = 0; i < count; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write(firstNEvensOrOdds[i]);
                        }
                        else
                        {
                            Console.Write($", {firstNEvensOrOdds[i]}");
                        }

                    }
                    Console.WriteLine("]");
                }
            }

        }

        private static void PrintIndexOfMinEvenOrOdd(int[] array, string evenOrOdd)
        {
            int remainder = evenOrOdd == "even" ? 0 : 1;

            bool doesItContainsAny = DoesTheArrayContainsEevenOrOdd(array, remainder);

            if (!doesItContainsAny)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                if (remainder == 0)
                {
                    Console.WriteLine(LastIdexOfMinEvenOrOdd(array, 0));
                }
                else
                {
                    Console.WriteLine(LastIdexOfMinEvenOrOdd(array, 1));
                }
            }
        }

        private static string LastIdexOfMinEvenOrOdd(int[] array, int remainder)
        {
            int lastIndex = 0;
            int[] evensOrOdds = array.Where(n => n % 2 == remainder).ToArray();
            int minEvenOrOdd = evensOrOdds.Min();
            int[] reversed = array.Reverse().ToArray();

            for (int i = 0; i < reversed.Length; i++)
            {
                if (reversed[i] == minEvenOrOdd)
                {
                    lastIndex = reversed.Length - i - 1;
                    break;
                }
            }

            return lastIndex.ToString();
        }

        private static void PrintIndexOfMaxEvenOrOdd(int[] array, string evenOrOdd)
        {
            int remainder = evenOrOdd == "even" ? 0 : 1;

            bool doesItContainsAny = DoesTheArrayContainsEevenOrOdd(array, remainder);

            if (!doesItContainsAny)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                if (remainder == 0)
                {
                    Console.WriteLine(LastIdexOfMaxEvenOrOdd(array, 0));
                }
                else
                {
                    Console.WriteLine(LastIdexOfMaxEvenOrOdd(array, 1));
                }
            }

        }

        private static string LastIdexOfMaxEvenOrOdd(int[] array, int remainder)
        {
            int lastIndex = 0;
            int[] evensOrOdds = array.Where(n => n % 2 == remainder).ToArray();
            int maxEvenOrOdd = evensOrOdds.Max();
            int[] reversed = array.Reverse().ToArray();

            for (int i = 0; i < reversed.Length; i++)
            {
                if (reversed[i] == maxEvenOrOdd)
                {
                    lastIndex = reversed.Length - i - 1;
                    break;
                }
            }

            return lastIndex.ToString();

        }

        private static bool DoesTheArrayContainsEevenOrOdd(int[] array, int remainder)
        {
            if (remainder == 0)
            {
                if (array.Any(n => n % 2 == 0))
                {
                    return true;
                }
            }
            else
            {
                if (array.Any(n => n % 2 != 0))
                {
                    return true;
                }
            }

            return false;

        }

        private static int[] ExchageTheSubArrays(string lastIndexOfFirstSubArr, int[] array)
        {
            int lastIndex = int.Parse(lastIndexOfFirstSubArr);

            if (lastIndex > array.Length - 1 || lastIndex < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                if (lastIndex < array.Length - 1)
                {
                    int[] firstSubArray = new int[lastIndex + 1];
                    int[] secondSubArray = new int[array.Length - firstSubArray.Length];

                    for (int i = 0; i < firstSubArray.Length; i++)
                    {
                        firstSubArray[i] = array[i];
                    }
                    for (int i = 0; i < secondSubArray.Length; i++)
                    {
                        secondSubArray[i] = array[i + firstSubArray.Length];
                    }

                    for (int i = 0; i < secondSubArray.Length; i++)
                    {
                        array[i] = secondSubArray[i];
                    }
                    for (int i = 0; i < firstSubArray.Length; i++)
                    {
                        array[i + secondSubArray.Length] = firstSubArray[i];
                    }
                }
            }

            return array;
        }
    }
}
