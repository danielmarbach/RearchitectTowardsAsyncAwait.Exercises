using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Exercises.Locks
{
    public class AsyncLock
    {
        private SemaphoreSlim locker = new SemaphoreSlim(111111); // ?

        public AwaitableDisposable<Releaser> LockAsync(CancellationToken token)
        {
            // TODO: Can we fast track in the case there is nothing to await?
            // TODO: Probably most officient is to use the continuation style with TPL.
            // TODO: Try to save allocations by using the state object on the continuation APIs
            return new AwaitableDisposable<Releaser>(); // this is not correct
        }

        public struct Releaser : IDisposable
        {
            private readonly AsyncLock @lock;

            public Releaser(AsyncLock @lock)
            {
                this.@lock = @lock;
            }

            public void Dispose()
            {
                // TODO: What here?
            }
        }

        public struct AwaitableDisposable<T> where T : IDisposable
        {
            private readonly Task<T> task;

            internal AwaitableDisposable(Task<T> task)
            {
                this.task = task;
            }

            public static implicit operator Task<T>(AwaitableDisposable<T> source)
            {
                return source.task;
            }

            public TaskAwaiter<T> GetAwaiter()
            {
                return task.GetAwaiter();
            }

            public ConfiguredTaskAwaitable<T> ConfigureAwait(bool continueOnCapturedContext)
            {
                return task.ConfigureAwait(continueOnCapturedContext);
            }
        }
    }
}