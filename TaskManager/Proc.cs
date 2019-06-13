using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Management;
using System.Globalization;

namespace TaskManager
{
    public class Proc
    {
        public Proc(ManagementBaseObject process)
        {
            Pid = Convert.ToInt32(process["ProcessId"]);
            Name = process["Name"]?.ToString();
            Priority = Convert.ToInt32(process["Priority"]);
            ThreadsProc = Convert.ToInt32(process["ThreadCount"]);
            WorkingSet64 = Convert.ToInt32(process["WorkingSetSize"]);
            Start = ManagementDateTimeConverter.ToDateTime(process["CreationDate"].ToString());
        }

        public int Pid { get; }
        public string Name { get; }
        public int Priority { get; }
        public DateTime Start { get; }
        public int ThreadsProc { get; }
        public long WorkingSet64 { get; }
    }
}
