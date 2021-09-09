--Day2 Additional

--Updating User-defined Types

--Using the UPDATE statement with a WHERE clause

UPDATE Employees SET FirstName = 'Gail' WHERE EmployeeKey = 100;

--Using the UPDATE statement with label

UPDATE Employees SET Salary = 8000 WHERE EmployeeID = 103 OPTION (LABEL = N'label1');

