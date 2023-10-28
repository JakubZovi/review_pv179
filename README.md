# PV179 - BookHub

## Members

- Martin Gargalovič
- Juraj Fiala
- Matej Hakoš

## Assignment

Develop a digital platform for the company called "BookHub", a company that sells books of various genres. The platform should facilitate easy browsing and purchase of books, letting customers sort and filter by authors, publishers, and genres. After customers create accounts, they should be able to review their purchase history, rate books, and make wishlists. Administrators should have privileges to update book details, manage user accounts, and regulate book prices.

## Run Project

### Build

```
cd BookHub
dotnet build
```

Might also need to update the database

```
dotnet ef database update
```

### Run Bookhub

assuming that you are in the project directory (dir containing the solution file)

```
dotnet run -p ./BookHub
```

Considering that so far it only contains a couple of endpoints use : http://localhost:5259/swagger/index.html

## Diagrams

### Use Case Diagram

![Use Case Diagram](./docs/Book%20Hub%20UCD.png)

### ERD Diagram

![ERD Diagram](./docs/Book%20Hub%20ERD.png)

## Overview

This document provides a technical overview of the "BookHub" application, an online platform designed to facilitate the purchase of books. It offers users a rich set of features to explore, buy, and manage their book collections. This document is intended to guide technical stakeholders, developers, and administrators involved in the development and maintenance of the application.

### BookHub - Key Features Overview

- **User Registration and Authentication:** Users can create accounts or log in to the "BookHub" platform, ensuring secure access to their profiles and features.

- **Browse Books:** Users can browse a rich collection of books available on the platform, exploring details, cover images, descriptions, and other relevant information.

- **Book Purchase:** Users have the ability to purchase books directly through the application, with secure payment processing.

- **Wishlist Management:** Users can create and manage wishlists, adding desired books for future consideration and easy access.

- **Book Ratings and Reviews:** Users can rate and review books, providing valuable feedback and recommendations to the "BookHub" community.

- **Author Management:** CRUD operations are supported for authors, allowing for the addition, modification, and removal of author profiles.

- **Book Management:** CRUD operations are supported for books, enabling the addition, modification, and removal of book listings.

- **Book Filtering:** Users can filter and search for books based on genres, Authors and other Book related Categories, simplifying the process of discovering new books.
