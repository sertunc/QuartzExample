using System;
using System.Threading.Tasks;
using Quartz;

namespace QuartzExample.Scheduling
{
    public class XScheduler : IJob
    {
        Task IJob.Execute(IJobExecutionContext context)
        {
            SayHello();
            
            return Task.CompletedTask;
        }

        public void SayHello()
        {
            Console.WriteLine("X Scheduler " + DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
