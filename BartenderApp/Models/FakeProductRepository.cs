using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product {DrinkName = "Old Fashioned", Price = 10, Description = "Bourbon, Angostura bitters, sugar, orange peel"},
            new Product {DrinkName = "Moscow Mule", Price = 8, Description="Vodka, Ginger Beer, lime juice, lime wedge"},
            new Product {DrinkName = "Manhattan", Price = 12},
            new Product {DrinkName = "Tom Collins", Price = 10}

        };
    }
}
