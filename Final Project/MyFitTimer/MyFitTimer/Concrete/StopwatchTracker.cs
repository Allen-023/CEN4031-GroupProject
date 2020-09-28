using MyFitTimer.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFitTimer.Concrete
{
    public class StopwatchTracker : IStopwatchTracker
    {
        private readonly IStopwatchTrackerData _stopwatchTrackerData;

        // generic constructor for timer class
        public StopwatchTracker(IStopwatchTrackerData stopwatchTrackerData)
        {
            _stopwatchTrackerData = stopwatchTrackerData;
        }

        // method for deleting results
        public void DeleteResults()
        {
            _stopwatchTrackerData.DeleteResults(); 
        }

        // method for getting results 
        public Task<List<Results>> GetResults()
        {
            return _stopwatchTrackerData.GetResults();  
        }

        // method for saving results
        public void SaveResults()
        {
            _stopwatchTrackerData.SaveResults(); 
        }       
    }
}
