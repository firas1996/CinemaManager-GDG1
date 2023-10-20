﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CinemaManager_GDG1.Models.Cinema;

public partial class CinemaDbGdg1Context : DbContext
{
    public CinemaDbGdg1Context()
    {
    }

    public CinemaDbGdg1Context(DbContextOptions<CinemaDbGdg1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Producer> Producers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:CinemaCS");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producer__3214EC07AD9425A5");

            entity.ToTable("Producer");

            entity.Property(e => e.Email).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Nationality).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}