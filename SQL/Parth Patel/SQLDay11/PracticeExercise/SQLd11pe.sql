--SQL Day 11

--Stored Procedure

--PRACTICE EXERCISE

--Creating Store Procedure

USE db5
GO
CREATE PROCEDURE EmpTest1
@LastName nVarchar(50),
@FirstName nVarchar(50)
AS
SET NOCOUNT ON;
SELECT FirstName,LastName,Department
FROM Employee
WHERE FirstName=@FirstName AND LastName=@LastName
AND JoiningDate IS NULL;
GO
select * from Employee

--Executing Store Procedure


EXECUTE EmpTest1 N'Ackerman',N'Pilar';
--or
EXEC EmpTest1 @LastName = N'Ackerman',@FirstName = N'Pilar'
GO
--or
EXECUTE EmpTest1 @FirstName = N'Pilar',@LastName = N'Ackerman'
GO

--Return Values For Store Procedure

--By using the Output Parameters

CREATE PROCEDURE prcEmp @EmpId INT,@DepName CHAR(50) OUTPUT,@JobId CHAR(20) OUTPUT
AS	
BEGIN
IF EXISTS(SELECT * FROM Employees  WHERE EmployeeID=@EmpId)
BEGIN
SELECT @DepName=d.DepartmentName,@JobId = h.JobId
FROM Departments d JOIN JobHistory h
ON d.DepartmentID= h.DepartmentID 
WHERE EmployeeID=@EmpId AND h.EndDate IS NULL
RETURN 0
END

--Call a Procedure frmom Another Procedure

CREATE PROCEDURE prcEmp1 @EmpId INT
AS	
BEGIN
DECLARE @DepName CHAR(50),@JobId VARCHAR(20),@ReturnValue INT
EXEC @ReturnValue = prcGet @EmpId,@DepName OUTPUT,@JobId
OUTPUT
IF(@ReturnValue = 0)
BEGIN 
PRINT 'The details of an employee with ID' + convert(char(10),@EmpId)
PRINT 'Department Name: ' + @DepName
PRINT 'Job Id:' + convert(char(1),@JobId)
SELECT ManagerId FROM Employees
WHERE EmployeeID=@EmpId
END 
ELSE
 PRINT 'No records found'
END
 
IF EXISTS(SELECT * FROM Employees  WHERE EmployeeID=@EmpId)
BEGIN
SELECT @DepName=d.DepartmentName,@JobId = h.JobId
FROM Departments d JOIN JobHistory h
ON d.DepartmentID= h.DepartmentID 
WHERE EmployeeID=@EmpId AND h.EndDate IS NULL
RETURN 0
END


