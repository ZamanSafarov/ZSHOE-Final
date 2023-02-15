using ZSHOE.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ZSHOE.Domain.Models.DataContexts.Configurations
{
    public class ZSHOERoleClaimEntityTypeConfiguration : IEntityTypeConfiguration<ZSHOERoleClaim>
    {
        public void Configure(EntityTypeBuilder<ZSHOERoleClaim> builder)
        {
            builder.ToTable("RoleClaims", "Membership");
        }
    }
}
