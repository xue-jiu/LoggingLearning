using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;
using SystemServices;

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
                logBuilder.AddNLog();
                logBuilder.SetMinimumLevel(LogLevel.Trace);//error
            });

            service.AddScoped<Test>();
            service.AddScoped<Test2>();


            using (var sp = service.BuildServiceProvider()) 
            {
                var oneTest = sp.GetRequiredService<Test>();
                var TwoTest = sp.GetRequiredService<Test2>();
                for (int i = 0; i < 100; i++)
                {
                    oneTest.OneTest();
                    TwoTest.TwoTest();
                }
            }

        }
    }
}
