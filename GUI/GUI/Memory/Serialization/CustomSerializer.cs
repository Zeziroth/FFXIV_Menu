using GUI.Memory.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GUI.Memory.Serialization
{
    public class CustomSerializer
    {
        private List<JsonConverter> _converters = new List<JsonConverter>();

        public CustomSerializer(CustomProcess process)
        {
            _converters.Add(new ProcessModulePropertyConverter(process));
            _converters.Add(new PointerPropertyConverter(process));
        }

        public string SerializeObject(object value, Formatting formatting) => JsonConvert.SerializeObject(value, formatting, _converters.ToArray());

        public T DeserializeObject<T>(string json) => JsonConvert.DeserializeObject<T>(json, _converters.ToArray());
    }
}
