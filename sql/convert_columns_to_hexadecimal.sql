-- convert columns into hexadecimal

CREATE TABLE monsters (
  id SERIAL PRIMARY KEY,
  name VARCHAR(50) NOT NULL,
  legs INT,
  arms INT,
  characteristics VARCHAR(150)
);

INSERT INTO monsters (name, legs, arms) VALUES
('one', 4, 5),
('two', 6, 5),
('three', 9, 14),
('four', 12, 17);

SELECT to_hex(legs) AS legs, to_hex(arms) AS arms FROM monsters;