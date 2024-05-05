-- fizz buzz May 2024

SELECT
  CASE
    WHEN number % 3 = 0 AND number % 5 = 0 THEN 'FizzBuzz'
    WHEN number % 3 = 0 THEN 'Fizz'
    WHEN number % 5 = 0 THEN 'Buzz'
    ELSE CAST (number AS VARCHAR)
  END AS result
FROM generate_series(1, 100) AS number;