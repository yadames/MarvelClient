using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelClient.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Thumbnail
    {
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        [JsonProperty(PropertyName = "extension")]
        public string Extension { get; set; }
    }

    public class Item
    {
        [JsonProperty(PropertyName = "resourceURI")]
        public string ResourceURI { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }

    public class Comics
    {
        [JsonProperty(PropertyName = "available")]
        public int Available { get; set; }

        [JsonProperty(PropertyName = "collectionURI")]
        public string CollectionURI { get; set; }

        [JsonProperty(PropertyName = "items")]
        public IList<Item> Items { get; set; }

        [JsonProperty(PropertyName = "returned")]
        public int Returned { get; set; }
    }

    public class Series
    {
        [JsonProperty(PropertyName = "available")]
        public int Available { get; set; }

        [JsonProperty(PropertyName = "collectionURI")]
        public string CollectionURI { get; set; }

        [JsonProperty(PropertyName = "items")]
        public IList<Item> Items { get; set; }

        [JsonProperty(PropertyName = "returned")]
        public int Returned { get; set; }
    }

    public class Stories
    {
        [JsonProperty(PropertyName = "available")]
        public int Available { get; set; }

        [JsonProperty(PropertyName = "collectionURI")]
        public string CollectionURI { get; set; }

        [JsonProperty(PropertyName = "items")]
        public IList<Item> Items { get; set; }

        [JsonProperty(PropertyName = "returned")]
        public int Returned { get; set; }
    }

    public class Events
    {
        [JsonProperty(PropertyName = "available")]
        public int Available { get; set; }

        [JsonProperty(PropertyName = "collectionURI")]
        public string CollectionURI { get; set; }

        [JsonProperty(PropertyName = "items")]
        public IList<Item> Items { get; set; }

        [JsonProperty(PropertyName = "returned")]
        public int Returned { get; set; }
    }

    public class Url
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string ItemUrl { get; set; }
    }

    public class Result
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        //[JsonProperty(PropertyName = "modified")]
        //public DateTime Modified { get; set; }

        [JsonProperty(PropertyName = "thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty(PropertyName = "resourceURI")]
        public string ResourceURI { get; set; }

        [JsonProperty(PropertyName = "comics")]
        public Comics Comics { get; set; }

        [JsonProperty(PropertyName = "series")]
        public Series Series { get; set; }

        [JsonProperty(PropertyName = "stories")]
        public Stories Stories { get; set; }

        [JsonProperty(PropertyName = "events")]
        public Events Events { get; set; }

        [JsonProperty(PropertyName = "urls")]
        public IList<Url> Urls { get; set; }
    }

    public class Data
    {
        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }

        [JsonProperty(PropertyName = "limit")]
        public int Limit { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "results")]
        public IList<Result> Results { get; set; }
    }

    public class Hero
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        [JsonProperty(PropertyName = "attributionText")]
        public string AttributionText { get; set; }

        [JsonProperty(PropertyName = "attributionHTML")]
        public string AttributionHTML { get; set; }

        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        [JsonProperty(PropertyName = "data")]
        public Data Data { get; set; }
    }
}
