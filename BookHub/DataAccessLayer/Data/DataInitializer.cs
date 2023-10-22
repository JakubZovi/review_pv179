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
        SeedBookWishlist(modelBuilder);
    }


    private static void SeedAuthor(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                Id = 1,
                FirstName = "J. R. R.",
                LastName = "Tolkien",
                DateOfBirth = new DateTime(1892, 1, 3),
                DateOfDeath = new DateTime(1973, 9, 2)
            },
            new Author
            {
                Id = 2,
                FirstName = "Douglas",
                LastName = "Adams",
                DateOfBirth = new DateTime(1952, 3, 11),
                DateOfDeath = new DateTime(2001, 5, 11)
            },
            new Author
            {
                Id = 3,
                FirstName = "Cal",
                LastName = "Newport",
                DateOfBirth = new DateTime(1982, 6, 23),
                DateOfDeath = null
            },
            new Author
            {
                Id = 4,
                FirstName = "Peter",
                LastName = "Wohlleben",
                DateOfBirth = new DateTime(1964, 6, 29),
                DateOfDeath = null
            },
            new Author
            {
                Id = 5,
                FirstName = "Frank",
                LastName = "Herbert",
                DateOfBirth = new DateTime(1920, 10, 8),
                DateOfDeath = new DateTime(1986, 2, 11)
            },
            new Author
            {
                Id = 6,
                FirstName = "Aldous",
                LastName = "Huxley",
                DateOfBirth = new DateTime(1894, 7, 26),
                DateOfDeath = new DateTime(1963, 11, 22)
            },
            new Author
            {
                Id = 7,
                FirstName = "George",
                LastName = "Orwell",
                DateOfBirth = new DateTime(1903, 6, 25),
                DateOfDeath = new DateTime(1950, 1, 21)
            },
            new Author
            {
                Id = 8,
                FirstName = "Ernest",
                LastName = "Hemingway",
                DateOfBirth = new DateTime(1899, 7, 21),
                DateOfDeath = new DateTime(1961, 7, 2)
            },
            new Author
            {
                Id = 9,
                FirstName = "F. Scott",
                LastName = "Fitzgerald",
                DateOfBirth = new DateTime(1896, 9, 24),
                DateOfDeath = new DateTime(1940, 12, 21)
            },
            new Author
            {
                Id = 10,
                FirstName = "Isaac",
                LastName = "Asimov",
                DateOfBirth = new DateTime(1920, 1, 2),
                DateOfDeath = new DateTime(1992, 4, 6)
            }
        );
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
                Id = 2,
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
            },
            new Book
            {
                Id = 5,
                PublisherId = 1,
                Name = "Dune",
                Isbn = "978-0-399-15522-4",
                Description =
                    "Dune is a science fiction novel by Frank Herbert, published in 1965. It is the first novel in the Dune series and explores themes of politics, religion, and ecology on the desert planet of Arrakis.",
                PublicationDate = new DateTime(1965, 8, 1)
            },
            new Book
            {
                Id = 6,
                PublisherId = 1,
                Name = "Dune Messiah",
                Isbn = "978-0-441-17273-9",
                Description =
                    "Dune Messiah is the second novel in the Dune series by Frank Herbert, published in 1969. It continues the story of Paul Atreides as he navigates the complex politics and power struggles of the Dune universe.",
                PublicationDate = new DateTime(1969, 2, 1)
            },
            new Book
            {
                Id = 7,
                PublisherId = 1,
                Name = "Children of Dune",
                Isbn = "978-0-441-17274-6",
                Description =
                    "Children of Dune is the third novel in the Dune series by Frank Herbert, published in 1976. It follows the continuing story of the Atreides family and the challenges they face on Arrakis.",
                PublicationDate = new DateTime(1976, 4, 1)
            },
            new Book
            {
                Id = 8,
                PublisherId = 1,
                Name = "God Emperor of Dune",
                Isbn = "978-0-441-17275-3",
                Description =
                    "God Emperor of Dune is the fourth novel in the Dune series by Frank Herbert, published in 1981. It takes place 3,500 years after the events of the original trilogy and explores the rule of Leto II.",
                PublicationDate = new DateTime(1981, 6, 1)
            },
            new Book
            {
                Id = 9,
                PublisherId = 1,
                Name = "Heretics of Dune",
                Isbn = "978-0-441-17276-0",
                Description =
                    "Heretics of Dune is the fifth novel in the Dune series by Frank Herbert, published in 1984. It takes place 1,500 years after the events of God Emperor of Dune and explores the conflict between the Bene Gesserit and the Honored Matres.",
                PublicationDate = new DateTime(1984, 8, 1)
            },
            new Book
            {
                Id = 10,
                PublisherId = 1,
                Name = "Chapterhouse: Dune",
                Isbn = "978-0-441-17277-7",
                Description =
                    "Chapterhouse: Dune is the sixth novel in the Dune series by Frank Herbert, published in 1985. It takes place 1,500 years after the events of Heretics of Dune and explores the conflict between the Bene Gesserit and the Honored Matres.",
                PublicationDate = new DateTime(1985, 2, 1)
            },
            new Book
            {
                Id = 11,
                PublisherId = 1,
                Name = "The Fellowship of the Ring",
                Isbn = "978-0-618-05799-2",
                Description =
                    "The Fellowship of the Ring is the first novel in J. R. R. Tolkien's The Lord of the Rings trilogy. It was originally published in 1954 and has since been adapted into a film trilogy, a television series, and a video game.",
                PublicationDate = new DateTime(1954, 7, 29)
            },
            new Book
            {
                Id = 12,
                PublisherId = 1,
                Name = "The Two Towers",
                Isbn = "978-0-618-05799-2",
                Description =
                    "The Two Towers is the second novel in J. R. R. Tolkien's The Lord of the Rings trilogy. It was originally published in 1954 and has since been adapted into a film trilogy, a television series, and a video game.",
                PublicationDate = new DateTime(1954, 11, 11)
            },
            new Book
            {
                Id = 13,
                PublisherId = 1,
                Name = "The Return of the King",
                Isbn = "978-0-618-05799-2",
                Description =
                    "The Return of the King is the third novel in J. R. R. Tolkien's The Lord of the Rings trilogy. It was originally published in 1955 and has since been adapted into a film trilogy, a television series, and a video game.",
                PublicationDate = new DateTime(1955, 10, 20)
            },
            new Book
            {
                Id = 14,
                PublisherId = 1,
                Name = "The Great Gatsby",
                Isbn = "978-0-618-05799-2",
                Description =
                    "The Great Gatsby is a 1925 novel by American author F. Scott Fitzgerald. It was originally published by Charles Scribner's Sons and has since been adapted into a film, a television series, and a video game.",
                PublicationDate = new DateTime(1925, 4, 10)
            },
            new Book
            {
                Id = 15,
                PublisherId = 1,
                Name = "Brave New World",
                Isbn = "978-0-618-05799-2",
                Description =
                    "Brave New World is a 1932 novel by English author Aldous Huxley. It was originally published by Chatto & Windus and has since been adapted into a film, a television series, and a video game.",
                PublicationDate = new DateTime(1932, 1, 1)
            },
            new Book
            {
                Id = 16,
                PublisherId = 1,
                Name = "1984",
                Isbn = "978-0-618-05799-2",
                Description =
                    "1984 is a 1949 novel by English author George Orwell. It was originally published by Secker & Warburg and has since been adapted into a film, a television series, and a video game.",
                PublicationDate = new DateTime(1949, 6, 8)
            },
            new Book
            {
                Id = 17,
                PublisherId = 1,
                Name = "Animal Farm",
                Isbn = "978-0-618-05799-2",
                Description =
                    "Animal Farm is a 1945 novel by English author George Orwell. It was originally published by Secker & Warburg and has since been adapted into a film, a television series, and a video game.",
                PublicationDate = new DateTime(1945, 8, 17)
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
        modelBuilder.Entity<Price>()
            .HasData(
                new Price
                {
                    Id = 1,
                    BookId = 1, 
                    PriceValue = 9.99m,
                    Currency = "USD",
                    Date = new DateTime(2023, 10, 20)
                },
                new Price
                {
                    Id = 2,
                    BookId = 2,
                    PriceValue = 12.99m,
                    Currency = "EUR",
                    Date = new DateTime(2023, 10, 21)
                },
                new Price
                {
                    Id = 3,
                    BookId = 3,
                    PriceValue = 8.49m,
                    Currency = "GBP",
                    Date = new DateTime(2023, 10, 22)
                },
                new Price
                {
                    Id = 4,
                    BookId = 4,
                    PriceValue = 14.95m,
                    Currency = "USD",
                    Date = new DateTime(2023, 10, 23)
                }
            );

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
        modelBuilder.Entity<Rating>().HasData(
            new Rating
            {
                Id = 1,
                Stars = 4,
                Review = "Enjoyed the book!",
                UserId = 1,
                BookId = 1,
            },
            new Rating
            {
                Id = 2,
                Stars = 5,
                Review = "Excellent read!",
                UserId = 2,
                BookId = 2,
            },
            new Rating
            {
                Id = 3,
                Stars = 3,
                Review = "Not bad, but could be better.",
                UserId = 1,
                BookId = 3,
            },
            new Rating
            {
                Id = 4,
                Stars = 5,
                Review = "Outstanding!",
                UserId = 3, 
                BookId = 4, 
            },
            new Rating
            {
                Id = 5,
                Stars = 4,
                Review = "A solid book.",
                UserId = 1,
                BookId = 1,
            }
        );
    }

    private static void SeedUser(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Gender = "Male",
                Email = "john.doe@example.com",
                PasswordHash = "YourPasswordHash1", // Store the actual password hash
                IsAdmin = false
            },
            new User
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Gender = "Female",
                Email = "jane.smith@example.com",
                PasswordHash = "YourPasswordHash2", // Store the actual password hash
                IsAdmin = true
            },
            new User
            {
                Id = 3,
                FirstName = "Alice",
                LastName = "Johnson",
                Gender = "Female",
                Email = "alice.johnson@example.com",
                PasswordHash = "YourPasswordHash3", // Store the actual password hash
                IsAdmin = false
            },
            new User
            {
                Id = 4,
                FirstName = "Bob",
                LastName = "Brown",
                Gender = "Male",
                Email = "bob.brown@example.com",
                PasswordHash = "YourPasswordHash4", // Store the actual password hash
                IsAdmin = false
            },
            new User
            {
                Id = 5,
                FirstName = "Ella",
                LastName = "Davis",
                Gender = "Female",
                Email = "ella.davis@example.com",
                PasswordHash = "YourPasswordHash5", // Store the actual password hash
                IsAdmin = false
            }
            // Add more User entities as needed
        );
    }

    private static void SeedWishlist(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Wishlist>().HasData(
            new Wishlist
            {
                Id = 1,
                Name = "Science Fiction Books",
                UserId = 1, // Associate the wishlist with a user (adjust the UserId as needed)
            },
            new Wishlist
            {
                Id = 2,
                Name = "Fantasy Novels",
                UserId = 2, // Associate the wishlist with a different user (adjust the UserId as needed)
            },
            new Wishlist
            {
                Id = 3,
                Name = "Mystery Novels",
                UserId = 1, // Associate the wishlist with the same user or another user (adjust the UserId as needed)
            },
            new Wishlist
            {
                Id = 4,
                Name = "Classic Literature",
                UserId = 3, // Associate the wishlist with a different user (adjust the UserId as needed)
            },
            new Wishlist
            {
                Id = 5,
                Name = "Biographies",
                UserId = 2, // Associate the wishlist with the same user or another user (adjust the UserId as needed)
            });
    }

    private static void SeedBookGenre(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasMany(book => book.Genres)
            .WithMany(genre => genre.Books)
            .UsingEntity(j => j.HasData(
                new { BooksId = 1, GenresId = 1 },
                new { BooksId = 1, GenresId = 17 },
                new { BooksId = 2, GenresId = 2 },
                new { BooksId = 2, GenresId = 17 },
                new { BooksId = 3, GenresId = 11 },
                new { BooksId = 3, GenresId = 16 },
                new { BooksId = 4, GenresId = 16 }
            ));
    }

    private static void SeedBookWishlist(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasMany(book => book.Wishlist)
            .WithMany(wishlist =>  wishlist.Books)
            .UsingEntity(j => j.HasData(
                new { BooksId = 5, WishlistId = 1 },
                new { BooksId = 6, WishlistId = 1 },
                new { BooksId = 7, WishlistId = 1 },
                new { BooksId = 8, WishlistId = 1 },
                new { BooksId = 1, WishlistId = 2 }
            ));
    }

    private static void SeedBookAuthor(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasMany(book => book.Author)
            .WithMany(author =>  author.Books)
            .UsingEntity(j => j.HasData(
                new { BooksId = 1, AuthorId = 1 },
                new { BooksId = 2, AuthorId = 2 },
                new { BooksId = 3, AuthorId = 3 },
                new { BooksId = 4, AuthorId = 4 },
                new { BooksId = 5, AuthorId = 5 },
                new { BooksId = 6, AuthorId = 5 },
                new { BooksId = 7, AuthorId = 5 },
                new { BooksId = 8, AuthorId = 5 }
            ));
    }
}