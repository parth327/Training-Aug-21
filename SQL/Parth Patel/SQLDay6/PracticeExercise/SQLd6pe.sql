--SQL Day 6 Practice Exercise

--USE ANY in SubQueries

SELECT DepartmentName FROM Departments
WHERE DepartmentID = ANY(SELECT DepartmentID Departments WHERE DepartmentID = 10);

--USE ALL in SubQueries

SELECT DepartmentName FROM Departments
WHERE DepartmentID = ALL(SELECT DepartmentID Departments WHERE DepartmentID = 10);

--USE Exists in SubQueries

SELECT DepartmentName FROM Departments
WHERE EXISTS (SELECT DepartmentName FROM Departments WHERE DepartmentID = DepartmentID );

--Use IN in SubQueris

SELECT DepartmentName FROM Departments
WHERE DepartmentName IN (SELECT DepartmentName FROM Departments WHERE DepartmentID = DepartmentID );

--Use NOT IN in SubQueries

SELECT DepartmentName FROM Departments
WHERE DepartmentName NOT IN (SELECT DepartmentName FROM Departments WHERE DepartmentID = DepartmentID );

--NESTED SubQueries

SELECT DepartmentID FROM Employees WHERE EmployeeID = (SELECT EmployeeID FROM Employees 
WHERE ManagerId=(SELECT ManagerId FROM Departments WHERE ManagerID=200)) 

--Correlated SubQueries

SELECT * FROM Employees e WHERE Salary =(SELECT MAX(Salary) 
FROM Employees d WHERE e.DepartmentID=d.DepartmentID) 	

--SubQueries With Alias

SELECT e1.EmployeeID, e1.EmployeeID FROM Employees AS e1
INNER JOIN Employees AS e2
ON e1.EmployeeID = e2.EmployeeID
AND e2.EmployeeID = 204;
