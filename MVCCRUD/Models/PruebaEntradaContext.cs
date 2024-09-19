using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;
using MVCCRUD.Models;

namespace MVCCRUD.Models;

public partial class PruebaEntradaContext : DbContext
{
    public PruebaEntradaContext()
    {
    }

    public PruebaEntradaContext(DbContextOptions<PruebaEntradaContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
          //  #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        // optionsBuilder.UseMySql("server=localhost;port=3306;database=pruebaEntrada;uid=root;password=fikmortvy02479bd", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.35-mysql"));
        }

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

public DbSet<MVCCRUD.Models.Usuario> Usuario { get; set; } = default!;
}
