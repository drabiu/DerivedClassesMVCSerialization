using System;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace DiscoveryTypesCollection.Extensions
{
    public static class JTokenExtensions
    {
        public static bool IsType<T>(this JToken? token) where T : class
        {
            var type = typeof(T);

            return IsType(token, type);
        }

        public static bool IsType(this JToken? token, Type type)
        {
            var isType = true;
            foreach (var jObject in (JObject)token)
            {
                var propertyName = jObject.Key;
                var property = type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                if (property == null)
                {
                    isType = false;
                    break;
                }
            }
            //foreach (var field in type.GetRuntimeProperties())
            //{
            //    var value  =((JObject?)token)?.GetValue(field.Name, StringComparison.OrdinalIgnoreCase);
            //    isType = !string.IsNullOrEmpty(token?[field.Name]?.ToString());
            //    if (isType) break;
            //}

            return isType;
        }
    }
}
