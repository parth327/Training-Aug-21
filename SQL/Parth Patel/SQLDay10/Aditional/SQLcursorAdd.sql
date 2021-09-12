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

DECLARE abc CURSOR 
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
SET @MyCursor = CURSOR FOR  
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

