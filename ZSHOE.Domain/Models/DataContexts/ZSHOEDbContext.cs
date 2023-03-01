
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
     

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogPostLike> BlogPostLikes { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
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

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductColor> Colors { get; set; }

        public DbSet<ProductSize> Size { get; set; }
        public DbSet<Basket> Basket { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<ProductCatalogItem> ProductCatalogItems { get; set; }
        public DbSet<ProductRate> ProductRates { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<ZSHOEForgotPassword> ZSHOEForgetPasswords{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductCatalogItem>(cfg =>
            {
                cfg.HasKey(k => new {
                    k.ProductId,
                    k.ColorId,
                    k.SizeId
                });

                cfg.Property(p => p.Id).UseIdentityColumn();
            });

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ZSHOEDbContext).Assembly);
        }
    }
}
