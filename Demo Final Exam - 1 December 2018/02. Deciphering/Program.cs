namespace _02._Deciphering
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string textToDecipher = Console.ReadLine();
            string[] replaceFirstWithSecond = Console.ReadLine().Split();

            StringBuilder decrypted = new StringBuilder();

            bool isValid = true;

            foreach (var symbol in textToDecipher)
            {
                if ((symbol >= 'd' && symbol <= 'z') || symbol == '#' || symbol == '|' || symbol == ',')
                {
                    decrypted.Append((char)(symbol - 3));
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                string decryptedAsStr = decrypted.ToString();

                string result = decryptedAsStr.Replace(replaceFirstWithSecond[0], replaceFirstWithSecond[1]);

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}
