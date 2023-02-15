using ZSHOE.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ZSHOE.Domain.Models.DataContexts.Configurations
{
    public class ZSHOERoleEntityTypeConfiguration : IEntityTypeConfiguration<ZSHOERole>
    {
        public void Configure(EntityTypeBuilder<ZSHOERole> builder)
        {
            builder.ToTable("Roles", "Membership");
        }
    }
}
