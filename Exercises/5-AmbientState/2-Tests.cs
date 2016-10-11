using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.AmbientState
{
    [TestFixture]
    public class TestsPart2
    {
        [Test]
        public async Task StateWithAsyncLocal()
        {
            var classWithState = new ClassWithAmbientStateInAsyncLocal();

            // TODO: Use the class with ambient state concurrently multiple times, call it in the same async flow at least twice, put a asynchronous pause in between the calls

            Assert.Inconclusive(nameof(StateWithAsyncLocal));
        }

        class ClassWithAmbientStateInAsyncLocal
        {
            // use AsyncLocal

            // Additional reading: https://msdn.microsoft.com/en-us/library/dn906268(v=vs.110).aspx

            public void Do()
            {
                // TODO: Access the state and update it
                // TODO: Output the state
            }
        }
    }
}
