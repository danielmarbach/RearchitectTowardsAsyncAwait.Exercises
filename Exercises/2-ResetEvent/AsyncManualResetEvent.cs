using System.Threading;
using System.Threading.Tasks;

namespace Exercises.ResetEvent
{
    class AsyncManualResetEvent
    {
        public AsyncManualResetEvent(bool set)
        {
            
        }

        public bool IsSet => true; // implement this

        public Task WaitAsync()
        {
            return WaitAsync(CancellationToken.None);
        }

        public async Task WaitAsync(CancellationToken cancellationToken)
        {
        }

        public void Set()
        {
        }

        public void Reset()
        {
        }
    }
}