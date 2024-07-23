-- select 3 african countries that start with E

CREATE TABLE countries (
    country VARCHAR(255),
    capital VARCHAR(255),
    continent VARCHAR(255)
);

INSERT INTO countries (country, capital, continent) VALUES
('Egypt', 'Cairo', 'Afrika'),
('Ethiopia', 'Addis Ababa', 'Africa'),
('Eritrea', 'Asmara', 'Africa'),
('Equatorial Guinea', 'Malabo', 'Africa'),
('Eswatini', 'Mbabane', 'Africa'),
('United States', 'Washington, D.C.', 'North America'),
('Canada', 'Ottawa', 'North America'),
('Brazil', 'Brasilia', 'South America'),
('Argentina', 'Buenos Aires', 'South America'),
('Germany', 'Berlin', 'Europe'),
('Estonia', 'Paris', 'Europe'),
('United Kingdom', 'London', 'Europe'),
('Russia', 'Moscow', 'Europe'),
('China', 'Beijing', 'Asia'),
('Japan', 'Tokyo', 'Asia'),
('India', 'New Delhi', 'Asia'),
('Australia', 'Canberra', 'Australia'),
('New Zealand', 'Wellington', 'Australia'),
('South Africa', 'Pretoria', 'Africa'),
('Nigeria', 'Abuja', 'Africa');

SELECT capital FROM countries
WHERE continent LIKE 'Afri%a' AND country LIKE 'E%'
ORDER BY capital ASC
LIMIT 3;