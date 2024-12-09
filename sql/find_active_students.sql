-- Select all students who are active

CREATE TABLE students (
    Id SERIAL PRIMARY KEY,
    FirstName TEXT NOT NULL,
    LastName TEXT NOT NULL,
    IsActive BOOLEAN NOT NULL
);

INSERT INTO students (FirstName, LastName, IsActive) VALUES
('Alice', 'Johnson', TRUE),
('Bob', 'Smith', FALSE),
('Carol', 'Davis', TRUE),
('David', 'Brown', FALSE),
('Eve', 'Miller', TRUE),
('Frank', 'Wilson', FALSE),
('Grace', 'Moore', TRUE),
('Hank', 'Taylor', FALSE),
('Ivy', 'Anderson', TRUE),
('Jack', 'Thomas', FALSE);

SELECT * FROM students WHERE IsActive = true;