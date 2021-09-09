--SQL DAY 6  Views and CTE Additional

--PERMISSIONS

--Using a simple CREATE VIEW

CREATE VIEW EmpA
AS SELECT d.DepartmentName,e.FirstName, e.LastName,e.EmployeeID,e.HireDate  
FROM Employees e JOIN Departments d 
ON e.DepartmentID = d.DepartmentID ; 
  
--Using WITH ENCRYPTION
--The following example uses the WITH ENCRYPTION option and shows computed columns, renamed columns,
-- and multiple columns.
CREATE VIEW PEmp 
WITH ENCRYPTION  
AS 
SELECT EmployeeID,HireDate,Salary  
FROM Employees  
WHERE Salary > 3000
AND HireDate > CONVERT(DATETIME,'20010630',101) ;    

--Create a view by joining two tables

CREATE VIEW view1 AS 
SELECT e.EmployeeId, e.FirstName, d.DepartmentName  
FROM Empoyees e   
LEFT OUTER JOIN Departments AS d   
ON (d.DepartmentId=e.DepartmentId);

-- Define the outer query referencing the CTE name.  

SELECT COUNT(SalesPersonID) AS Total, SalesYear  
FROM Sales_CTE  
GROUP BY SalesYear, SalesPersonID  
ORDER BY SalesPersonID, SalesYear;

