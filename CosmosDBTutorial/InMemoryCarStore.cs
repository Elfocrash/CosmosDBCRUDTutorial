using System;
using System.Collections.Generic;
using CosmosDBTutorial.Models;

namespace CosmosDBTutorial
{
    public class InMemoryCarStore
    {
        public List<Car> Cars { get; }

        public InMemoryCarStore()
        {
            Cars = new List<Car>
            {
                new Car
                {
                    Id = Guid.NewGuid().ToString(),
                    BrandName = "Ford",
                    ModelName = "Focus",
                    Electric = false,
                    PriceInEuros = 20000
                },
                new Car
                {
                    Id = Guid.NewGuid().ToString(),
                    BrandName = "Tesla",
                    ModelName = "S",
                    Electric = true,
                    PriceInEuros = 65000
                }
            };
        }
    }
}