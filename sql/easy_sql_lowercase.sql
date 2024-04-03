-- return a table with a column in lowercase

SELECT id, name, birthday, LOWER(race) as race FROM demographics;