using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class BuildHomeDBContext : DbContext
    {
        public BuildHomeDBContext(DbContextOptions<BuildHomeDBContext> options) : base(options)
        { }

        public DbSet<Item> Items;
        public DbSet<ItemCategory> ItemCategories { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustReceiptDetail> CustReceiptDetails { get; set; }
        public DbSet<CustReceiptHead> CustReceiptHeads { get; set; }
        public DbSet<GrnDetail> GrnDetails { get; set; }
        public DbSet<GrnHead> GrnHeads { get; set; }
        public DbSet<ItemFac> ItemFacs { get; set; }
        public DbSet<ItemFacInv> ItemFacInvs { get; set; }
        public DbSet<MiscExpencesHead> MiscExpencesHeads { get; set; }
        public DbSet<MiscExpencesDetail> MiscExpencesDetails { get; set; }
        public DbSet<MiscIncomeHead> MiscIncomeHeads { get; set; }
        public DbSet<MiscIncomeDetail> MiscIncomeDetails { get; set; }
        public DbSet<SrnDetail> SrnDetails { get; set; }
        public DbSet<SrnHead> SrnHeads { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


    }

}
