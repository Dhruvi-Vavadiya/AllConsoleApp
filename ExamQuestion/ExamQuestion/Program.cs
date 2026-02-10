using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamQuestion
{

    internal class Program
    {
        public async Task<string> getdata(int a)
        {
            Console.WriteLine("getdata  calling....");
            int val = await getFirestsdata();

            string b = await getSecoendsdata(val);

            return b;
        }

        public async Task<int> getFirestsdata()
        {
            Console.WriteLine("getFirestsdata calling..");
            Task.Delay(5000).Wait();
            return 5;
        }

        public async Task<string> getSecoendsdata(int a)
        {
            Console.WriteLine("secend calling...");
            return "hello";
        }
        static Task AsynchronousOperation()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            var task = Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            });
            return task;
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            await AsynchronousOperation();

            Console.ReadLine();

            Program p = new Program();
            //string s = await p.getdata(10);
            Console.WriteLine("by byyyy...");

            Task t = Task.Run(() =>
            {
                Console.WriteLine("task running...");
            });

            t.Wait();
            Console.WriteLine("Task completed");

            Task task = new Task(() =>
            {
                Task.Delay(5000).Wait();
                Console.WriteLine("thread nuumer :-" + Thread.CurrentThread.ManagedThreadId);
            });
            task.Start();
            //Task.Delay(5000).Wait();
            task.Wait();
            Console.WriteLine("Task completed");

        }

    }
}

