namespace _02._Song_Encryption
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex validationRegex = new Regex(@"^([A-Z][a-z|\s|']+):[A-Z|\s]+\b");

            string input = Console.ReadLine();

            while (input != "end")
            {
                if (validationRegex.IsMatch(input))
                {
                    int encriptyonKey = validationRegex.Match(input).Groups[1].Length;

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (char.IsUpper(input[i]))
                        {
                            sb.Append((char)(65 + ((input[i] + encriptyonKey - 65) % 26)));
                        }
                        else if (char.IsLower(input[i]))
                        {
                            sb.Append((char)(97 + ((input[i] + encriptyonKey - 97) % 26)));
                        }
                        else if (input[i] == ':')
                        {
                            sb.Append('@');
                        }
                        else
                        {
                            sb.Append(input[i]);
                        }
                    }
                    
                    Console.WriteLine($"Successful encryption: {sb.ToString()}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
