--Day 2 Pracitice Exercise

--SELECT

SELECT * FROM Employees;

--INSERT

INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode, Country)
VALUES ('Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway');

--UPDATE

UPDATE Customers
SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
WHERE CustomerID = 1;

--DELETE

DELETE FROM Customers WHERE CustomerName='Alfreds Futterkiste';

--WHERE

SELECT * FROM Customers
WHERE Country='Mexico';

--RANGE

SELECT * FROM Products
WHERE Price BETWEEN 10 AND 20;

--IN

SELECT * FROM Customers
WHERE Country IN ('Germany', 'France', 'UK');

--NOT IN

SELECT * FROM Customers
WHERE Country NOT IN ('Germany', 'France', 'UK');

--LIKE

SELECT * FROM Customers
WHERE CustomerName LIKE 'a%';

--ORDERBY

SELECT * FROM Customers
ORDER BY Country;

--TOP

SELECT TOP 3 * FROM Customers;

--DISTINCT

SELECT DISTINCT Country FROM Customers;
