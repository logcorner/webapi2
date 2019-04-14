using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Globalization;
using System.Threading;
using WebApi.Helper;

namespace WebApi2.Controllers
{
    public class DecimalToStringConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken jt = JValue.ReadFrom(reader);
           
            string valueToConvert = jt.Value<string>();
            if (string.IsNullOrWhiteSpace(valueToConvert))
            {
                return null;
            }

            var currentCulture = Helper.GetCurrentCulture();
            var wantedSeperator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            var result = valueToConvert.Replace(".", wantedSeperator);

            if (!decimal.TryParse(result, NumberStyles.Any, currentCulture, out decimal value))
            {
                throw new InvalidCastException($"{result} is not a decimal");
            }
            return value;
        }

       

        public override bool CanConvert(Type objectType)
        {
            return typeof(decimal).Equals(objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value.ToString());
        }
    }
}
