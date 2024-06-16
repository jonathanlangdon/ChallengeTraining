-- create a join that also uses a COUNT()

CREATE TABLE people (
  id SERIAL PRIMARY KEY,
  name VARCHAR(100) NOT NULL
);

CREATE TABLE toys (
  id SERIAL PRIMARY KEY,
  name VARCHAR(100) NOT NULL,
  people_id INT NOT NULL,
  FOREIGN KEY (people_id) REFERENCES people(id)
);

INSERT INTO people (name) VALUES
('John Doe'),
('Jane Smith'),
('Alice Johnson'),
('Bob Brown'),
('Charlie Davis'),
('Diana Evans'),
('Frank Green'),
('Grace Hall'),
('Henry Jones'),
('Ivy King');

INSERT INTO toys(name, people_id) VALUES
('Toy Car', 1),
('Doll', 2),
('Lego Set', 3),
('Action Figure', 4),
('Puzzle', 5),
('Board Game', 6),
('Train Set', 7),
('Bicycle', 8),
('Stuffed Animal', 9),
('Toy Robot', 10),
('Toy Airplane', 1),
('Toy Boat', 1),
('Puzzle Box', 2),
('Toy Train', 3),
('Play-Doh Set', 4),
('Toy Drum', 5),
('Rubiks Cube', 6),
('Frisbee', 7),
('Soccer Ball', 8),
('Basketball', 9),
('Toy Rocket', 10),
('Toy Telescope', 2),
('Toy Helicopter', 3),
('Toy Submarine', 4),
('Yo-Yo', 5);

SELECT people.*, COUNT(people_id) AS toy_count
FROM people JOIN toys ON people.id = people_id
GROUP BY people.id;