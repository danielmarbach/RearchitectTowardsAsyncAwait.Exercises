using System;
using System.Threading.Tasks;

namespace Exercises
{
    public static class Methods
    {
        public static Task ThrowsSync()
        {
            throw new InvalidOperationException("ThrowsSync");
        }

        public static async Task ThrowsAsync()
        {
            await Task.Delay(2).ConfigureAwait(false);
            throw new InvalidOperationException("ThrowsAsync");
        }

        public static Task SuccessAsync()
        {
            return Task.Delay(2);
        }
    }
}