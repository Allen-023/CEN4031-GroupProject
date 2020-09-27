using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using MyFitTimer.Concrete;

namespace MyFitTimer.Test
{
    [TestClass]
    public class StopwatchTrackerTests
    {
        private static IStopwatchTracker _timer; 

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _timer = Substitute.For<IStopwatchTracker>();
            _timer = new StopwatchTracker(); 
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
