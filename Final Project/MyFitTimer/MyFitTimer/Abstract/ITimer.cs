using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFitTimer
{
    // interface for timer class
    public interface ITimer
    {
        Task<List<Results>> GetResults();
        void SaveResults();
        void DeleteResults(); 
    }
}
