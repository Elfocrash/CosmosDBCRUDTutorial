using Cosmonaut.Attributes;

namespace CosmosDBTutorial.Models
{
    [CosmosCollection("mycars")]
    public class Car
    {
        [CosmosPartitionKey]
        public string Id { get; set; }

        public string BrandName { get; set; }

        public string ModelName { get; set; }

        public bool Electric { get; set; }

        public int PriceInEuros { get; set; }
    }
}