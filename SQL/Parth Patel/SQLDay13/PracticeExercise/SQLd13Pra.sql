--SQL Day 13 PRACTICE EXERCISE

--UDF

--Limitations and Restrictions of User Defined Functions

--Can't be used to perform actions that modify the database state.
--Can't contain an OUTPUT INTO clause that has a table as its target.
--Can't return multiple result sets.Use a stored procedurea and if you need to return multiple result sets.
--Error handling is restricted. A UDF does not support TRY...CATCH, @ERROR or RAISERROR.
--Can't call a stored procedure, but can call an extended stored procedure.
--Can't make use of dynamic SQL or temp tables. Table variables are allowed.
--SET statements are not allowed in a user-defined function.
--The FOR XML clause is not allowed.
--UDF can be nested; that is, one udf can call another. 
--The nesting level is incremented when the called function starts execution, 
--and decremented when the called function finishes execution. 
--UDF can be nested up to 32 levels. 

--Permissions

--Scaler Functions

CREATE FUNCTION dbo.uf_Emp(@EmployeeID int)  
RETURNS int   
AS     
BEGIN  
    DECLARE @ret int;  
    SELECT @ret = SUM(e.Salary)   
    FROM Employees e   
    WHERE e.EmployeeID = @EmployeeID   
        AND e.DepartmentID = '6';  
     IF (@ret IS NULL)   
        SET @ret = 0;  
    RETURN @ret;  
END; 
    
SELECT EmployeeID,FirstName, dbo.uf_Emp(EmployeeID)AS EmpID  
FROM Employees  
WHERE EmployeeID BETWEEN 75 and 80; 

--Table-Valued Functions

CREATE FUNCTION uf_Sales(@EmployeeID int)  
RETURNS TABLE  
AS  
RETURN   
(  
    SELECT e.EmployeeID, d.DepartmentName, SUM(e.Salary) AS 'Total'  
    FROM Employees e   
    JOIN Departments d ON e.DepartmentID = d.DepartmentID  
    WHERE e.EmployeeID = @EmployeeID  
    GROUP BY e.EmployeeID, d.DepartmentName  
);  

SELECT * FROM uf_Sales(102);

--DROP Function

DROP FUNCTION dbo.uf_Emp;

