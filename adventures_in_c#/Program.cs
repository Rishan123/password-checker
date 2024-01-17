using System;
class Program
{
    static void Main(string[] args)
    {
        HomeScreen();
    }
    static void HomeScreen()
    {
        string[] allowedChars = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+" };
        Console.WriteLine("Choose 1,2 or 3 out of the options below:");
        Console.WriteLine("(1) Check Password");
        Console.WriteLine("(2) Generate Password");
        Console.WriteLine("(3) Quit");
        string option = Console.ReadLine();
        if (option == "1")
        {
            Console.WriteLine("option 1 chosen - Check Password");
            Console.WriteLine("Enter a password to check:");
            string password = Console.ReadLine();
            for (int i = 0; i < cars.Length; i++)
            {
                if (i.Contains(allowedChars))
                {
                    Console.WriteLine("Password is valid");
                }
            }
            if (password.Length < 8 ^ password.Length > 24)
            {
                Console.WriteLine("Password must be between 8 and 24 characters long");
                HomeScreen();
            }
            else
            {
                Console.WriteLine("your password is fine");
                HomeScreen();
            }
        }
        if (option == "2")
        {
            Console.WriteLine("option 2 chosen");
        }
        if (option == "3")
        {
            Console.WriteLine("Goodbye");
        }
    }
}