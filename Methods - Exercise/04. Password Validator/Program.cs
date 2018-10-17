namespace _04._Password_Validator
{
    using System;

    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            CheckIfPaswordIsValid(password);

        }

        private static void CheckIfPaswordIsValid(string password)
        {
            bool enaughChars = CheckIfContansEnoughCharactars(password);
            bool consistOnlyLetersEndDigit = CheckIfConsistOnlyLetersAndDigits(password);
            bool etleastTwoDigits = ChesckIfContainsEtleastTwoDigits(password);

            if (enaughChars && consistOnlyLetersEndDigit && etleastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!enaughChars)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!consistOnlyLetersEndDigit)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!etleastTwoDigits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool ChesckIfContainsEtleastTwoDigits(string password)
        {
            int digits = 0;

            foreach (var symbol in password)
            {
                if (symbol >= '0' && symbol <= '9')
                {
                    digits++;

                    if (digits >= 2)
                    {
                        return true;
                    }
                }
            }

            return false;
        
        }

        private static bool CheckIfConsistOnlyLetersAndDigits(string password)
        {
            foreach (var symbol in password)
            {
                if (!(symbol >= 'a' && symbol <= 'z'|| symbol >= 'A' && symbol <= 'Z' || symbol >= '0' && symbol <= '9'))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckIfContansEnoughCharactars(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }
    }
}
