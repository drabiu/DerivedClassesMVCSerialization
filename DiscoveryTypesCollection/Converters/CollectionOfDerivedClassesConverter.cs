using DiscoveryTypesCollection.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Navtor.Advisory.Models.Converters
{
    public class CollectionOfDerivedClassesConverter<T> : JsonConverter where T : class
    {
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            var itemsJArray = JArray.Load(reader);
            var itemsList = new List<T>();
            foreach (var item in itemsJArray)
            {
                if (!item.HasValues)
                {
                    itemsList.Add((T)Activator.CreateInstance(typeof(T)));
                    continue;
                }

                foreach (var type in typeof(T).GetDerivedClasses())
                {
                    if (item.IsType(type))
                    {
                        var itemObject = item.ToObject(type);
                        itemsList.Add(itemObject as T);
                    }
                }
            }

            return itemsList;
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(T);
    }
}
