using System;
class Program
{
    static void Main(string[] args)
    {
        HomeScreen();
    }
    static void calculateScore(string validPassword)
    {
        int score = validPassword.Length;
        bool hasUpper = false;
        foreach (char i in validPassword)
        {
            if (hasUpper == false)
            {
                if (Char.IsUpper(i))
                {
                    Console.WriteLine("Character is uppercase");
                    score = score + 5;
                    hasUpper = true;
                }
            }
            /*
            if (Char.IsLower(i))
            {
                score = score + 5;
            }
            */
        }
        Console.WriteLine(score);
    }
    static void HomeScreen()
    {
        string[] allowedChars = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+","A" ,"B", "C", "D", "E", "F", "G", "H", "I", "J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        bool charvalidity = true;
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
                    //Console.WriteLine(i.ToString());
                    /*
                    if (i.ToString() == (allowedChars[j]))
                    {
                        //Console.WriteLine("Password is valid");
                    }
                    */
                    if (i.ToString() != (allowedChars[j]))
                    {
                        //Console.WriteLine("that is invalid");
                        charvalidity = false;
                    }
                    else if (i.ToString() == (allowedChars[j]))
                    {
                        charvalidity = true;
                        break;
                    }
                }
            }
            if (charvalidity == true)
            {
                //Console.WriteLine("the characters are valid");
                if (password.Length < 8 ^ password.Length > 24)
                {
                    Console.WriteLine("Password must be between 8 and 24 characters long");
                    //HomeScreen();
                }
                else
                {
                    Console.WriteLine("the characters and length of the password is fine");
                    calculateScore(password);
                    //HomeScreen();
                }
            }
            else if (charvalidity == false)
            {
                Console.WriteLine("the characters are invalid");
            }
            HomeScreen();
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