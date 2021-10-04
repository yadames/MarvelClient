using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelClient.Repository.Marvel.Model
{
    public class Request
    {
        [AliasAs("ts")]
        public string TimeStamp { get; set; }

        [AliasAs("apikey")]
        public string ApiKey { get; set; }

        [AliasAs("hash")]
        public string Hash { get; set; }
    }
}
