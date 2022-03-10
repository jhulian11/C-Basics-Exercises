using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow
{
    class WorkflowEngine
    {

        public void Run(IWorkflow workflow)
        {
            workflow.Execute();
        }   

    }
}
