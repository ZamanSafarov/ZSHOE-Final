using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.Models.Entities;
using ZSHOE.Domain.Models.Entities.Membership;

namespace ZSHOE.Domain.Models.DataContexts
{
    public class ZSHOEDbContext: IdentityDbContext<ZSHOEUser, ZSHOERole, int, ZSHOEUserClaim,
        ZSHOEUserRole,
        ZSHOEUserLogin, ZSHOERoleClaim, ZSHOEUserToken>
    {

        public ZSHOEDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ZSHOEUser>(e =>
            {
                e.ToTable("Users", "Membership");
            });
            builder.Entity<ZSHOERole>(e =>
            {
                e.ToTable("Roles", "Membership");
            });
            builder.Entity<ZSHOEUserRole>(e =>
            {
                e.ToTable("UserRoles", "Membership");

            });
            builder.Entity<ZSHOEUserClaim>(e =>
            {
                e.ToTable("UserClaims", "Membership");
            });
            builder.Entity<ZSHOERoleClaim>(e =>
            {
                e.ToTable("RoleClaims", "Membership");

            });
            builder.Entity<ZSHOEUserLogin>(e =>
            {
                e.ToTable("UserLogins", "Membership");
            });
            builder.Entity<ZSHOEUserToken>(e =>
            {
                e.ToTable("UserTokens", "Membership");
            });
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogPostComment> BlogPostComments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BlogPostTagItem> BlogPostTagCloud { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ContactPost> ContactPosts { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<AboutInfo> AboutInfos { get; set; }
        public DbSet<AboutTeam> AboutTeam { get; set; }
        public DbSet<AboutCustomer> AboutCustomers { get; set; }
        public DbSet<AboutWhoWeAre> AboutWhoWeAre { get; set; }
    }
}
