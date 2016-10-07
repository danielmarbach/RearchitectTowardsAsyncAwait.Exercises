using System;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.ResetEvent
{
    [TestFixture]
    public class TestsPart2
    {
        // Additional reading https://msdn.microsoft.com/en-us/library/dd449174(v=vs.110).aspx

        [Test]
        public async Task TwoTasksTaskCompletionSource()
        {
            var tcs = new TaskCompletionSource<object>();

            // TODO: Schedule two tasks, one "waits" for the task completion source 
            // the other one sets the tcs after 2 seconds
            // Let them run in concurrently
            // you may want to use the Output extension method to write something into the console
            // Question: Is Task.Run appropriate here? What else could you use?

            Assert.Inconclusive(nameof(TwoTasksTaskCompletionSource));
        }
    }
}