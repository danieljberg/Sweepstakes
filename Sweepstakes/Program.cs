using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = null;
            Sweepstakes s = new Sweepstakes(test);
            Contestant a = new Contestant();
            Contestant b = new Contestant();
            Contestant c = new Contestant();
            Contestant d = new Contestant();
            Contestant e = new Contestant();
            Contestant f = new Contestant();
            s.RegisterContestant(a);
            s.RegisterContestant(b);
            s.RegisterContestant(c);
            s.RegisterContestant(d);
            s.RegisterContestant(e);
            s.RegisterContestant(f);
            Contestant contestant = s.PickWinner();
            s.PrintContestantInfo(contestant);
            Console.ReadLine();



        }
    }
}
