using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Models.Entities.Configuration.Membership
{
    public class ProductRateEntityTypeConfiguration : IEntityTypeConfiguration<ProductRate>
    {
        public void Configure(EntityTypeBuilder<ProductRate> builder)
        {
            builder.HasKey(key =>
            new
            {
                key.ProductId,
                key.CreatedByUserId
            });

            builder.ToTable("ProductRates");
        }
    }
}
