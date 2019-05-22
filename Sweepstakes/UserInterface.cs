using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        //member variables


        //constructor


        //member methods
        public static string GetUserFirstName()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            return firstName;
        }
        public static string GetUserLastName()
        {
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public static string GetUserEmail()
        {
            Console.WriteLine("Enter your email address:");
            string email = Console.ReadLine();
            return email;
        }
        public static string GetSweepstakesManager()
        {
            Console.WriteLine("What sweepstakes manager would you like to use:");
            string answer = Console.ReadLine();
            return answer;
        }
    }
}
