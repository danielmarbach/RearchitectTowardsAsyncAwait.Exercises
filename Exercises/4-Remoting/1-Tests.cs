using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.Remoting
{
    [TestFixture]
    public class TestsPart1
    {
        [Test]
        public void RemotingUsage() // Not doing real remoting but you get the point
        {
            SyncClient syncClientApp = new SyncClient();
            syncClientApp.Run();
        }

        public class SyncClient : MarshalByRefObject
        {
            public void Run()
            {
                var remoteService = new RemoteService();

                remoteService.TimeConsumingRemoteCall().Output();
            }
        }

        [Test]
        public async Task RemotingUsageAsync() // Not doing real remoting but you get the point
        {
            AsyncClient asyncClient = new AsyncClient();
            await asyncClient.Run();
        }

        // Additional reading: https://msdn.microsoft.com/en-us/library/0sa925ka(v=vs.100).aspx This is the old synchronous blocking way we want to turn that into something non blocking

        public class AsyncClient : MarshalByRefObject
        {
            [OneWay]
            public string Callback(IAsyncResult ar)
            {
                var asyncDelegate = (Func<string>)((AsyncResult)ar).AsyncDelegate;
                // TODO: Implement here

                return default(string);
            }

            // Additional reading: https://msdn.microsoft.com/en-us/library/dd997423(v=vs.110).aspx
            public async Task Run()
            {
                var remoteService = new RemoteService();

                // TODO: Assign remote call to delegate
                // TODO: use Task.Factory.FromAsync to call into remote delegate
                
            }
        }
    }
}
