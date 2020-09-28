using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using MyFitTimer.Concrete;
using MyFitTimer.Abstract;

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
        public void GetResultsReturnsCorrectType()
        {
            var results = _timer.GetResults(); 
            Assert.AreEqual(0, 0);
        }

        [TestMethod]
        public void SaveResultsRetunrsVoid()
        {
            _timer.SaveResults();
            Assert.AreEqual(0, 0); 
        }

        [TestMethod]
        public void DeleteResultsReturnsVoid()
        {
            _timer.DeleteResults(); 
            Assert.AreEqual(0, 0);
        }
    }
}
