--SQL Day 1 Additional :

--Rename a table

USE db4;
GO
EXEC emp_rename 'Employees', 'Emp';

--View Table Definition

EXEC emp_help 'dbo.Employees';

--View the Dependencies of a table

USE db4;
GO 
SELECT * FROM sys.sql_expression_dependencies  
WHERE EmployeeId = OBJECT_ID(N'Employees');
GO

--Rename column

EXEC emp_rename 'Employees.EmployeeID', 'EmpID', 'COLUMN';

--Copy column from one table to another

USE db4;
GO  
CREATE TABLE dbo.EmployeeSales( BusinessEntityID   varchar(11) NOT NULL,SalesYTD money NOT NULL);  
GO INSERT INTO dbo.EmployeeSales SELECT BusinessEntityID, SalesYTD FROM Sales.SalesPerson;GO

--Specify computed columns in a table

ALTER TABLE dbo.Employees ADD Total AS (Salary + CommissionPct);

--Specify Default values for a column

CREATE TABLE doc (Id INT,Salary INT CONSTRAINT doc_Salary DEFAULT 8000);

--Switch the Query Editor connection to the TestData database

USE TestData 
GO

--create a view

CREATE VIEW vw_Name AS SELECT FirstName, Salary FROM Employees;
GO

--test a view

SELECT * FROM vw_Name;
GO

--create a stored procedure

CREATE PROCEDURE pr_Name @VarSalary money AS BEGIN PRINT 'Salary less than ' + CAST(@VarSalary AS varchar(10));
SELECT FirstName, Salary FROM vw_Name WHERE Salary < @varSalary;
END 
GO

--test the stored procedure

EXECUTE pr_Name 10.00; 
GO

--supplementry char

DECLARE @x NVARCHAR(10) = 'ab' + NCHAR(0x10000);  
SELECT CAST (@x AS NVARCHAR(3));

--using both cast and convert

-- Use CAST  

USE db4;  
GO  
SELECT SUBSTRING(Name, 1, 30) AS FirstName,Salary  
FROM Employees  
WHERE CAST(Salary AS int) > 8000  
GO  
  
-- Use CONVERT.  
USE db4;  
GO  
SELECT SUBSTRING(FirstName, 1, 30) AS FirstName, Salary  
FROM Employees  
WHERE CONVERT(int,Salary) >8000  
GO

