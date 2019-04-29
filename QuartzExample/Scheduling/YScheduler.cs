using Quartz;
using System;
using System.Threading.Tasks;

namespace QuartzExample.Scheduling
{
    public class YScheduler : IJob
    {
        Task IJob.Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Y Scheduler " + DateTime.Now.ToString("HH:mm:ss"));

            return Task.CompletedTask;
        }
    }
}
