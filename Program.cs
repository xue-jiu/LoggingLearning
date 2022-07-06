using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace LoggingLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection service = new ServiceCollection();
            service.AddLogging(logBuilder=> 
            {
                logBuilder.AddConsole();
                logBuilder.SetMinimumLevel(LogLevel.Trace);//error
            });
            service.AddScoped<Test>();
            using (var sp = service.BuildServiceProvider()) 
            {
                var oneTest= sp.GetRequiredService<Test>();
                oneTest.OneTest();
            }


        }
    }
}
