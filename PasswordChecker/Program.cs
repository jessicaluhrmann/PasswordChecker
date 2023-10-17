using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            var minLength = 8;
            var uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var lowercase = "abcdefghijklmnopqrstuvwxyz";
            var digits = "0123456789";
            var specialChars = "!@#$%^&*()-_+=?/\\.,><~;:\'\"";
            var score = 0;

            Console.WriteLine("Enter a password:");
            var password = Console.ReadLine();

            if (password.Length >= minLength)
            {
                score++;
            };

            if (Tools.Contains(password, uppercase))
            {
                score++;
            };

            if (Tools.Contains(password, lowercase))
            {
                score++;
            };

            if (Tools.Contains(password, digits))
            {
                score++;
            };

            if (Tools.Contains(password, specialChars))
            {
                score++;
            };



            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Your password is extremely strong");
                    break;

                case 3:
                    Console.WriteLine("Your password is strong");
                    break;

                case 2:
                    Console.WriteLine("Your password is medium");
                    break;

                case 1:
                    Console.WriteLine("Your password is weak");
                    break;

                default:
                    Console.WriteLine("Your password doesn't meet any of the standards");
                    break;
            }
        }
    }
}