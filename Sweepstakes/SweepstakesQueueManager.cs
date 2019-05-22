using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //member variables
        Queue<Sweepstakes> sweepstakesQueue;

        //constructor
        public SweepstakesQueueManager()
        {
            sweepstakesQueue = new Queue<Sweepstakes>();
        }

        //member methods
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakesToGet;
            sweepstakesToGet = sweepstakesQueue.Dequeue();
            return sweepstakesToGet;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }
    }
}
