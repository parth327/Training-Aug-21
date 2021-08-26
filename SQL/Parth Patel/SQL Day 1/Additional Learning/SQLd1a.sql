--SQL Day 1 Additional :

--Rename a table

USE AdventureWorks2012;GO
EXEC sp_rename 'Sales.SalesTerritory', 'SalesTerr';

--View Table Definition

EXEC sp_help 'dbo.Employees';

--View the Dependencies of a table

USE AdventureWorks2012;GO SELECT * FROM sys.sql_expression_dependencies  WHERE referenced_id = OBJECT_ID(N'Production.Product');GO

--Rename column

EXEC sp_rename 'Sales.SalesTerritory.TerritoryID', 'TerrID', 'COLUMN';

--Copy column from one table to another

USE AdventureWorks2012;GO  
CREATE TABLE dbo.EmployeeSales( BusinessEntityID   varchar(11) NOT NULL,SalesYTD money NOT NULL);  
GO INSERT INTO dbo.EmployeeSales SELECT BusinessEntityID, SalesYTD FROM Sales.SalesPerson;GO

--Specify computed columns in a table

ALTER TABLE dbo.Products ADD RetailValue AS (QtyAvailable * UnitPrice * 1.5);

--Specify Default values for a column

CREATE TABLE dbo.doc_exz (column_a INT,column_b INT CONSTRAINT DF_Doc_Exz_Column_B DEFAULT 50);

--Switch the Query Editor connection to the TestData database

USE TestData GO;

--create a view

CREATE VIEW vw_Names AS SELECT ProductName, Price FROM Products; GO

--test a view

SELECT * FROM vw_Names;GO

--create a stored procedure

CREATE PROCEDURE pr_Names @VarPrice money AS BEGIN PRINT 'Products less than ' + CAST(@VarPrice AS varchar(10));SELECT ProductName, Price FROM vw_Names WHERE Price < @varPrice;END GO

--test the stored procedure

EXECUTE pr_Names 10.00; GO

--CAST and CONVERT

DECLARE @myval DECIMAL (5, 2);SET @myval = 193.57; 
SELECT CAST(CAST(@myval AS VARBINARY(20)) AS DECIMAL(10,5));  
SELECT CONVERT(DECIMAL(10,5), CONVERT(VARBINARY(20), @myval));

USE AdventureWorks2012;GO  
SELECT p.FirstName, p.LastName, SUBSTRING(p.Title, 1, 25) AS Title,CAST(e.SickLeaveHours AS char(1)) AS [Sick Leave] 
FROM HumanResources.Employee e JOIN Person.Person p 
ON e.BusinessEntityID = p.BusinessEntityID  
WHERE NOT e.BusinessEntityID > 5;

SELECT  CAST(10.6496 AS INT) as trunc1,CAST(-10.6496 AS INT) as trunc2,CAST(10.6496 AS NUMERIC) as round1,CAST(-10.6496 AS NUMERIC) as round2;

--supplementry char

DECLARE @x NVARCHAR(10) = 'ab' + NCHAR(0x10000);  
SELECT CAST (@x AS NVARCHAR(3));

--using both cast and convert

-- Use CAST  
USE AdventureWorks2012;  
GO  
SELECT SUBSTRING(Name, 1, 30) AS ProductName, ListPrice  
FROM Production.Product  
WHERE CAST(ListPrice AS int) LIKE '33%';  
GO  
  
-- Use CONVERT.  
USE AdventureWorks2012;  
GO  
SELECT SUBSTRING(Name, 1, 30) AS ProductName, ListPrice  
FROM Production.Product  
WHERE CONVERT(int, ListPrice) LIKE '33%';  
GO

