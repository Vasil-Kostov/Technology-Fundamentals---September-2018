namespace _03._Substring
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string firstStr = Console.ReadLine().ToLower();
            string secondStr = Console.ReadLine().ToLower();

            bool isThereMoreMatches = true;

            while (isThereMoreMatches)
            {
                if (secondStr.Contains(firstStr))
                {
                    secondStr = secondStr.Remove(secondStr.IndexOf(firstStr), firstStr.Length);
                }
                else
                {
                    isThereMoreMatches = false;
                }
            }
            
            Console.WriteLine(secondStr);
        }
    }
}
