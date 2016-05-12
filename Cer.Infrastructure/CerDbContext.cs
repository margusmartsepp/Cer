﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Cer.Core.Abstractions;
using Cer.Core.Models;

namespace Cer.Infrastructure
{
    class CerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<EquipmentItem> EquipmentItems { get; set; }
        public DbSet<RentItem> RentItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<IIdentifiableEntity<int>>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
