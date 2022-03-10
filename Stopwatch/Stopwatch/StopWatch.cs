using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class StopWatch
    {
      
        private DateTime _timerInitial = new DateTime();
        private TimeSpan _timerFinal = new TimeSpan();
        private bool IsActive;


        public DateTime Start()
        {
           IsActive = true;
          return _timerInitial = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            IsActive = false;         
            return _timerFinal = DateTime.Now - _timerInitial;
        }    

        public static void RunStopWatch()
        {
            var stopWatch = new Stopwatch.StopWatch();
            while (true)
            {
                Console.WriteLine("Type \"Start\" to initialize the StopWatch or Type \"Stop\" to end it.");
                var input = Console.ReadLine();

                if (input.Trim().ToLower() != "start" && input.Trim().ToLower() != "stop")
                {
                    Console.WriteLine("You did not type any comand. \nTry again\n");
                    continue;
                }

                if (input.Trim().ToLower() == "start" && stopWatch.IsActive)
                {
                    Console.WriteLine("You already Start it, end it first to start again.\n");
                    continue;
                }

                if (input.Trim().ToLower() == "stop" && !stopWatch.IsActive)
                {
                    Console.WriteLine("You need to start it first before stop it.\n");
                    continue;
                }

                if (input.Trim().ToLower() == "start" && !stopWatch.IsActive)
                {
                    stopWatch.Start();
                    continue;
                }

                if (input.Trim().ToLower() == "stop" && stopWatch.IsActive)
                {
                    stopWatch.Stop();
                    Console.WriteLine("\n {0} \n", stopWatch._timerFinal.Seconds);
                    continue;
                }

            }

        }
    }
}
