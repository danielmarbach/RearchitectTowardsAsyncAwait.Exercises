using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.Events
{
    [TestFixture]
    public class TestsPart3
    {
        [Test]
        public async Task AwaitSimpleEvent()
        {
            var raiser = new EventRaiser();

            // TODO: Turn an event into a task
        }

        [Test]
        public async Task AwaitComplexEvent()
        {
            var raiser = new EventRaiser();

            // TODO: Turn an event into a task and return a result
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