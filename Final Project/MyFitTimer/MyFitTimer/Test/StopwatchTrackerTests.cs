using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using MyFitTimer.Concrete;
using MyFitTimer.Abstract;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Threading.Tasks;
using NSubstitute.Extensions;
using System.Diagnostics;

namespace MyFitTimer.Test
{
    [TestClass]
    public class StopwatchTrackerTests
    {
        private static IStopwatchTracker _timer;
        private static IStopwatchTrackerData _stopwatchTrackerData;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _timer = Substitute.For<IStopwatchTracker>();
            _stopwatchTrackerData = Substitute.For<IStopwatchTrackerData>(); 

            _timer = new StopwatchTracker(_stopwatchTrackerData); 
        }

        [TestMethod]
        public void GetResultsDoesNotReturnNull()
        {
            _stopwatchTrackerData.GetResults()
                .Returns(new List<Time>()); 

            var results = _timer.GetResults(); 
            Assert.IsNotNull(results);
        }
    }
}
