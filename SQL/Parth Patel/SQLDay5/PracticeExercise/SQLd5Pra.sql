--Day 5 Practice Exercise

--JOINs

--INNER JOIN

SELECT e.EmployeeID,e.JobId,eph.DepartmentID,eph.ManagerID FROM Employees e
JOIN Employees eph ON e.EmployeeID = eph.EmployeeID;

--OUTER JOIN

--LEFT OUTER JOIN

SELECT e.EmployeeID,d.ManagerID,d.DepartmentName FROM Employees e 
LEFT OUTER JOIN Departments d ON e.DepartmentID=d.DepartmentID ; 

--RIGHT OUTER JOIN

SELECT e.EmployeeID,d.ManagerID,d.DepartmentName FROM Employees e 
RIGHT OUTER JOIN Departments d ON e.DepartmentID=d.DepartmentID ; 

--FULL OUTER JOIN

SELECT e.EmployeeID,e.FirstName,d.LocationID,d.DepartmentName FROM Employees e FULL OUTER JOIN Departments d ON e.DepartmentID=d.DepartmentID;

--SELF JOIN

SELECT e.EmployeeID,e.JobId AS Designation,m.ManagerID FROM Employees e,Employees m WHERE e.ManagerID=m.ManagerID;



