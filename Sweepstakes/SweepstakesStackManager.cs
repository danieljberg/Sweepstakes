using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //member variables
        Stack<Sweepstakes> sweepstakesStack;

        //constructor
        public SweepstakesStackManager()
        {
            sweepstakesStack = new Stack<Sweepstakes>();
        }
        

        //member methods
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakesToGet;
            sweepstakesToGet = sweepstakesStack.Pop();
            return sweepstakesToGet;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }
    }
}
