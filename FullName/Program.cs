using System;

namespace FullName
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Asks the user for their first name and assigns it to firstName variable.
            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            //Asks user their last name and assigns it to lastName variable.
            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            //Prints "Your name backwards: " with the user's name spelled backwards on the same line.
            Console.Write("Your name backwards: ");
            ReverseString(firstName);
            ReverseString(lastName);

            Console.ReadLine();
        }
        //New method created to properly reverse the user's name.
        private static void ReverseString(string message)
        {//Copies each character in the message array (first and last name) and reverses it, then writes it to the console.
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write(" ");
        }
    }
}
