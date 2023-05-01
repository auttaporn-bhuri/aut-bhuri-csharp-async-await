
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace Auttaporn
{
    class Progame {
        static async Task Main() {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("==== Learning C# Async and Await ====");

            Console.WriteLine("==== Do process withot Async and Await keyword ====");
            Stopwatch stopwatch = Stopwatch.StartNew();
            DoProcess();
            stopwatch.Stop();
            Console.WriteLine($"Total DoProcess time = {stopwatch.ElapsedMilliseconds} ms");

            Console.WriteLine("==== Do process with Async and Await keyword ====");
            stopwatch.Restart();
            stopwatch.Start();
            await DoProcessAsync();
            stopwatch.Stop();
            Console.WriteLine($"Total DoProcessAsync time = {stopwatch.ElapsedMilliseconds} ms");
        }

        static void DoProcess() {
            Process1();
            Process2();
            Process3();
        }


        static async Task DoProcessAsync() {
            var task1 = Task.Run(() => { Process1(); });
            var task2 = Task.Run(() => { Process2(); });
            var task3 = Task.Run(() => { Process3(); });

            await Task.WhenAll(task1, task2, task3);
        }

        static void Process1() {
            Console.WriteLine("Processing step 1. ........");
            Thread.Sleep(5000);
        }

        static void Process2() {
            Console.WriteLine("Processing step 2. ........");
            Thread.Sleep(5000);
        }

        static void Process3() {
            Console.WriteLine("Processing step 3. ........");
            Thread.Sleep(5000);
        }
    }
}
