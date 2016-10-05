using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.ResetEvent
{
    [TestFixture]
    public class TestsPart1
    {
        // Additional reading http://www.albahari.com/threading/part2.aspx#_Signaling_with_Event_Wait_Handles
        // https://msdn.microsoft.com/en-us/library/5hbefs30.aspx

        [Test]
        public async Task TwoTasksThatUseManualResetEvent()
        {
            var syncEvent = new ManualResetEventSlim(false); 

            // TODO: Schedule two tasks, one waits for the sync event 
            // the other one sets the sync event after 2 seconds
            // Let them run in parallel
            // you may want to use the Output extension method to write something into the console

            Assert.Inconclusive(nameof(TwoTasksThatUseManualResetEvent));
        }

        // Bonus: You may want to do the same with AutoResetEvent
    }
}