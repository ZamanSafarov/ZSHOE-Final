using ZSHOE.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ZSHOE.Domain.Models.DataContexts.Configurations
{
    public class ZSHOEUserTokenEntityTypeConfiguration : IEntityTypeConfiguration<ZSHOEUserToken>
    {
        public void Configure(EntityTypeBuilder<ZSHOEUserToken> builder)
        {
            builder.ToTable("UserTokens", "Membership");
        }
    }
}
