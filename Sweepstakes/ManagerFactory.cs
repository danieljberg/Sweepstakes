using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ManagerFactory
    {
        public ISweepstakesManager GenerateSweepstakesManager(string choice)
        {
            switch (choice)
            {
                case "Queue":
                    SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
                    return queueManager;
                case "Stack":
                    SweepstakesStackManager stackManager = new SweepstakesStackManager();
                    return stackManager;
                default:
                    throw new ApplicationException(string.Format("Not a valid manager"));

            }
        }
        
    }
}
