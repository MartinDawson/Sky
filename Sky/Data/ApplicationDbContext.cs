using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sky.Components.channel;
using Sky.Components.customer;
using Sky.Components.portfolio;
using Sky.Components.reward;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sky.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ChannelSubscription> ChannelSubscriptions { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Reward> Rewards { get; set; }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
