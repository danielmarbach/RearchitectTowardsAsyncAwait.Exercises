using System;
using System.Threading;
using NUnit.Framework;

namespace Exercises.BringItTogether
{
    [TestFixture]
    public class TestsPart1
    {
        static Random random = new Random();

        [Test]
        public void KickItOff()
        {
            // TODO: Make this code async, step by step
            Highlevel();
        }

        public static void Highlevel()
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Midlevel();
                }
                catch (InvalidOperationException ex)
                {
                    ex.Message.Output();
                }
            }
        }

        public static void Midlevel()
        {
            LowLevel();
        }

        private static void LowLevel()
        {
            Thread.Sleep(20); // Very important work
            if (random.Next(0, 10)%2 == 0)
            {
                throw new InvalidOperationException();
            }
            Thread.Sleep(20); // Very important work
        }
    }
}
