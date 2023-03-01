using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.Models.Entities.Membership;

namespace ZSHOE.Domain.Models.Entities.Configuration.Membership
{
    public class ZSHOEForgotPasswordEntityTypeConfiiguration
    {
        public void Configure(EntityTypeBuilder<ZSHOERoleClaim> builder)
        {
            builder.ToTable("ForgotPasswords", "Membership");
        }
    }
   
}
