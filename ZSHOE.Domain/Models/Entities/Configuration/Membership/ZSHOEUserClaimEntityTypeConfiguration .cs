using ZSHOE.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ZSHOE.Domain.Models.DataContexts.Configurations
{
    public class ZSHOEUserClaimEntityTypeConfiguration : IEntityTypeConfiguration<ZSHOEUserClaim>
    {
        public void Configure(EntityTypeBuilder<ZSHOEUserClaim> builder)
        {
            builder.ToTable("UserClaims", "Membership");
        }
    }
}
