namespace _08._Greater_of_Two_Values
{
    using System;

    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string firstVariable = Console.ReadLine();
            string secondVariable = Console.ReadLine();

            Console.WriteLine(GetGreaterOfTwoVariables(type, firstVariable, secondVariable));
        }

        static string GetGreaterOfTwoVariables(string type, string firstVariable, string secondVariable)
        {
            string result = string.Empty;

            switch (type)
            {
                case "int":
                    result = Math.Max(int.Parse(firstVariable), int.Parse(secondVariable)).ToString();
                    break;
                case "char":
                    result = firstVariable[0] > secondVariable[0] ? firstVariable : secondVariable;
                    break;
                case "string":
                    result = GetGreatherString(firstVariable, secondVariable);
                    break;
                default:
                    break;
            }

            return result;
        }

        static string GetGreatherString(string firstVariable, string secondVariable)
        {
            int shoreterLength = Math.Min(firstVariable.Length, secondVariable.Length);

            for (int i = 0; i < shoreterLength; i++)
            {
                if (firstVariable[i] > secondVariable[i])
                {
                    return firstVariable;
                }
                else if (secondVariable[i] > firstVariable[i])
                {
                    return secondVariable;
                }
            }

            return firstVariable.Length > secondVariable.Length ? firstVariable : secondVariable;
        }
    }
}
