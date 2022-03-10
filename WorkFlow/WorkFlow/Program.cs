using System;

namespace WorkFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new WorkflowEngine();
            IWorkflow workflow = new PcManagerWorkflow();

            engine.Run(workflow);
        }
    }
}
