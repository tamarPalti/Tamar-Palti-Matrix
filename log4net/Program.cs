using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Log4Net_1
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch(); 
            int num;
            //1.
            Console.WriteLine("enter num");
            num = Int32.Parse(Console.ReadLine());
            //2.
            stopwatch.Start();
            for (int i = 0; i < num; i++) ;
            stopwatch.Stop();
            var time = stopwatch.Elapsed;
            //3.
            Console.WriteLine("Time:"+ time+"ms");
            //4.
            log.Info(DateTime.Today + " - Input:" + num + " - Time:" + time + "ms");
            
        }
    }
}
