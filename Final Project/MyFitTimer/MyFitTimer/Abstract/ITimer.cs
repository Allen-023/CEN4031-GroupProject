using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitTimer
{
    public interface ITimer
    {
        Task<List<Results>> GetResults();
        void SaveResults();
        void DeleteResults(); 

    }
}
