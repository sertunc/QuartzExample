using Quartz;
using Quartz.Impl;

namespace QuartzExample.Scheduling
{
    public class SchedulerWrapper
    {
        public static async void RunJob()
        {
            var scheduler = await new StdSchedulerFactory().GetScheduler();

            if (!scheduler.IsStarted)
                await scheduler.Start();

            var jobX = JobBuilder.Create<XScheduler>().Build();
            var triggerX = TriggerBuilder.Create().WithSimpleSchedule(s => s.WithIntervalInSeconds(1).RepeatForever()).Build();
            await scheduler.ScheduleJob(jobX, triggerX);

            var jobY = JobBuilder.Create<YScheduler>().Build();
            var triggerY = TriggerBuilder.Create().WithSimpleSchedule(s => s.WithIntervalInSeconds(5).RepeatForever()).Build();
            await scheduler.ScheduleJob(jobY, triggerY);
        }
    }
}

