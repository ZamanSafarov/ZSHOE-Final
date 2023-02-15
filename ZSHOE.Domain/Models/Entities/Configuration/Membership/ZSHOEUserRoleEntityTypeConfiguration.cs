using ZSHOE.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ZSHOE.Domain.Models.DataContexts.Configurations
{
    public class ZSHOEUserRoleEntityTypeConfiguration : IEntityTypeConfiguration<ZSHOEUserRole>
    {
        public void Configure(EntityTypeBuilder<ZSHOEUserRole> builder)
        {
            builder.ToTable("UserRole", "Membership");
        }
    }
}
