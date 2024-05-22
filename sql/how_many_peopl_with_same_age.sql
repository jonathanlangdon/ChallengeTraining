-- count how many people have same age

CREATE TABLE people (
  id SERIAL PRIMARY KEY,
  name VARCHAR(100) NOT NULL,
  age INT NOT NULL
);

INSERT INTO people (name, age) VALUES
('John Doe', 28),
('Jane Smith', 34),
('Alice Johnson', 45),
('Bob Brown', 23),
('Charlie Davis', 34),
('Diana Evans', 28),
('Ethan Wilson', 41),
('Fiona Harris', 33),
('George Clark', 52),
('Hannah Lewis', 25),
('Ian Walker', 39),
('Julia Hall', 45),
('Kevin Young', 31),
('Laura King', 36),
('Michael Scott', 41),
('Bill Smith', 25);

SELECT age, COUNT(*) AS people_count FROM people
GROUP BY age ORDER BY age;