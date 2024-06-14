-- join 2 tables and return select

CREATE TABLE companies (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL
);

INSERT INTO companies (name) VALUES
('Company A'),
('Company B'),
('Company C'),
('Company D'),
('Company E'),
('Company F'),
('Company G'),
('Company H'),
('Company I'),
('Company J');


CREATE TABLE products (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    isbn VARCHAR(13) NOT NULL,
    company_id INT NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (company_id) REFERENCES companies(id)
);

INSERT INTO products (name, isbn, company_id, price) VALUES
('Product 1', '9781234567897', 1, 10.99),
('Product 2', '9782345678901', 2, 15.49),
('Product 3', '9783456789012', 3, 7.99),
('Product 4', '9784567890123', 4, 25.99),
('Product 5', '9785678901234', 5, 9.99),
('Product 6', '9786789012345', 6, 12.49),
('Product 7', '9787890123456', 7, 14.99),
('Product 8', '9788901234567', 8, 19.99),
('Product 9', '9789012345678', 9, 5.99),
('Product 10', '9780123456789', 10, 20.00);


SELECT products.*, companies.name AS company_name 
FROM products JOIN companies ON companies.id = company_id