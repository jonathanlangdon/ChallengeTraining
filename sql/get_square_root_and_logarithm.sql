-- return a table where you take square root and log10 of two columns

CREATE TABLE decimals (
  id SERIAL PRIMARY KEY,
  number1 DECIMAL,
  number2 DECIMAL
);

INSERT INTO decimals (number1, number2) VALUES
(9.0, .001),
(16, 101);

SELECT sqrt(number1) AS root, log(number2) AS log FROM decimals