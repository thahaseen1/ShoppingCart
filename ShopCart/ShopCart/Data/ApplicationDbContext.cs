using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ShopCart.Models;

namespace ShopCart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ShopCart.Models.Product> Product { get; set; }
        public DbSet<ShopCart.Models.Cart> Cart { get; set; }
        public DbSet<ShopCart.Models.Order> Order { get; set; }
        public DbSet<ShopCart.Models.OrderDetail> OrderDetail { get; set; }

    }
}
