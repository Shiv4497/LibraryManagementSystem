INSERT INTO Authors (Name, Bio) VALUES ('J.K. Rowling', 'Author of Harry Potter');
INSERT INTO Books (Title, AuthorId, PublishedYear, Genre) VALUES ('Harry Potter 1', 1, 1997, 'Fantasy');
INSERT INTO Students (FullName, Email) VALUES ('John Doe', 'john@example.com');
INSERT INTO IssuedBooks (BookId, StudentId, IssueDate) VALUES (1, 1, GETDATE());
