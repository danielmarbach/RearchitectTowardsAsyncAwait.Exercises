using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.Locks
{
    [TestFixture]
    public class TestsPart1
    {
        private object locker = new object();

        [Test]
        public void Lock()
        {
            // TODO: Play a bit with the lock statement for better understand, maybe surround it with Task.Run and see what happens
            // What is the underlying mechanism of lock, compile it and decompile the assembly (you might need to look at the IL code)
            lock (locker)
            {
                CriticalRegion();
            }
        }

        [Test]
        public async Task LockAsync()
        {
            // TODO: Write a critical region async method
            // TODO: Use it in lock statement, what happens and why?

            Assert.Inconclusive(nameof(LockAsync));
        }

        static void CriticalRegion()
        {
            Thread.Sleep(100);
        }
    }
}
