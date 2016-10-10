using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.ResetEvent
{
    [TestFixture]
    public class TestsPart3
    {
        [Test]
        public async Task TwoTasksWithAsyncManualResetEvent()
        {
            var tcs = new TaskCompletionSource<object>();

            // TODO: Schedule two tasks, one "waits" for the manual reset event 
            // the other one sets the tcs after 2 seconds
            // Let them run in concurrently
            // you may want to use the Output extension method to write something into the console
            // Question: Is Task.Run appropriate here? What else could you use?

            Assert.Inconclusive(nameof(TwoTasksWithAsyncManualResetEvent));
        }
    }
}