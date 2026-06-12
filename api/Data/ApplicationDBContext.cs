using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Stock> Stocks {get; set; }
        public DbSet<Comment> Comments {get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = "32e6f556-498b-4ffe-86bb-2473fb09f9f5",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "b8b66999-3068-4d94-8670-3c8fa03a9cb5"
                },
                new IdentityRole
                {
                    Id = "a7815ce1-a608-4e42-bd58-db2ac9878597",
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = "271f8078-009c-4667-8bb4-80e3af479d14"
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}