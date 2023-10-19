using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data;

public static class DataInitializer
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        SeedAuthor(modelBuilder);
        SeedBook(modelBuilder);
        SeedGenre(modelBuilder);
        SeedPrice(modelBuilder);
        SeedPublisher(modelBuilder);
        SeedPurchase(modelBuilder);
        SeedPurchaseBook(modelBuilder);
        SeedRating(modelBuilder);
        SeedUser(modelBuilder);
        SeedWishlist(modelBuilder);

        // Many-to-many relationships
        SeedBookGenre(modelBuilder);
        SeedBookAuthor(modelBuilder);
        SeedBookPrice(modelBuilder);
        SeedBookRating(modelBuilder);
        SeedBookWishlist(modelBuilder);
    }


    private static void SeedAuthor(ModelBuilder modelBuilder)
    {
    }

    private static void SeedBook(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book
            {
                Id = 1,
                PublisherId = 1,
                Name = "The Hobbit",
                Isbn = "978-0-261-10235-4",
                Description =
                    "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published on 21 September 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction. The book remains popular and is recognized as a classic in children's literature.",
                PublicationDate = new DateTime(1937, 9, 21)
            },
            new Book
            {
                Id = 42,
                PublisherId = 2,
                Name = "Hitchhiker's Guide to the Galaxy",
                Isbn = "978-0-330-25864-0",
                Description =
                    "The Hitchhiker's Guide to the Galaxy is a comic science fiction series created by Douglas Adams that has become popular among fans of the genre and members of the scientific community. Phrases from it are widely recognised and often used in reference to, but outside the context of, the source material. Many writers on popular science, such as Fred Alan Wolf, Paul Davies and Michio Kaku, have used quotations in their books to illustrate facts about cosmology or philosophy. It is one of the most frequently referred-to books on Stack Overflow and other programming question-and-answer sites, despite not actually being a programming manual.",
                PublicationDate = new DateTime(1979, 10, 12)
            },
            new Book
            {
                Id = 3,
                PublisherId = 3,
                Name = "Digital Minimalism: Choosing a Focused Life in a Noisy World",
                Isbn = "978-0-525-53357-0",
                Description =
                    "Digital Minimalism: Choosing a Focused Life in a Noisy World is a self-help book by Cal Newport, a professor of computer science at Georgetown University. The book argues that individuals should reduce their digital technology usage in order to live a more focused and fulfilling life.",
                PublicationDate = new DateTime(2019, 2, 5)
            },
            new Book
            {
                Id = 4,
                PublisherId = 4,
                Name = "Hidden Life of Trees: What They Feel, How They Communicate: Discoveries from a Secret World",
                Isbn = "978-1-77164-248-4",
                Description =
                    "Hidden Life of Trees: What They Feel, How They Communicate: Discoveries from a Secret World is a 2015 book by Peter Wohlleben, published in English by Greystone Books in 2016. The book argues that trees are social beings.",
                PublicationDate = new DateTime(2015, 9, 13)
            }
        );
    }

    private static void SeedGenre(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>()
            .HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Fantasy"
                },
                new Genre
                {
                    Id = 2,
                    Name = "Science Fiction"
                },
                new Genre
                {
                    Id = 3,
                    Name = "Horror"
                },
                new Genre
                {
                    Id = 4,
                    Name = "Romance"
                },
                new Genre
                {
                    Id = 5,
                    Name = "Mystery"
                },
                new Genre
                {
                    Id = 6,
                    Name = "Thriller"
                },
                new Genre
                {
                    Id = 7,
                    Name = "Historical Fiction"
                },
                new Genre
                {
                    Id = 8,
                    Name = "Western"
                },
                new Genre
                {
                    Id = 9,
                    Name = "Memoir"
                },
                new Genre
                {
                    Id = 10,
                    Name = "Biography"
                },
                new Genre
                {
                    Id = 11,
                    Name = "Self-Help"
                },
                new Genre
                {
                    Id = 12,
                    Name = "Health"
                },
                new Genre
                {
                    Id = 13,
                    Name = "Travel"
                },
                new Genre
                {
                    Id = 14,
                    Name = "Guide"
                },
                new Genre
                {
                    Id = 15,
                    Name = "Children's"
                },
                new Genre
                {
                    Id = 16,
                    Name = "Non-Fiction"
                },
                new Genre
                {
                    Id = 17,
                    Name = "Fiction"
                }
            );
    }

    private static void SeedPrice(ModelBuilder modelBuilder)
    {
    }

    private static void SeedPublisher(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Publisher>().HasData(
            new Publisher
            {
                Id = 1,
                Name = "George Allen & Unwin",
                Address = "40 Museum Street, London, England"
            },
            new Publisher
            {
                Id = 2,
                Name = "Pan Books",
                Address = "5 York Street, London, England"
            },
            new Publisher
            {
                Id = 3,
                Name = "Portfolio",
                Address = "375 Hudson Street, New York, NY"
            },
            new Publisher
            {
                Id = 4,
                Name = "Greystone Books",
                Address = "203-2323 Quebec Street, Vancouver, BC"
            }
        );
    }

    private static void SeedPurchase(ModelBuilder modelBuilder)
    {
    }

    private static void SeedPurchaseBook(ModelBuilder modelBuilder)
    {
    }

    private static void SeedRating(ModelBuilder modelBuilder)
    {
    }

    private static void SeedUser(ModelBuilder modelBuilder)
    {
    }

    private static void SeedWishlist(ModelBuilder modelBuilder)
    {
    }

    private static void SeedBookGenre(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasMany(book => book.Genres)
            .WithMany(genre => genre.Books)
            .UsingEntity(j => j.HasData(
                new { BooksId = 1, GenresId = 1 },
                new { BooksId = 1, GenresId = 17 },
                new { BooksId = 42, GenresId = 2 },
                new { BooksId = 42, GenresId = 17 },
                new { BooksId = 3, GenresId = 11 },
                new { BooksId = 3, GenresId = 16 },
                new { BooksId = 4, GenresId = 16 }
            ));
    }

    private static void SeedBookWishlist(ModelBuilder modelBuilder)
    {
    }

    private static void SeedBookRating(ModelBuilder modelBuilder)
    {
    }

    private static void SeedBookPrice(ModelBuilder modelBuilder)
    {
    }

    private static void SeedBookAuthor(ModelBuilder modelBuilder)
    {
    }
}