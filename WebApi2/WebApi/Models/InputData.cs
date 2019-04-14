using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi2.Controllers;

namespace WebApi2.Models
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