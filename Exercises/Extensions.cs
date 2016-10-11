using System;
using System.Threading.Tasks;

namespace Exercises
{
    public static class Extensions
    {
        public static void Output(this string value)
        {
            Console.WriteLine(value);
        }

        public static void Ignore(this Task task)
        {
        }

        public static async Task IgnoreCancellation(this Task task)
        {
            try
            {
                await task.ConfigureAwait(false);
            }
            catch (OperationCanceledException)
            {
            }
        }
    }
}