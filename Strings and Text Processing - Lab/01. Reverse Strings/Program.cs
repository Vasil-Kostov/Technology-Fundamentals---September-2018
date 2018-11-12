namespace _01._Reverse_Strings
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string reversed = new string(input.Reverse().ToArray());

                Console.WriteLine($"{input} = {reversed}");

                input = Console.ReadLine();
            }
        }  
    }
}
