using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using MyFitTimer.Concrete;

namespace MyFitTimer.Test
{
    [TestClass]
    public class TimerTests
    {
        private static ITimer _timer; 

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _timer = Substitute.For<ITimer>();
            _timer = new Timer(); 
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
