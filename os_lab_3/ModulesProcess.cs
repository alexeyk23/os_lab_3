using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OS.Task3
{
    class ModulesProcess
    {
        public ModuleEntry32 Module { get; set; }
        public List<ProcessEntry32> Processes { get; set; }

        public ModulesProcess()
        {
            Processes = new List<ProcessEntry32>();
        }
    }
}
