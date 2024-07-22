-- return result of one column to the power of 2nd column

CREATE TABLE decimals (
  id SERIAL PRIMARY KEY,
  number1 DOUBLE PRECISION,
  number2 DOUBLE PRECISION
);

INSERT INTO decimals (number1, number2) VALUES
(3.14159, 2.71828),
(1.41421, 1.73205),
(0.57721, 0.69314),
(1.61803, 2.23606),
(2.64575, 3.31662),
(1.23456, 6.78901),
(7.12345, 8.98765),
(4.56789, 3.45678),
(2.34567, 1.23456),
(9.87654, 8.76543);

SELECT POWER(number1, number2) AS result FROM decimals;
