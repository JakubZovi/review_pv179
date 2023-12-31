﻿using System.Diagnostics;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data;

public class BookHubDbContext : DbContext
{
    public virtual required DbSet<Author> Authors { get; set; }
    public virtual required DbSet<Book> Books { get; set; }
    public virtual required DbSet<Genre> Genres { get; set; }
    public virtual required DbSet<Price> Prices { get; set; }
    public virtual required DbSet<Publisher> Publishers { get; set; }
    public virtual required DbSet<Purchase> Purchases { get; set; }
    public virtual required DbSet<Rating> Ratings { get; set; }
    public virtual required DbSet<User> Users { get; set; }
    public virtual required DbSet<Wishlist> Wishlists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var dbPath = Path.Join(Environment.GetFolderPath(folder), "BookHub.db");

        optionsBuilder
            .UseSqlite($"Data Source={dbPath}")
            .LogTo(s => Debug.WriteLine(s))
            .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();

        base.OnModelCreating(modelBuilder);
    }
}