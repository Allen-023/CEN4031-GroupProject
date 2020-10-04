using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MyFitTimer
{
    // interface for timer class
    public interface IStopwatchTracker
    {
        Task<List<Time>> GetResults();
        void SaveResults(Stopwatch stopwatch);
        void DeleteResults(); 
    }
}
