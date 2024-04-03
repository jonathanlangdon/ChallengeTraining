-- find all customers with sales over 199 that have incorrect or missing emails

-- query finding records with NULL or mismatched addresses
WITH
address_join AS (
SELECT
  c.email,
  s.customerid,
  a.addressid
FROM addresses a
RIGHT JOIN sales s ON a.customerid = s.customerid
JOIN customers c ON c.customerid = s.customerid
WHERE a.addressid IS NULL OR s.addressid != a.addressid
),

-- Sales Reps Ranked by Experience
reprank AS (
  SELECT
	TRIM(CONCAT(salesreps.firstname, ' ', salesreps.lastname)) AS rep_name,
	ROW_NUMBER() OVER (ORDER BY hiredate) AS rank_salesrep
  FROM salesreps
),


-- customer id's with invalid addresses
invalid_emails AS (
  SELECT customerid
  FROM address_join
),

-- Full table of invalid addresses and identified with a message
invalid_messages AS (
SELECT DISTINCT
  email,
  customerid,
  addressid,
  CASE
      WHEN addressid IS NULL
   	 THEN 'You''ve spent enough money with us so we care about your business. You don''t have an address on file yet you''ve selected an address. Please login to our site and add an address so we may use it... Don''t ask any questions on how this happened.'
      ELSE 'You''ve spent enough money with us so we care about your business. Unfortunately you have selected a bad address. Please login to our site and select a good address.'
  END AS script
FROM address_join
)

-- Main Select statement
SELECT DISTINCT
  im.email,
  total_bought,
  rep_name,
  im.script
FROM
(SELECT
  email,
  customerid,
  total_bought,
  CASE
	WHEN ROW_NUMBER() OVER (ORDER BY total_bought DESC, email ASC) % 3 = 0
  	THEN (SELECT rep_name FROM reprank WHERE rank_salesrep = 3)
	WHEN ROW_NUMBER() OVER (ORDER BY total_bought DESC, email ASC) % 3 = 2
  	THEN (SELECT rep_name FROM reprank WHERE rank_salesrep = 2)
	ELSE (SELECT rep_name FROM reprank WHERE rank_salesrep = 1)
  END AS rep_name
FROM
-- Find customers who have invalid addresses and >=$199 in sales
(SELECT
  c.email,
  c.customerid,
  SUM(s.price) AS total_bought
FROM customers c
JOIN sales s ON c.customerid = s.customerid
WHERE c.customerid IN (SELECT customerid FROM invalid_emails)
GROUP BY c.customerid, c.email
HAVING SUM(s.price) >= 199
) AS invalid_email_sales) AS invalid_email_sales2
JOIN invalid_messages im ON invalid_email_sales2.customerid = im.customerid
ORDER BY total_bought DESC, email ASC

