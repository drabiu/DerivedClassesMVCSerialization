using DiscoveryTypesCollection.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace DiscoveryTypesCollection.Converters
{
    public class DerivedClassesConverter<T> : JsonConverter where T : class
    {
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            var item = JToken.Load(reader);

            if (!item.HasValues)
            {
                return (T)Activator.CreateInstance(typeof(T));
            }

            foreach (var type in typeof(T).GetDerivedClasses())
            {
                if (item.IsType(type))
                {
                    return item.ToObject(type);
                }
            }

            return null;
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(T);
    }
}
