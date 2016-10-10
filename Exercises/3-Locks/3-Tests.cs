using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Exercises.Locks
{
    [TestFixture]
    public class TestsPart3
    {
        [Test]
        public async Task AsyncLock()
        {
            // TODO: Use a semaphore to implement an async disposable which can be used in a using block
            // TODO: You can start from the ground up or extend the AsyncLock.cs file which contains a skeletton

            Assert.Inconclusive(nameof(AsyncLock));
        }
    }
}
