CREATE TABLE names (
  id SERIAL PRIMARY KEY,
  prefix VARCHAR(20),
  first VARCHAR(50) NOT NULL,
  last VARCHAR(50) NOT NULL,
  suffix VARCHAR(20)
 );
 
 
 INSERT INTO names (prefix, first, last, suffix) VALUES
('Mr.', 'John', 'Doe', NULL),
('Ms.', 'Jane', 'Smith', NULL),
('Dr.', 'Emily', 'Jones', 'PhD'),
('Mrs.', 'Linda', 'Brown', NULL),
('Mr.', 'James', 'Wilson', 'Jr.'),
(NULL, 'Michael', 'Taylor', NULL),
('Miss', 'Sophia', 'Anderson', NULL),
('Prof.', 'William', 'Thomas', 'MD'),
('Dr.', 'Olivia', 'Moore', NULL),
('Ms.', 'Emma', 'Martin', NULL);

SELECT COALESCE(prefix, '') || ' ' || COALESCE(first, '') || ' ' || COALESCE(last, '') || ' ' || COALESCE(suffix, '') AS title
FROM names