using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFitTimer
{
    // interface for timer class
    public interface IStopwatchTracker
    {
        Task<List<Results>> GetResults();
        void SaveResults();
        void DeleteResults(); 
    }
}
