using ZSHOE.Domain.AppCode.Infrastructure;
using System.Collections.Generic;

namespace ZSHOE.Domain.Models.Entities
{
    public class ProductColor : BaseEntity
    {
        public string HexCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CreatedByUserId { get; set; }
        public virtual ICollection<ProductCatalogItem> ProductCatalog { get; set; }
    }
}
