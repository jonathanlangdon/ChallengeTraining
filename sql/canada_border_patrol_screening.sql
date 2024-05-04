-- select people not from canada, mexico or USA

SELECT name, country FROM travelers WHERE country NOT IN ('Canada', 'Mexico', 'USA')