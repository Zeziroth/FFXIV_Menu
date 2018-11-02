using Newtonsoft.Json;
using System;
using System.Linq;

namespace GUI.Memory.Converters
{
    public class PointerPropertyConverter : JsonConverter
    {
        private CustomProcess _process;

        public PointerPropertyConverter(CustomProcess process)
        {
            _process = process;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(Pointer) == objectType;
        }

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // not needed
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Create a new serializer without out PointerPropertyConverter to avoid a infinite loop
            JsonSerializer emptySerializer = new JsonSerializer();

            emptySerializer.Converters.Add(serializer.Converters.First(x => x.GetType() == typeof(ProcessModulePropertyConverter)));
            var pointer = emptySerializer.Deserialize<Pointer>(reader);

            // Recalculate the pointer
            pointer.Resolve(_process);

            // Read to the end
            reader.Read();

            return pointer;
        }
    }
}
