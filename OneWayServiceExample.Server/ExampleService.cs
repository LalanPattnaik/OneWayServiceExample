using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace OneWayServiceExample.Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ExampleService" in both code and config file together.
    public class ExampleService : IExampleService
    {

        public long DoWork()
        {
            long elapsedWorkTime = TheWork();

            Console.WriteLine("DoWork(): Elapsed Time: {0}ms",elapsedWorkTime);

            return elapsedWorkTime;
        }

        public void DoOneWayWork()
        {
            long elapsedWorkTime = TheWork();

            Console.WriteLine("DoOneWayWork(): Elapsed Time: {0}ms", elapsedWorkTime);
        }

        private long TheWork()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            Thread.Sleep(10000);

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }
    }
}
