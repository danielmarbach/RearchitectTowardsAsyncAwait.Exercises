using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Exercises.Locks
{
    [TestFixture]
    public class TestsPart2
    {
        // Additional reading: http://www.albahari.com/threading/part2.aspx#_Semaphore

        [Test]
        public async Task SemaphoreSlim()
        {
            // TODO: Write three concurrent tasks which try to access a shared ressource (i.ex. integer counter)
            // TODO: Synchronize access to the shared ressource with the semaphore slim
            Assert.Inconclusive(nameof(SemaphoreSlim));
        }
    }
}
