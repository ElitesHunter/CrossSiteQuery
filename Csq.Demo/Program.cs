using System;
using System.Diagnostics;

namespace MasterDuner.Cooperations.Csq.TestProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new DemoTraceListener());

            Trace.Write("测试搜索服务！");

            HighpinCn highpin = new HighpinCn();
            highpin.TrySearchResumes();

            Console.ReadLine();
        }
    }
}
