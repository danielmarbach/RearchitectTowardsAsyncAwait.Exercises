using System.Threading;
using System.Threading.Tasks;

namespace Exercises.ResetEvent
{
    class AsyncManualResetEvent
    {
        // hint: probably a TaskCompletionSource is not a bad starting point

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
            // hint: when cancellation is due throw or immediately return
            // hint: we have to observe the cancellation of the token
        }

        public void Set()
        {
            // hint: signal it
        }

        public void Reset()
        {
            // hint: reset the signal
            // bonus: do it in a thread safe way, remember atomic exchange
        }
    }
}