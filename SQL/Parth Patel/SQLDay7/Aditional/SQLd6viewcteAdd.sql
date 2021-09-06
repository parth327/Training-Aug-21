--SQL DAY 6  Views and CTE Additional

--Partitioned Views

--Partitioned view as defined on Server1  
CREATE VIEW EmpD  
AS  
SELECT * FROM Employees e
UNION ALL  
SELECT * FROM Employees d
UNION ALL  
SELECT * FROM Employees l;  

--PERMISSIONS

--Using a simple CREATE VIEW

CREATE VIEW EmpA
AS SELECT d.DepartmentName,e.FirstName, e.LastName,e.EmployeeID,e.HireDate  
FROM Employees e JOIN Departments d 
ON e.DepartmentID = d.DepartmentID ; 
  
--Using WITH ENCRYPTION

CREATE VIEW PEmp 
WITH ENCRYPTION  
AS 
SELECT EmployeeID,HireDate,Salary  
FROM Employees  
WHERE Salary > 3000
AND HireDate > CONVERT(DATETIME,'20010630',101) ;  

--Using WITH CHECK OPTION

CREATE VIEW SCheck  
AS  
SELECT em.LastName, em.FirstName, e.JobId, l.City FROM Employees e  
INNER JOIN Employees em ON em.DepartmentID = e.DepartmentID  
INNER JOIN Departments d   
ON e.DepartmentID = d.DepartmentID   
INNER JOIN Departments da ON d.DepartmentID = e.DepartmentID  
INNER JOIN Locations l ON d.LocationID = l.LocationID  
WHERE l.City = 'Seattle' WITH CHECK OPTION ;  

--Using built-in functions within a view

CREATE VIEW WImp  
AS SELECT TOP (100)EmployeeID, SUM(Salary) AS TotalSal  
FROM Employees  
WHERE HireDate > CONVERT(DATETIME,'20001231',101)  
GROUP BY EmployeeID;  

--Using Partitioned Data
--Create the tables and insert the values.  

CREATE TABLE dbo.SUPPLY1 (  
supplyID INT PRIMARY KEY CHECK (supplyID BETWEEN 1 and 150),  
supplier CHAR(50)  
);
CREATE TABLE dbo.SUPPLY2 (  
supplyID INT PRIMARY KEY CHECK (supplyID BETWEEN 151 and 300),  
supplier CHAR(50)  
);  
CREATE TABLE dbo.SUPPLY3 (  
supplyID INT PRIMARY KEY CHECK (supplyID BETWEEN 301 and 450),  
supplier CHAR(50)  
);  
CREATE TABLE dbo.SUPPLY4 (  
supplyID INT PRIMARY KEY CHECK (supplyID BETWEEN 451 and 600),  
supplier CHAR(50)  
);  
GO  

--Create the view that combines all supplier tables.  

CREATE VIEW dbo.all_supplier_view  
WITH SCHEMABINDING  
AS  
SELECT supplyID, supplier  
  FROM dbo.SUPPLY1  
UNION ALL  
SELECT supplyID, supplier  
  FROM dbo.SUPPLY2  
UNION ALL  
SELECT supplyID, supplier  
  FROM dbo.SUPPLY3  
UNION ALL  
SELECT supplyID, supplier  
  FROM dbo.SUPPLY4;  
GO
INSERT dbo.all_supplier_view VALUES ('1', 'CaliforniaCorp'), ('5', 'BraziliaLtd')    
, ('231', 'FarEast'), ('280', 'NZ')  
, ('321', 'EuroGroup'), ('442', 'UKArchip')  
, ('475', 'India'), ('521', 'Afrique');  

--Creating a Simple View

CREATE VIEW Dim AS  
SELECT FirstName, LastName, HireDate   
FROM Employees;  

--Create a view by joining two tables

CREATE VIEW view1 
AS SELECT e.FirstName,e.EmployeeID,d.DepartmentID,d.DepartmentName  
FROM Employees e LEFT OUTER JOIN Departments d   
ON e.DepartmentID=d.DepartmentID;


--CTE Addditonal

--A. Creating a simple common table expression

-- Define the CTE expression name and column list.  

WITH Sales_CTE (SalesPersonID, SalesOrderID, SalesYear)  
AS  
(  
    SELECT EmployeeID, ManagerID, YEAR(HireDate) AS SalesYear  
    FROM Employees
    WHERE EmployeeID IS NOT NULL  
)  

-- Define the outer query referencing the CTE name.  

SELECT COUNT(SalesPersonID) AS Total, SalesYear  
FROM Sales_CTE  
GROUP BY SalesYear, SalesPersonID  
ORDER BY SalesPersonID, SalesYear;

--Using a common table expression to limit counts and report averages

WITH Sales_CTE (SalesPersonID, NumberOfOrders)  
AS (SELECT EmployeeID, COUNT(*) FROM Employees  
WHERE EmployeeID IS NOT NULL GROUP BY EmployeeID)  
SELECT AVG(NumberOfOrders) AS "Average Sales Per Person" FROM Sales_CTE;
