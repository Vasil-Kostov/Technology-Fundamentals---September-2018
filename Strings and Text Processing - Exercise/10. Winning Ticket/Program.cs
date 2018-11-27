namespace _10._Winning_Ticket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> tickets = Console.ReadLine()
                                   .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                   .ToList();

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    string leftSide = ticket.Substring(0, 10);
                    string rigthtSide = ticket.Substring(10);

                    int length = 0;
                    char symbol = ' ';

                    for (int i = 6; i <= 10; i++)
                    {
                        if (leftSide.Contains(new string('@', i)) && rigthtSide.Contains(new string('@', i)))
                        {
                            length = i;
                            symbol = '@';
                        }
                        else if (leftSide.Contains(new string('#', i)) && rigthtSide.Contains(new string('#', i)))
                        {
                            length = i;
                            symbol = '#';
                        }
                        else if (leftSide.Contains(new string('$', i)) && rigthtSide.Contains(new string('$', i)))
                        {
                            length = i;
                            symbol = '$';
                        }
                        else if (leftSide.Contains(new string('^', i)) && rigthtSide.Contains(new string('^', i)))
                        {
                            length = i;
                            symbol = '^';
                        }
                    }

                    if (length == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol} Jackpot!");
                    }
                    else if (length < 6)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol}");
                    }

                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }                
            }
        }
    }
}
