using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double cost = 0;

            switch (groupType)
            {
                case "Students":
                    if (dayOfTheWeek == "Friday")
                    {
                        cost = numberOfPeople * 8.45;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        cost = numberOfPeople * 9.80;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        cost = numberOfPeople * 10.46;
                    }

                    if (numberOfPeople >= 30)
                    {
                        cost *= 0.85;
                    }
                    break;

                case "Business":
                    if (numberOfPeople >= 100)
                    {
                        numberOfPeople -= 10;
                    }

                    if (dayOfTheWeek == "Friday")
                    {
                        cost = numberOfPeople * 10.90;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        cost = numberOfPeople * 15.60;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        cost = numberOfPeople * 16;
                    }
                    break;

                case "Regular":
                    if (dayOfTheWeek == "Friday")
                    {
                        cost = numberOfPeople * 15;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        cost = numberOfPeople * 20;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        cost = numberOfPeople * 22.50;
                    }

                    if (numberOfPeople >= 10 && numberOfPeople <= 20)
                    {
                        cost *= 0.95;
                    }
                    break;

                default:
                    break;
            }

            Console.WriteLine($"Total price: {cost:F2}");

        }
    }
}