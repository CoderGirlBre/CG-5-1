using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for their first name and assigns it to firstName variable.
            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            //Asks user their last name and assigns it to lastName variable.
            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            //Prepares a spot to fill in the user's full name.
            Console.Write("Full name: " + Welcome(firstName, lastName));
                       

            Console.ReadLine();
        }//New method.
        private static string Welcome(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
