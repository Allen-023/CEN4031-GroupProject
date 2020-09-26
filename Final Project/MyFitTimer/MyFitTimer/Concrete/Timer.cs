using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitTimer.Concrete
{
    public class Timer : ITimer
    {
        public void DeleteTimerRuns()
        {
            throw new NotImplementedException();
        }

        public Task<List<TimerRuns>> GetTimerRuns()
        {
            List<TimerRuns> timerRuns = new List<TimerRuns>();

            TimerRuns firstRun = new TimerRuns();
            TimerRuns secondRun = new TimerRuns();

            timerRuns.Add(firstRun);
            timerRuns.Add(secondRun); 

            return Task.FromResult(timerRuns); 
        }

        public void SaveTimerRuns()
        {
            throw new NotImplementedException();
        }       
    }
}
