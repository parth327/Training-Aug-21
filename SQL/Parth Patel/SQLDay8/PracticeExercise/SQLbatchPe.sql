--SQL Batch Practice Exercise

--Batch

--Variables

DECLARE @Salary VARCHAR(15)
SELECT @Salary = MAX(Salary)
FROM Employees
GO

--Programming Construct in SQL

--IF-ELSE

DECLARE @Salary money
SELECT @Salary = Salary FROM Employees
WHERE EmployeeID=102
IF @Salary < 5000
PRINT 'Review of the Salary is Required'
ELSE
BEGIN
PRINT 'Review of the Salary is not Required'
PRINT 'Salary='
PRINT @Salary
END 
GO

--CASE statement

SELECT EmployeeID, Salary,
CASE
    WHEN Salary > 8000 THEN 'The quantity is greater than 8000'
    WHEN Salary = 8000 THEN 'The quantity is 8000'
    ELSE 'The quantity is under 8000'
END AS Sal
FROM Employees; 

--WHILE Statement

WHILE(SELECT AVG(Salary) FROM Employees) < 5000
BEGIN
	UPDATE Employees
	SET Salary = Salary*0.5
	SELECT MAX(Salary) FROM Employees
	IF(SELECT MAX(Salary) FROM Employees) > 10000
	BREAK 
	ELSE
	CONTINUE
	END
	PRINT 'High'

