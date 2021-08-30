--SQL Day 5 Assignment


--ASSIGNMENT 1:-

--Add a table First

CREATE TABLE Incentive (EmployeeID Decimal(6,0) CONSTRAINT emp_fk REFERENCES Employees(EmployeeID),
IncentiveDate DATE NOT NULL,IncentiveAmount MONEY NOT NULL);

INSERT INTO Incentive
 VALUES (100, '1987-08-17', 5000)
	,(101, '1987-08-18', 3000),(102, '1987-08-19', 2000),(102, '1987-08-20', 2000)
	,(102, '1987-08-21', 6000),(103, '1987-08-22', 5000);


--Query 1. Get difference between JOINING_DATE and INCENTIVE_DATE from employee and incentives table

SELECT DATEDIFF(MM,e.HireDate,i.IncentiveDate) AS 'DIFF'
FROM Employees AS e INNER JOIN Incentive AS i ON e.EmployeeID=i.EmployeeID

--Query 2. Select first_name, incentive amount from employee and incentives table for those employees who have incentives and incentive amount greater than 3000

SELECT e.FirstName,i.IncentiveAmount FROM Employees e INNER JOIN Incentive i 
ON e.EmployeeID=i.EmployeeID  WHERE IncentiveAmount>3000;

--Query 3. Select first_name, incentive amount from employee and incentives table for all employees even if they didn’t get incentives.

SELECT e.FirstName,i.IncentiveAmount
FROM Employees AS e LEFT OUTER JOIN Incentive AS i ON e.EmployeeID=i.EmployeeID

--Query 4. Select EmployeeName, ManagerName from the employee table.

SELECT e.FirstName AS EmployeeName,m.FirstName AS ManagerName FROM Employees e  
JOIN Employees m ON m.EmployeeID=e.ManagerID;

--Query 5. Select first_name, incentive amount from employee and incentives table for all employees even if they didn’t get incentives and set incentive amount as 0 for those employees who didn’t get incentives.

SELECT e.FirstName,ISNULL(i.IncentiveAmount,0) AS IncentiveAmount
FROM Employees AS e LEFT OUTER JOIN Incentive AS i ON e.EmployeeID=i.EmployeeID;

