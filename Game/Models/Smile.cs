using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    class Smile
    {
        [JsonProperty("question")]
        public Uri Question { get; set; }

        [JsonProperty("solution")]
        public long Solution { get; set; }
    }

}
