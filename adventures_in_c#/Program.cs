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
        bool validity = true;
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
            foreach (char i in password)
            {
                for (int j = 0; j < allowedChars.Length; j++)
                {
                    Console.WriteLine(i.ToString());
                    /*
                    if (i.ToString() == (allowedChars[j]))
                    {
                        //Console.WriteLine("Password is valid");
                    }
                    */
                    if (i.ToString() != (allowedChars[j]))
                    {
                        //Console.WriteLine("that is invalid");
                        validity = false;
                    }
                    Console.WriteLine(validity);
                }
 
            }
            if (validity == true)
            {
                Console.WriteLine("the characters are valid valid");
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
            else if (validity == false)
            {
                Console.WriteLine("password is invalid");
            }
            /*
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
            */
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