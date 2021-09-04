--SQL Cursor Practice Exercise

--Cursor in SQL server

-- 1 - Declare Variables

DECLARE @name VARCHAR(50) 
DECLARE @path VARCHAR(256) 
DECLARE @fileName VARCHAR(256)  
DECLARE @fileDate VARCHAR(20) 

SET @path = 'C:\Backup\' 

SELECT @fileDate = CONVERT(VARCHAR(20),GETDATE(),112) 

-- 2 - Declare Cursor

DECLARE db_cursor CURSOR FOR 

SELECT name 
FROM MASTER.dbo.sysdatabases 
WHERE name NOT IN ('master','model','msdb','tempdb') 

-- 3 - Fetch the next record from the cursor

FETCH NEXT FROM db_cursor INTO @name  

WHILE @@FETCH_STATUS = 0  
 
BEGIN  
	
-- 4 - Begin the custom business logic

SET @fileName = @path + @name + '_' + @fileDate + '.BAK' 
BACKUP DATABASE @name TO DISK = @fileName 

-- 5  Fetch the next record from the cursor
 	
	FETCH NEXT FROM db_cursor INTO @name 
END 

-- 6 - Close the cursor

CLOSE db_cursor  

-- 7 - Deallocate the cursor

DEALLOCATE db_cursor 


--Cursor Example

SET NOCOUNT ON
DECLARE @Id INT,@name VARCHAR(50),@salary INT
DECLARE cur_emp CURSOR
STATIC FOR

SELECT EmployeeId,FirstName,Salary FROM Employees
OPEN cur_emp
IF @@CURSOR_ROWS > 0
BEGIN
FETCH NEXT FROM cur_emp INTO @Id,@name,@salary
WHILE @@FETCH_STATUS = 0
BEGIN
PRINT 'ID : ' + CONVERT (VARCHAR(20),@Id)+',Name : '+@name+ ', Salary :
'+CONVERT(VARCHAR(20),@salary)
FETCH NEXT FROM cur_emp INTO @Id,@name,@salary
END
END
CLOSE cur_emp
DEALLOCATE cur_emp
SET NOCOUNT OFF

