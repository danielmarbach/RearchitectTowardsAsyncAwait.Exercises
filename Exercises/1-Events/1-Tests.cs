using System;
using NUnit.Framework;

namespace Exercises.Events
{
    [TestFixture]
    public class TestsPart1
    {
        [Test]
        public void AwaitInsideSimpleEvent_Success()
        {
            // TODO: Use existing event raiser to attach an EventHandler and raise a simple event
            // TODO: Within EventHandler call asynchronous Methods.SuccessAsync method and await outcome
            Assert.Inconclusive(nameof(AwaitInsideSimpleEvent_Success));
        }

        [Test]
        public void AwaitInsideSimpleEvent_ThrowsSync()
        {
            // TODO: Use existing event raiser to attach an EventHandler and raise a simple event
            // TODO: Within EventHandler call asynchronous Methods.ThrowsSync() method and await outcome
            Assert.Inconclusive(nameof(AwaitInsideSimpleEvent_ThrowsSync));
        }

        [Test]
        public void AwaitInsideSimpleEvent_ThrowsAsync()
        {
            // TODO: Use existing event raiser to attach an EventHandler and raise a simple event
            // TODO: Within EventHandler call asynchronous Methods.ThrowsAsync() method and await outcome
            Assert.Inconclusive(nameof(AwaitInsideSimpleEvent_ThrowsAsync));
        }

        class EventRaiser
        {
            public event EventHandler SimpleEvent;
            public event EventHandler<CustomEventArgs> ComplexEvent;

            public virtual void RaiseSimpleEvent()
            {
                SimpleEvent?.Invoke(this, EventArgs.Empty);
            }

            public virtual void RaiseComplexEvent()
            {
                ComplexEvent?.Invoke(this, new CustomEventArgs());
            }
        }

        class CustomEventArgs : EventArgs
        {
        }
    }
}