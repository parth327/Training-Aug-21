--SQL Day 11 Stored Procedure

--Additional

--Modify a Stored Procedure

CREATE PROCEDURE Empt1  
WITH EXECUTE AS CALLER  
AS  
    SET NOCOUNT ON;  
    SELECT e.FirstName AS Name, d.DepartmentName AS 'DepName',   
      e.Salary AS 'Sal',   
      d.ManagerID AS 'Manager'   
    FROM Employees e   
    INNER JOIN Departments d  
      ON e.departmentID = d.DepartmentID
    ORDER BY d.DepartmentName ASC;  
GO  


ALTER PROCEDURE Empt1  
    @Empt varchar(25)   
AS  
    SET NOCOUNT ON;  
    SELECT LEFT(e.FirstName, 25) AS Name, LEFT(d.DepartmentName, 25) AS 'DeptName',   
    'Rating' = CASE e.Salary   
        WHEN 1 THEN 'Superior'  
        WHEN 2 THEN 'Excellent'  
        WHEN 3 THEN 'Above average'  
        WHEN 4 THEN 'Average'  
        WHEN 5 THEN 'Below average'  
        ELSE 'No rating'  
        END  
    , Availability = CASE d.ManagerID  
        WHEN 1 THEN 'Yes'  
        ELSE 'No'  
        END  
    FROM Employees AS e   
    INNER JOIN Departments AS d  
      ON e.DepartmentID = d.DepartmentID   
    ORDER BY d.DepartmentName ASC;  
GO

EXEC Empt1 N'Neena';  
GO 

--Delete a Stored Procedure

SELECT name AS procedure_name,SCHEMA_NAME(schema_id) AS schema_name,type_desc,create_date,modify_date  
FROM sys.procedures; 

DROP PROCEDURE Empt1;  
GO  

--Return Data from a Stored Procedure

--Examples of Returning Data Using a Result Set

CREATE PROCEDURE Empe1 
AS    
 
   SET NOCOUNT ON;  
   SELECT LastName, Salary  
   FROM Employees AS e  
   JOIN Departments AS d ON e.EmployeeID = d.DepartmentID  
   
RETURN  
GO

--Recomiple a stored procedure

CREATE PROCEDURE dbo.uspProductByVendor @Name varchar(30) = '%'  
WITH RECOMPILE  
AS  
    SET NOCOUNT ON;  
    SELECT e.FirstName AS 'Name', d.DepartmentName AS 'DeptName'  
    FROM Employees AS e   
    JOIN Departments AS d   
      ON e.DepartmentID = d.DepartmentID   
    WHERE d.DepartmentName LIKE @Name;

--To recompile a stored procedure by using the WITH RECOMPILE option
  
EXECUTE dbo.uspProductByVendor RECOMPILE;  
GO

--To recompile a stored procedure by using sp_recompile
  
EXEC sp_recompile N'dbo.uspProductByVendor';   
GO

--Rename a Stored Procedure

--Create the stored procedure.  

CREATE PROCEDURE Empdb  
AS  
    SET NOCOUNT ON;  
    SELECT LastName, FirstName, DepartmentID  
    FROM Employees;  
GO  
  
--Rename the stored procedure.  
EXEC sp_rename 'Employees', 'uspEveryEmployeeTest';

--View the Definition of a Stored Procedure

EXEC sp_helptext N'AdventureWorks2012.dbo.uspLogError';

SELECT OBJECT_DEFINITION (OBJECT_ID(N'AdventureWorks2012.dbo.uspLogError'));

SELECT [definition]
FROM sys.sql_modules  
WHERE object_id = (OBJECT_ID(N'dbo.uspLogError'));

--Parameters

CREATE PROCEDURE SampleP @EmployeeIDParm INT,@MaxTotal INT OUTPUT
AS
DECLARE @ErrorSave INT
SET @ErrorSave = 0
SELECT FirstName, LastName, JobId
FROM Employees
WHERE EmployeeID = @EmployeeIDParm

IF (@@ERROR <> 0)
   SET @ErrorSave = @@ERROR

SELECT @MaxTotal = MAX(Salary)
FROM Employees;

IF (@@ERROR <> 0)
   SET @ErrorSave = @@ERROR

RETURN @ErrorSave
GO