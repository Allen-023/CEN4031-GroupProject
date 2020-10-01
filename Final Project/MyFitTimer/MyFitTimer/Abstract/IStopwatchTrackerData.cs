using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitTimer.Abstract
{
    public interface IStopwatchTrackerData
    {
        Task<List<ResultsContext>> GetResults();
        void SaveResults(Stopwatch stopwatch);
        void DeleteResults();
    }
}
