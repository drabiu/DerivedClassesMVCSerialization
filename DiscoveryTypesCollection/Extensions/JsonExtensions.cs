using System;
using System.Buffers;
using System.Text.Json;

namespace DiscoveryTypesCollection.Extensions
{
    static class JsonExtensions
    {
        // This is a HACK for .NET 5. In .Net 6 there is a standard implementation of this method.
        public static T? ToObject<T>(this JsonElement element, JsonSerializerOptions? options = default)
        {
            ArrayBufferWriter<byte> bufferWriter = new ArrayBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(bufferWriter);
            element.WriteTo(writer);
            writer.Flush();
            return JsonSerializer.Deserialize<T>(bufferWriter.WrittenSpan, options);
        }

        public static T? ToObject<T>(this JsonDocument document, JsonSerializerOptions? options = default)
        {
            if (document is null)
                throw new ArgumentNullException(nameof(document));
            return document.RootElement.ToObject<T>(options);
        }
    }
}
