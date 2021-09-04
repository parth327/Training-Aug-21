--SQL Cursor Assignment

--Using cursor implement the following task employee
--Update the salary of the employee using following condition
--Salary between 300000and 400000 ----- 50000 hike
--Salary between 400000 and 550000----- 70000 hike
--Salary between 550000 and 650000 ----- 90000 hike

DECLARE @TempSalary MONEY
DECLARE @TempId INT
DECLARE CUR_EMP CURSOR FOR
SELECT EmployeeID,Salary 
FROM Employee

OPEN CUR_EMP

FETCH NEXT FROM CUR_EMP INTO @TempId,@TempSalary

WHILE @@FETCH_STATUS = 0
BEGIN  
--Salary between 300000 and 400000 ----- 50000 hike
	IF @TempSalary>300000 AND @TempSalary<400000 
   		UPDATE Employee
		SET Salary = Salary+50000
		WHERE EmployeeID=@TempId
--Salary between 400000 and 550000 ----- 70000 hike
	IF @TempSalary>4000000 AND @TempSalary<550000 
   		UPDATE Employee
		SET Salary = Salary+70000
		WHERE EmployeeID=@TempId
--Salary between 550000 and 650000 ----- 90000 hike
	IF @TempSalary>550000 AND @TempSalary<650000 
   		UPDATE Employee
		SET Salary = Salary+90000
		WHERE EmployeeID=@TempId

 	FETCH NEXT FROM CUR_EMP INTO @TempId,@TempSalary
END 
CLOSE CUR_EMP  

DEALLOCATE CUR_EMP

select * from Employee
