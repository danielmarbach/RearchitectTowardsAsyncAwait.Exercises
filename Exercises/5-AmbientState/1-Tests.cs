using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.AmbientState
{
    [TestFixture]
    public class TestsPart1
    {
        [Test]
        public async Task AmbientState()
        {
            var classWithAmbientState = new ClassWithAmbientState();

            // TODO: Use the class with ambient state in parallel multiple times, call it on the same thread at least twice, put Thread.Sleep in between the calls

            Assert.Inconclusive(nameof(AmbientState));
        }

        class ClassWithAmbientState
        {
            // TODO: Use a static ThreadLocal or ThreadStatic, use for simplicity an int as state

            public void Do()
            {
                // TODO: Access the state and update it.
                // TODO: Output the state
            }
        }
    }
}