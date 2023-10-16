using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data;

public static class DataInitializer
{
    public static void Seed(this ModelBuilder modelBuilder)
    {

    }

    private static List<User> _prepUsers()
    {
        return new List<User>();
    }

    private static List<Publisher> _prepPublishers()
    {
        return new List<Publisher>();
    }

    private static List<Genre> _prepGenre()
    {
        return new List<Genre>();
    }
    
    private static List<Author> _prepAuthors()
    {
        return new List<Author>();
    }
    
    private static List<Rating> _prepRatings()
    {
        return new List<Rating>();
    }
    
    private static List<Price> _prepPrices()
    {
        return new List<Price>();
    }

    private static List<Wishlist> _prepWishlist()
    {
        return new List<Wishlist>();
    }
    
    private static List<Purchase> _prepPurchases()
    {
        return new List<Purchase>();
    }
    
    private static List<Book> _prepBooks()
    {
        return new List<Book>();
    }
}