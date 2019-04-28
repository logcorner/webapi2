using System;

namespace WebApi.Models
{
    public class InputData
    {
        //[JsonConverter(typeof(IdToStringConverter))]
        public decimal value { get; set; }

        public decimal? nullableValue { get; set; }
        //[JsonConverter(typeof(DecimalConverter))]
        public DateTime date { get; set; }
    }
}