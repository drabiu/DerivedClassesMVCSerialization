using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DiscoveryTypesCollection.Extensions
{
    public static class TypeExtensions
    {
        public static IEnumerable<Type> GetDerivedClasses(this Type type)
        {
            //if you want the abstract classes drop the !TheType.IsAbstract but it is probably to instance so its a good idea to keep it.
            return Assembly.GetAssembly(type).GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(type));
        }
    }
}
