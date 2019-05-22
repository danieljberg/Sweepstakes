using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //member variables
        string name;        
        Random random;
        Dictionary<int, Contestant> contestantsDictionary;

        //constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestantsDictionary = new Dictionary<int, Contestant>();
        }

        //member methods

        public void RegisterContestant(Contestant contestant)
        {            
            contestant.registrationNumber = contestantsDictionary.Count + 1;
            contestantsDictionary.Add(contestant.registrationNumber, contestant);
        }
        public string PickWinner()
        {
            Contestant result;
            random = new Random();
            int randomNumber = random.Next(contestantsDictionary.Count + 1);
            contestantsDictionary.TryGetValue(randomNumber, out result);
            string winner = result.firstName + " " + result.lastName;
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.email);
        }
    }
}
