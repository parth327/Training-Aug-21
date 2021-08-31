--VIEW AND CTE assignment

--VIEW QUERIES :

--Create a view to select FirstName,LastName,Salary,JoiningDate,IncentiveDate and IncentiveAmount

CREATE VIEW Emp1 AS (SELECT e.FirstName,e.LastName,e.Salary,e.HireDate AS JoiningDate,i.IncentiveDate,i.IncentiveAmount FROM Employees e JOIN Incentive i
ON e.DepartmentID=i.EmployeeID);

--Create a view to select Select first_name, incentive amount from employee and incentives table for those employees who have incentives and incentive amount greater than 3000

CREATE VIEW Emp2
AS(SELECT e.FirstName,i.IncentiveAmount FROM Employees e INNER JOIN Incentive i 
ON e.EmployeeID=i.EmployeeID  WHERE IncentiveAmount>3000);

--Create a View to Find the names (first_name, last_name), job, department number, and department name of the employees who work in London

CREATE VIEW Emp3
AS(SELECT e.FirstName,e.LastName,e.JobId,d.DepartmentId,d.DepartmentName FROM Employees e JOIN Departments d ON e.DepartmentID=d.DepartmentID
JOIN Locations l ON l.LocationID=d.DepartmentID)

--Create a View to get the department name and number of employees in the department.

CREATE VIEW Emp4
AS(SELECT d.DepartmentName,COUNT(e.EmployeeId) AS NoOfEmp FROM Employees e 
JOIN Departments d ON e.DepartmentID=d.DepartmentID GROUP BY d.DepartmentName)

--Write a View to display the department name, manager name, and city.

CREATE VIEW Emp5
AS(SELECT d.DepartmentName,e.FirstName AS ManagerName,l.City FROM Employees e 
JOIN Departments d ON e.DepartmentID=d.DepartmentID 
JOIN Locations l ON d.LocationID=l.LocationID )

--Create a View to display department name, name (first_name, last_name), hire date, salary of the manager for all managers whose experience is more than 15 years.

CREATE VIEW Emp6
AS(SELECT D.DepartmentName,CONCAT(E.FirstName,E.LastName) AS Name,E.HireDate,E.Salary FROM Employees E
JOIN Departments D ON E.EmployeeID=D.DepartmentID JOIN JobHistory J ON E.EmployeeID=J.EmployeeID 
WHERE DATEDIFF(YEAR,J.EndDate,J.StartDate) >15);


--CTE Queries

--CTE with ROW_NUMBER 

WITH CTE1(EmployeeID,Salary)
AS(SELECT Salary,ROW_NUMBER() OVER(ORDER BY Salary) SALARY FROM Employees)
SELECT AVG(Salary) AS 'AvgSal' FROM CTE1

--CTE with Rank

--(Order By Clause is invalid in CTE)

WITH CTE2(EmployeeID,Salary)
AS(SELECT Salary,RANK() OVER(ORDER BY Salary DESC) Rank FROM Employees)
SELECT AVG(Salary) AS 'AvgSal' FROM CTE2;
 
--Use Dense_rank 

WITH CTE3(EmployeeID,Salary)
AS (SELECT Salary,DENSE_RANK() OVER(ORDER BY Salary DESC) Rank FROM Employees)
SELECT AVG(Salary) AS 'AvgSal' FROM CTE3;  

--CTE with Aggrigate Functions

WITH CTE4(EmployeeID,Salary)
AS (SELECT Salary,SUM(Salary) AS TotalSalary FROM Employees GROUP BY EmployeeID,Salary)
SELECT SUM(Salary) AS 'TSal' FROM CTE4

WITH CTE4(EmployeeID,Salary)
AS (SELECT Salary,COUNT(Salary) AS TotalSalary FROM Employees GROUP BY EmployeeID,Salary)
SELECT COUNT(Salary) AS 'NoOfSal' FROM CTE4

WITH CTE4(EmployeeID,Salary)
AS (SELECT Salary,AVG(Salary) AS TotalSalary FROM Employees GROUP BY EmployeeID,Salary)
SELECT AVG(Salary) AS 'AvgSal' FROM CTE4

WITH CTE4(EmployeeID,Salary)
AS (SELECT Salary,MIN(Salary) AS TotalSalary FROM Employees GROUP BY EmployeeID,Salary)
SELECT MIN(Salary) AS 'MinSal' FROM CTE4

WITH CTE4(EmployeeID,Salary)
AS (SELECT Salary,MAX(Salary) AS TotalSalary FROM Employees GROUP BY EmployeeID,Salary)
SELECT MAX(Salary) AS 'MaxSal' FROM CTE4

--CTE with Group By CUBE ()

WITH CTE4(EmployeeID,Salary)
AS (SELECT EmployeeID,MAX(Salary) AS TotalSal FROM Employees GROUP BY CUBE(EmployeeID,Salary))
SELECT MAX(Salary) AS 'MaxSal' FROM CTE4

--CTE with Group BY Grouping Sets()

WITH CTE4(EmployeeID,Salary)
AS(SELECT GROUPING(Salary),AVG(Salary) Commisssion FROM Employees GROUP BY GROUPING SETS (Salary)) 
SELECT AVG(Salary) AS 'Commission' FROM CTE4;

--CTE with Having

WITH CTE4(EmployeeID,Salary)
AS (SELECT COUNT(EmployeeID),Salary FROM Employees GROUP BY Salary HAVING COUNT(EmployeeID) > 5)
SELECT AVG(Salary) AS 'Avg' FROM CTE4;

--CTE with ROLLUP

WITH CTE4(EmployeeID,Salary)
AS (SELECT COUNT(EmployeeID),Salary AS TotalSalary FROM Employees GROUP BY ROLLUP (Salary))
SELECT AVG(Salary) AS 'Avg' FROM CTE4;

--CTE with JOINS


--CTE with INNER JOIN

WITH CTE4(EmployeeID,Salary)
AS (SELECT e.EmployeeID,e.Salary FROM Employees e
JOIN Employees eph ON e.EmployeeID = eph.EmployeeID)
SELECT AVG(Salary) AS 'AvgSal' FROM CTE4;

--CTE with LEFT OUTER JOIN

WITH CTE4(EmployeeID,Salary)
AS (SELECT e.EmployeeID,e.Salary FROM Employees e
LEFT OUTER JOIN Employees eph ON e.EmployeeID = eph.EmployeeID)
SELECT AVG(Salary) AS 'AvgSal' FROM CTE4;

--CTE with RIGHT OUTER JOIN

WITH CTE4(EmployeeID,Salary)
AS (SELECT e.EmployeeID,e.Salary FROM Employees e
RIGHT OUTER JOIN Employees eph ON e.EmployeeID = eph.EmployeeID)
SELECT AVG(Salary) AS 'AvgSal' FROM CTE4;

--CTE with FULL OUTER JOIN


WITH CTE4(EmployeeID,Salary)
AS (SELECT e.EmployeeID,e.Salary FROM Employees e
FULL OUTER JOIN Employees eph ON e.EmployeeID = eph.EmployeeID)
SELECT AVG(Salary) AS 'AvgSal' FROM CTE4;

--CTE with SELF JOIN

WITH CTE4(EmployeeID,Salary)
AS (SELECT e.EmployeeID,s.Salary FROM Employees e,Employees s WHERE e.EmployeeID=s.Salary)
SELECT AVG(Salary) AS 'AvgSal' FROM CTE4;