--DAY 6.1 Practice Exercise

--VIEW

CREATE VIEW Emp AS (SELECT d.DepartmentName,e.FirstName,e.HireDate FROM Employees AS e JOIN Departments d
ON e.DepartmentID=d.DepartmentID)

--Query the View

SELECT e.FirstName,e.LastName,e.HireDate FROM Employees e ORDER BY HireDate

--CTE 

WITH CTE(EmployeeID,HireDate)
AS(SELECT EmployeeID,COUNT(*) FROM Employees WHERE EmployeeID IS NOT NULL GROUP BY EmployeeID )
SELECT AVG(HireDate) AS 'avg' FROM CTE


