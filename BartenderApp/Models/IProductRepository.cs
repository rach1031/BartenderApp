using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
