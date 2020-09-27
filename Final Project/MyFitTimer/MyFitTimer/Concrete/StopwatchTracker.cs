using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFitTimer.Concrete
{
    public class StopwatchTracker : IStopwatchTracker
    {
        // generic constructor for timer class
        public StopwatchTracker()
        {

        }

        // method for deleting results
        public void DeleteResults()
        {
            throw new NotImplementedException();
        }

        // method for getting results 
        public Task<List<Results>> GetResults()
        {
            List<Results> timerRuns = new List<Results>();

            Results firstRun = new Results();
            Results secondRun = new Results();

            timerRuns.Add(firstRun);
            timerRuns.Add(secondRun); 

            return Task.FromResult(timerRuns); 
        }

        // method for saving results
        public void SaveResults()
        {
            throw new NotImplementedException();
        }       
    }
}
