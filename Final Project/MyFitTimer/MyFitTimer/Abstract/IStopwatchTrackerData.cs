using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MyFitTimer.Abstract
{
    public interface IStopwatchTrackerData
    {
        Task<List<Time>> GetResults();
        void SaveResults(Stopwatch stopwatch);
        void DeleteResults();
    }
}
