using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Models.Entities.ViewModels
{
    public class ProductDetailsViewModel
    {
        public Product Product { get; set; }
        public ProductCatalogItem ProductCatalog { get; set; }
    }
}
