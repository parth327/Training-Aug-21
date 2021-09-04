--SQL Cursor Additional

--Using simple cursor and syntax

DECLARE v_cursor CURSOR  
    FOR SELECT * FROM Employees

OPEN v_cursor  
FETCH NEXT FROM v_cursor;

--FETCH Cursor in SQL server

--Example 1

DECLARE emp_Cursor CURSOR FOR
select EmployeeID,FirstName,Salary 
from Employees

OPEN emp_Cursor;
FETCH NEXT FROM emp_Cursor;
WHILE @@FETCH_STATUS = 0
 BEGIN
 FETCH NEXT FROM emp_Cursor;
 END;
CLOSE emp_Cursor;
DEALLOCATE emp_Cursor;
GO

--Example 2

declare @db4 nvarchar(100);
declare @lgname  nvarchar(100);
declare crs cursor for
select original_login_name, DB_NAME(database_id) as db_nm
from sys.dm_exec_sessions where is_user_process=1;
open crs
fetch next FROM crs into @lgname, @db4 
while @@FETCH_STATUS=0
begin
print 'Login:'+cast(@lgname as nvarchar(100))+' Database Name:'+@db4
fetch next from crs into @lgname, @db4
end
close crs
deallocate crs;

--CLOSE

DECLARE Emp_Cursor CURSOR FOR  
SELECT EmployeeID, JobId FROM Employees;  
OPEN Emp_Cursor;  
FETCH NEXT FROM Emp_Cursor;  
WHILE @@FETCH_STATUS = 0  
   BEGIN  
      FETCH NEXT FROM Emp_Cursor;  
   END;  
CLOSE Emp_Cursor;  
DEALLOCATE Emp_Cursor;  
GO  

--Deallocate

DECLARE abc CURSOR GLOBAL SCROLL FOR  
    SELECT * FROM Employees;  
OPEN abc;  
GO  
DECLARE @MyCrsrRef1 CURSOR;  
SET @MyCrsrRef1 = abc;  
DEALLOCATE @MyCrsrRef1;  
FETCH NEXT FROM abc;  
GO  
DECLARE @MyCrsrRef2 CURSOR;  
SET @MyCrsrRef2 = abc;  
DEALLOCATE abc;  
FETCH NEXT FROM @MyCrsrRef2;  
GO  
DECLARE @MyCursor CURSOR;  
SET @MyCursor = CURSOR LOCAL SCROLL FOR  
SELECT * FROM Employees;  
DEALLOCATE @MyCursor;  
GO  

--FETCH

--Using Simple Cursor

DECLARE contact_cursor CURSOR FOR  
SELECT LastName FROM Employees  
WHERE LastName LIKE 'B%'  
ORDER BY LastName;  
  
OPEN contact_cursor;  
    
FETCH NEXT FROM contact_cursor;  
  
WHILE @@FETCH_STATUS = 0  
BEGIN  

   FETCH NEXT FROM contact_cursor;  
END  
  
CLOSE contact_cursor;  
DEALLOCATE contact_cursor;  
GO

--To store values in Variables 

DECLARE @LastName VARCHAR(50), @FirstName VARCHAR(50);  
  
DECLARE contact_cursor CURSOR FOR  
SELECT LastName, FirstName FROM Employees  
WHERE LastName LIKE 'B%'  
ORDER BY LastName, FirstName;  
  
OPEN contact_cursor;  
  
FETCH NEXT FROM contact_cursor  
INTO @LastName, @FirstName;  
  
WHILE @@FETCH_STATUS = 0  
BEGIN  
  
   PRINT 'Contact Name: ' + @FirstName + ' ' +  @LastName  
  
   FETCH NEXT FROM contact_cursor  
   INTO @LastName, @FirstName;  
END  
  
CLOSE contact_cursor;  
DEALLOCATE contact_cursor;  
GO

--Declaring a SCROLL cursor and using the other FETCH options
 
SELECT LastName, FirstName FROM Employees
ORDER BY LastName, FirstName;  
    
DECLARE contact_cursor SCROLL CURSOR FOR  
SELECT LastName, FirstName FROM Employees  
ORDER BY LastName, FirstName;  
  
OPEN contact_cursor;  
    
FETCH LAST FROM contact_cursor;  
  
FETCH PRIOR FROM contact_cursor;  
  
FETCH ABSOLUTE 2 FROM contact_cursor;  
  
FETCH RELATIVE 3 FROM contact_cursor;  
  
FETCH RELATIVE -2 FROM contact_cursor;  
  
CLOSE contact_cursor;  
DEALLOCATE contact_cursor;  
GO

--OPEN

DECLARE Employee_Cursor CURSOR FOR  
SELECT LastName, FirstName  
FROM Employees  
WHERE LastName like 'B%';  
  
OPEN Employee_Cursor;  
  
FETCH NEXT FROM Employee_Cursor;  
WHILE @@FETCH_STATUS = 0  
BEGIN  
    FETCH NEXT FROM Employee_Cursor  
END;  
  
CLOSE Employee_Cursor;  
DEALLOCATE Employee_Cursor;

