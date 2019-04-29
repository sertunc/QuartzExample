using QuartzExample.Scheduling;
using System;

namespace QuartzExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SchedulerWrapper.RunJob();

            Console.WriteLine("Zamanlanmış görevler başladı!");

            Console.ReadLine();
        }
    }
}
