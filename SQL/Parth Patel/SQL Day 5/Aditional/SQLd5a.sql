--Day 5 Additional


--CROSS JOIN

SELECT e.EmployeeID,d.DepartmentName,e.Salary+e.CommissionPct AS Total FROM Employees e CROSS JOIN Departments d;

SELECT d.DepartmentName,e.EmployeeID FROM Employees e CROSS JOIN Departments d;

--Add Where clause

 SELECT d.DepartmentName,e.EmployeeID FROM Employees e CROSS JOIN Departments d WHERE e.EmployeeID=d.DepartmentID;

--UNION

SELECT DepartmentID FROM Departments UNION SELECT Salary FROM Employees ORDER BY DepartmentID;

--UNION ALL

SELECT DepartmentID FROM Departments UNION ALL SELECT Salary FROM Employees ORDER BY DepartmentID;

--MERGE


MERGE Departments  AS d

USING Employees  AS e

ON (d.DepartmentName=e.FirstName)

WHEN MATCHED

THEN UPDATE SET d.ManagerID = e.ManagerID
	
WHEN NOT MATCHED BY Departments 

THEN INSERT (DepartmentID, DepartmentName,ManagerID) VALUES (e.DepartmentID,e.FirstName,e.ManagerID);



