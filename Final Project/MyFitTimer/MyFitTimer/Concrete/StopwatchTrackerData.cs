using MyFitTimer.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyFitTimer.Concrete
{
    public class StopwatchTrackerData : IStopwatchTrackerData
    {
        public void DeleteResults()
        {
            using (var db = new ResultsContext())
            {
                Console.WriteLine("Deleting the times");
                var times = db.Times
                    .OrderBy(b => b.StartTime);
                foreach(var time in times)
                {
                    db.Remove(time);
                }
                db.SaveChanges();
            }
        }

        // method for getting results 
        public Task<List<Time>> GetResults()
        {
            List<Time> dbResults = new List<Time>(); 
            using (var db = new ResultsContext())
            {   
                //read
                Console.WriteLine("Querying for times");

                dbResults = db.Times
                    .OrderBy(b => b.StartTime).ToList();
            }

            return Task.FromResult(dbResults);
        }

        // method for saving results
        public void SaveResults(Stopwatch stopwatch)
        {
            using (var db = new ResultsContext())
            {
                //write
                var timeEntry = new Time { StartTime = DateTime.Now - stopwatch.Elapsed, EndTime = DateTime.Now, TotalTime = stopwatch.Elapsed };
                db.Add(timeEntry);
                db.SaveChanges();
            }
        }
    }
}
