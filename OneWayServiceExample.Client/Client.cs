using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using OneWayServiceExample.Client.Services;

namespace OneWayServiceExample.Client
{
    class Client
    {
        static void Main(string[] args)
        {
            using (Services.ExampleServiceClient proxy = new ExampleServiceClient())
            {
                Stopwatch sw = new Stopwatch();

                sw.Start();

                try
                {
                    proxy.DoWork();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " ");
                }
                
                sw.Stop();

                Console.WriteLine("proxy.DoWork(): Elapsed Time: {0}ms\n", sw.ElapsedMilliseconds);

                sw.Reset();

                sw.Start();

                try
                {
                    proxy.DoOneWayWork();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " ");
                }

                sw.Stop();

                Console.WriteLine("proxy.DoOneWayWork(): Elapsed Time: {0}ms\n", sw.ElapsedMilliseconds);

                sw.Reset();

                sw.Start();

                try
                {
                    proxy.DoWorkAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " ");
                }

                sw.Stop();

                Console.WriteLine("proxy.DoWorkAsync(): Elapsed Time: {0}ms\n", sw.ElapsedMilliseconds);

                sw.Reset();
            }

            Console.ReadLine();

        }
    }
}
