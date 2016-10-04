using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.Events
{
    [TestFixture]
    public class TestsPart2
    {
        [Test]
        public void AwaitInsideSimpleEvent_Success()
        {
            // TODO: Use existing event raiser to raise a simple event
            // TODO: Call asynchronous Methods.SuccessAsync method and await outcome
            Assert.Inconclusive(nameof(AwaitInsideSimpleEvent_Success));
        }

        [Test]
        public void AwaitInsideSimpleEvent_ThrowsSync()
        {
            // TODO: Use existing event raiser to raise a simple event
            // TODO: Call asynchronous Methods.ThrowsSync() method and await outcome
            Assert.Inconclusive(nameof(AwaitInsideSimpleEvent_ThrowsSync));
        }

        [Test]
        public void AwaitInsideSimpleEvent_ThrowsAsync()
        {
            // TODO: Use existing event raiser to raise a simple event
            // TODO: Call asynchronous Methods.ThrowsAsync() method and await outcome
            Assert.Inconclusive(nameof(AwaitInsideSimpleEvent_ThrowsAsync));
        }

        class EventRaiser
        {
            // TODO: How would you declare the events

            public Task RaiseSimpleEvent()
            {
                // TODO: How would you raise the event
                return Task.CompletedTask;
            }

            public Task RaiseComplexEvent()
            {
                // TODO: How would you raise the event
                return Task.CompletedTask;
            }

            // TODO: Bonus

            public Task RaiseSimpleEventConcurrent()
            {
                // TODO: How would you raise the event
                return Task.CompletedTask;
            }

            public Task RaiseComplexEventConcurrent()
            {
                // TODO: How would you raise the event
                return Task.CompletedTask;
            }
        }

        class CustomEventArgs : EventArgs
        {
        }
    }
}