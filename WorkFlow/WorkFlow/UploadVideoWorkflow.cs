using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow
{
    class UploadVideoWorkflow : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Uploadind Video...");
            Console.WriteLine("Video Ready for Encoding.");
            Console.WriteLine("Video started processing");
            Console.WriteLine("Chage the status of the video.");
            Console.WriteLine("Video as been uploaded.");
        }
    }
}
