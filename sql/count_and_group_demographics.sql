CREATE TABLE demographics (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    birthday DATE NOT NULL,
    race VARCHAR(50)
);
INSERT INTO demographics (name, birthday, race) VALUES
    ('Alice', '1990-05-15', 'White'),
    ('Bob', '1985-12-10', 'Black'),
    ('Charlie', '1992-08-25', 'Asian'),
    ('David', '1988-04-03', 'Hispanic'),
    ('Emma', '1995-07-20', 'White'),
    ('Frank', '1980-11-12', 'Black'),
    ('Grace', '1998-03-08', 'Asian'),
    ('Henry', '1975-09-30', 'Hispanic'),
    ('Isabella', '1993-06-18', 'White'),
    ('Jack', '1982-01-05', 'Black'),
    ('Katherine', '1991-10-22', 'Asian'),
    ('Leo', '1987-02-14', 'Hispanic'),
    ('Mia', '1997-09-01', 'White'),
    ('Noah', '1984-08-17', 'Black'),
    ('Olivia', '1989-12-28', 'Asian');

SELECT race, COUNT(race) 
FROM demographics
GROUP BY race
ORDER BY count DESC;