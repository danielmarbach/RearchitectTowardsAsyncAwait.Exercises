using System;
using System.Threading;

namespace Exercises.Remoting
{
    public class RemoteService : MarshalByRefObject
    {
        public string TimeConsumingRemoteCall()
        {
            Thread.Sleep(1000);
            return "Hello from remote.";
        }
    }
}