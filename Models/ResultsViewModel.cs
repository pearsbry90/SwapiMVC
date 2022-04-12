using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SwapiMVC.Models
{
    public class ResultsViewModel<TResults>
    {
        [JsonPropertyName("count")]
        public int Count {get;set;}

        [JsonPropertyName("next")]
        public string Next {get;set;}

        [JsonPropertyName("results")]
        public IEnumerable<TResults> Results {get;set;}

        [JsonPropertyName("previous")]
        public string Previous {get;set;}

        public string NextPageNum => Next?.Split("?page=").LastOrDefault();
        public string PreviousPageNum => Previous?.Split("?page=").LastOrDefault();
    }
}