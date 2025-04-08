CREATE DATABASE LibraryManagementDB;
GO
USE LibraryManagementDB;

-- Authors Table
CREATE TABLE Authors (
    AuthorId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    Bio NVARCHAR(MAX)
);


-- Books Table
CREATE TABLE Books (
    BookId INT PRIMARY KEY IDENTITY,
    Title NVARCHAR(100) NOT NULL,
    AuthorId INT FOREIGN KEY REFERENCES Authors(AuthorId),
    PublishedYear INT,
    Genre NVARCHAR(50)
);

-- Students Table
CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE
);

-- IssuedBooks Table
CREATE TABLE IssuedBooks (
    IssueId INT PRIMARY KEY IDENTITY,
    BookId INT FOREIGN KEY REFERENCES Books(BookId),
    StudentId INT FOREIGN KEY REFERENCES Students(StudentId),
    IssueDate DATETIME NOT NULL,
    ReturnDate DATETIME,
    IsReturned BIT DEFAULT 0
);

