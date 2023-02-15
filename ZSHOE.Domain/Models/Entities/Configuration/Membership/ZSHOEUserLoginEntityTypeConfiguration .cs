using ZSHOE.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ZSHOE.Domain.Models.DataContexts.Configurations
{
    public class ZSHOEUserLoginEntityTypeConfiguration : IEntityTypeConfiguration<ZSHOEUserLogin>
    {
        public void Configure(EntityTypeBuilder<ZSHOEUserLogin> builder)
        {
            builder.ToTable("UserLogins", "Membership");
        }
    }
}
