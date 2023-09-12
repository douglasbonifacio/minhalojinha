using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;



namespace LojinhaServer.Collections;
[Table("products")]
[BsonIgnoreExtraElements]
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        [JsonPropertyName("Nome")]
        public string Name { get; set; }
         [BsonElement("description")]
        [JsonPropertyName("Nome")]
        public string Description { get; set; }
         [BsonElement("price")]
        [JsonPropertyName("Nome")]
        public decimal Price { get; set; }

         [BsonElement("offprice")]
        [JsonPropertyName("Nome")]

        public decimal OffPrice { get; set; }

        [BsonElement("categories")]
        [JsonPropertyName("Nome")]

        public List<string> Categories { get; set; }

        [BsonElement("tags")]
        [JsonPropertyName("Nome")]

        public List<string> Tags { get; set; }

        [BsonElement("brand")]
        [JsonPropertyName("Nome")]

        public string Brand { get; set; }
    }
