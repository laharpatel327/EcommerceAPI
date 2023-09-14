using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EcommerceCheckoutAPI.Models;

public class CatalogContext : DbContext
{
    public CatalogContext()
    {
    }

    public CatalogContext(DbContextOptions<CatalogContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WatchCatalogue> WatchCatalogues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=LAHAR;Database=Catalog;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WatchCatalogue>(entity =>
        {
            entity.HasKey(e => e.WatchId).HasName("PK__WatchCat__3BA3DAA332D59D0D");

            entity.ToTable("WatchCatalogue");

            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.WatchName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

    }


}
