using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow
{
    class PcManagerWorkflow: IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Turning Pc On...");
            Console.WriteLine("Pc is Online");
            Console.WriteLine("Turning Pc Off...");
            Console.WriteLine("Pc was been torned off.");
        }
    }
}
