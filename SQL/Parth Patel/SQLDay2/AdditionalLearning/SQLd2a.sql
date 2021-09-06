--Day2 Additional

--Updating User-defined Types

--Using a system data type

UPDATE Cities  SET Location = CONVERT(Point, '12.3:46.2') WHERE Name = 'Anchorage';

--Invoking a method

UPDATE Cities SET Location.SetXY(23.5, 23.5) WHERE Name = 'Anchorage';

--Modifying the value of a property or data member

UPDATE Cities SET Location.X = 23.5 WHERE Name = 'Anchorage';

--Using the UPDATE statement with a WHERE clause

UPDATE Employees SET FirstName = 'Gail' WHERE EmployeeKey = 100;

--Using the UPDATE statement with label

UPDATE Employees SET Salary = 8000 WHERE EmployeeID = 103 OPTION (LABEL = N'label1');

