using ZSHOE.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Models.DataContexts.Configurations
{
    public class ZSHOEUserEntityTypeConfiguration : IEntityTypeConfiguration<ZSHOEUser>
    {
        public void Configure(EntityTypeBuilder<ZSHOEUser> builder)
        {
            builder.ToTable("Users", "Membership");
        }
    }
}
