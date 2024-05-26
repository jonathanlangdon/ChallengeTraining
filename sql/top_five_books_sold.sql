-- list top 5 best selling books

CREATE TABLE books (
  id SERIAL PRIMARY KEY,
  name VARCHAR(100) NOT NULL,
  author VARCHAR(100) NOT NULL,
  copies_sold INT
);

INSERT INTO books (name, author, copies_sold) VALUES
('To Kill a Mockingbird', 'Harper Lee', 500),
('1984', 'George Orwell', 30),
('The Great Gatsby', 'F. Scott Fitzgerald', 250),
('The Catcher in the Rye', 'J.D. Salinger', 20),
('The Hobbit', 'J.R.R. Tolkien', 10),
('Fahrenheit 451', 'Ray Bradbury', 150),
('Pride and Prejudice', 'Jane Austen', 70),
('The Chronicles of Narnia', 'C.S. Lewis', 120),
('Moby-Dick', 'Herman Melville', 50),
('War and Peace', 'Leo Tolstoy', 360),
('Crime and Punishment', 'Fyodor Dostoevsky', 25),
('The Brothers Karamazov', 'Fyodor Dostoevsky', 180),
('Brave New World', 'Aldous Huxley', 50),
('Harry Potter and the Sorcerer''s Stone', 'J.K. Rowling', 120),
('The Lord of the Rings', 'J.R.R. Tolkien', 150);

SELECT name, author, copies_sold FROM books
ORDER BY copies_sold DESC
LIMIT 5;