Overview

This repository contains the source code for a simple book store web application built with ASP.NET Core MVC. The application follows a typical layered architecture pattern, consisting of controllers, services, repositories, models, and validation components.

Controllers

BookController: Manages the interaction between user requests and the underlying services. It includes actions for handling requests related to viewing all books, viewing book details, adding new books, and updating existing books.

Services

IBookService: Defines the contract for interacting with book-related functionalities. Implemented by BookService, it provides methods for fetching all books, retrieving a book by ID, creating a new book, and updating an existing book.

Repositories

IBookRepository: Specifies the interface for data access operations related to books. Implemented by InMemoryBookRepository, it includes methods for retrieving all books, retrieving a book by ID, creating a new book, and updating an existing book in an in-memory data store.

Models

Book: Represents the entity model for a book, including properties such as ID, title, author, and publication year. BookCreateViewModel: Provides a view model for creating a new book, including validation rules for properties such as title, author, and publication year. BookViewModel: Represents a simplified view model for displaying book details.

Validation

YearRangeAttribute: A custom validation attribute applied to the Year property of the BookCreateViewModel class. It ensures that the publication year falls within a specified range.

Workflow

Viewing Books: Users can access the application to view a list of available books. Viewing Book Details: Detailed information about each book, such as title, author, and publication year, is accessible. Adding New Books: Users can add new books by providing required details, with validation checks ensuring data integrity. Updating Existing Books: Existing books can be updated with new information, maintaining consistency within the application.
