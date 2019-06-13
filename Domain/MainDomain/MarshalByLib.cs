using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MainDomain
{
    class MarshalByLib : MarshalByRefObject
    {
        public string GetDomainInfo(string libraryName, string typeName)
        {
            var type = Assembly.LoadFrom(libraryName).GetType(typeName);

            var obj = Activator.CreateInstance(type);

            return (string)type.GetMethod("Info").Invoke(obj, null);
        }
    }
}
