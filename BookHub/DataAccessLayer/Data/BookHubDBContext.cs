using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data;

public class BookHubDBContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Price> Prices { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Wishlist> Wishlists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var dbPath = Path.Join(Environment.GetFolderPath(folder), "BookHub.db");

        optionsBuilder
            .UseSqlite($"Data Source={dbPath}")
            .LogTo(s => System.Diagnostics.Debug.WriteLine(s))
            .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Book - Publisher 1:m
        modelBuilder.Entity<Book>()
            .HasOne(book => book.Publisher)
            .WithMany(publisher => publisher.Books)
            .HasForeignKey(book => book.PublisherId)
            .OnDelete(DeleteBehavior.Restrict);


        // Book - Price 1:m
        modelBuilder.Entity<Price>()
            .HasOne(price => price.Book)
            .WithMany(book => book.Prices)
            .HasForeignKey(price => price.BookId)
            .OnDelete(DeleteBehavior.Restrict);

        
        // Rating - Book 1:m
        modelBuilder.Entity<Rating>()
            .HasOne(rating => rating.Book)
            .WithMany(book => book.Ratings)
            .HasForeignKey(rating => rating.BookId)
            .OnDelete(DeleteBehavior.Restrict);

        // Rating - User 1:m
        modelBuilder.Entity<Rating>()
            .HasOne(rating => rating.User)
            .WithMany(user => user.Ratings)
            .HasForeignKey(rating => rating.UserId)
            .OnDelete(DeleteBehavior.Restrict);
        
        // User : Purchase 1:m
        modelBuilder.Entity<Purchase>()
            .HasOne(purchase => purchase.User)
            .WithMany(user => user.Purchases)
            .HasForeignKey(purchase => purchase.UserId)
            .OnDelete(DeleteBehavior.Restrict);
        
        // Purchase : PurchaseBooks 1:m
        modelBuilder.Entity<Purchase>()
            .HasMany(purchase => purchase.PurchaseBooks)
            .WithOne(purchaseBook => purchaseBook.Purchase)
            .HasForeignKey(purchaseBook => purchaseBook.PurchaseId)
            .OnDelete(DeleteBehavior.Restrict);
        
        // Book - PurchaseBooks 1:m
        modelBuilder.Entity<Book>()
            .HasMany(book => book.PurchaseBooks)
            .WithOne(purchaseBook => purchaseBook.Book)
            .HasForeignKey(purchaseBook => purchaseBook.BookId)
            .OnDelete(DeleteBehavior.Restrict);
        
        
        // Book - Author m:n
        modelBuilder.Entity<Book>()
            .HasMany(book => book.Author)
            .WithMany(author => author.Books)
            .UsingEntity("BookToAuthorJoin");

        // Book - Genre m:n
        modelBuilder.Entity<Book>()
            .HasMany(book => book.Genres)
            .WithMany(genre => genre.Books)
            .UsingEntity("BookToGenreJoin");

        // Book - Wishlist m:n
        modelBuilder.Entity<Book>()
            .HasMany(book => book.Wishlist)
            .WithMany(wishlist => wishlist.Books)
            .UsingEntity("BookToWishlistJoin");
        

        base.OnModelCreating(modelBuilder);
    }
}