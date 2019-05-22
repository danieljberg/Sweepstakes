using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
     public class Contestant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;

        //constructor
        public Contestant()
        {
            GenerateRegistrationNumber();
            firstName = UserInterface.GetUserFirstName();
            lastName = UserInterface.GetUserLastName();
            email = UserInterface.GetUserEmail();

        }

        //member methods
        public int GenerateRegistrationNumber()
        {
            registrationNumber++;
            return registrationNumber;
        }
    }
}
