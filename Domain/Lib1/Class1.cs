using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib1
{
    public class Class1
    {
        public string Info()
        {
            var appDomain = AppDomain.CurrentDomain;
            return $"Имя:{appDomain.FriendlyName}, ИД:{appDomain.Id}, Default:{appDomain.IsDefaultAppDomain()}, Путь:{appDomain.BaseDirectory}";
        }
    }
}
