--SQL Day 1 Additional :

--Rename a table

USE db4;
GO
EXEC emp_rename 'Employees', 'Emp';

--View Table Definition

EXEC emp_help 'dbo.Employees';

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

