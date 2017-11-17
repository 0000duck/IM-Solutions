using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OpenTKLib
{
    public class PerformanceCheck
    {
        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;
		PerformanceCounter GraphCounter;

        public PerformanceCheck()
        {
         

            cpuCounter = new PerformanceCounter();

            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
			var f1 = PerformanceCounterCategory.GetCategories();
			foreach (var v in f1)
			{
				Console.WriteLine($"{v.CategoryName}, {v.CategoryType}, {v.CategoryHelp}, {v.MachineName}");
			}
			GraphCounter = new PerformanceCounter();

        }
        public double CpuUsage()
        {
            return cpuCounter.NextValue();
        }

		public double GraphicsUsage()
		{
			return 0;
		}

		public double RamAviable()
		{
			return ramCounter.NextValue();
		}
    }
}
