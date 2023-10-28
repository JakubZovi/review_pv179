# PV179 - BookHub

## Members

- Martin Gargalovič (485612)
- Juraj Fiala (485316)
- Matej Hakoš (492968)

## Overview

This document provides an overview of the "BookHub" application, an online platform designed to facilitate the purchase
of books. It offers users a rich set of features to explore, buy, and manage their book collections. This document is
intended to guide technical stakeholders, developers, and administrators involved in the development and maintenance of
the application.

### Key Features

- **User Registration and Authentication:** Users can create accounts or log in to the "BookHub" platform, ensuring
  secure access to their profiles and features.

- **Browse Books:** Users can browse a rich collection of books available on the platform, exploring details, cover
  images, descriptions, and other relevant information.

- **Book Purchase:** Users have the ability to purchase books directly through the application, with secure payment
  processing.

- **Wishlist Management:** Users can create and manage wishlists, adding desired books for future consideration and easy
  access.

- **Book Ratings and Reviews:** Users can rate and review books, providing valuable feedback and recommendations to
  the "BookHub" community.

- **Author Management:** CRUD operations are supported for authors, allowing for the addition, modification, and removal
  of author profiles.

- **Book Management:** CRUD operations are supported for books, enabling the addition, modification, and removal of book
  listings.

- **Book Filtering:** Users can filter and search for books based on genres, Authors and other Book related Categories,
  simplifying the process of discovering new books.

## Diagrams

### Use Case Diagram

![Use Case Diagram](./docs/Book%20Hub%20UCD.png)

### Database Schema

![ERD Diagram](./docs/Book%20Hub%20ERD.png)

## Middlewares

### Authentication Middleware

This middleware is used to authenticate the user. It uses Basic Authentication, set Authorization header to "
IBetYouCanNotGuessThisOne".

### Logging Middleware

This middleware is used to log the requests and responses.

### Timing Middleware

This middleware is used to measure the time it takes for the request to be processed.

## API Endpoints

For more interactive documentation, please refer to the Swagger UI at http://localhost:5259/swagger/index.html (you have
to run the application first). The server uses Basic Authentication, see the Authentication Middleware section above.
### Author

- GET /api/Author
- GET /api/Author/{id}
- PUT /api/Author/{id}
- POST /api/Author
- DELETE /api/Author/{id}

Other endpoints are similar to Author. For more information, please refer to the Swagger UI.

## Setup and Build

The project is built via .NET v7 and uses SQLite as a database. Clone this repository and follow the instructions below
to build and run the project.

### Clone Repository

```
git clone git@gitlab.fi.muni.cz:xhakos/pv179-bookhub.git
```

### Build

```
cd ./pv179-bookhub/BookHub
dotnet build
```

Might also need to do migration/update of the database

```
dotnet ef database update
```

### Run Bookhub

Assuming that you are in the project directory (dir containing the solution file)

```
dotnet run -p ./BookHub
```

And you should be good to go. There is only swagger UI available at the moment: http://localhost:5259/swagger/index.html

## Building Release

```
cd ./pv179-bookhub/BookHub
dotnet build -c Release
```