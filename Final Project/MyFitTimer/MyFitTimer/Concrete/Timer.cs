using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitTimer.Concrete
{
    public class Timer : ITimer
    {
        public Timer()
        {

        }

        public void DeleteResults()
        {
            throw new NotImplementedException();
        }

        public Task<List<Results>> GetResults()
        {
            List<Results> timerRuns = new List<Results>();

            Results firstRun = new Results();
            Results secondRun = new Results();

            timerRuns.Add(firstRun);
            timerRuns.Add(secondRun); 

            return Task.FromResult(timerRuns); 
        }

        public void SaveResults()
        {
            throw new NotImplementedException();
        }       
    }
}
