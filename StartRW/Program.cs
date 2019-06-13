using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace StartRW
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = @".\..\..\..\Read\bin\Debug\Read.exe";
            var w = @".\..\..\..\Write\bin\Debug\Write.exe";

            var m = new Mutex(false, "StartRW");

            var wp = new Process();
            wp.StartInfo.FileName = w;
            wp.Start();

            var rp = new Process();
            rp.StartInfo.FileName = r;
            rp.Start();

            wp.WaitForExit();
            rp.WaitForExit();
        }
    }
}
