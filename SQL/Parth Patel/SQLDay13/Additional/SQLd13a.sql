--SQL Day 13 ADDITIONAL

--UDF

--Create Multi Statement Table-Valued Function(MSTVF)

CREATE FUNCTION uf_tb (@EmpID INT)  
RETURNS @tbFindReports TABLE   
(EmployeeID int primary key NOT NULL,FirstName nvarchar(255) NOT NULL,LastName nvarchar(255) NOT NULL,
JobTitle nvarchar(50) NOT NULL,RecursionLevel int NOT NULL)  
AS  
BEGIN  
WITH EMP_cte(EmployeeID,FirstName, LastName, JobId, RecursionLevel)
AS (SELECT e.EmployeeID, e.FirstName, e.LastName, e.JobId, 0 
FROM Employees e   
INNER JOIN Departments d   
ON e.EmployeeID = d.DepartmentID WHERE e.EmployeeID = @EmpID  
UNION ALL  
SELECT e.EmployeeID,e.FirstName, e.LastName, e.JobId, RecursionLevel + 1 FROM Employees e   
INNER JOIN EMP_cte ON e.EmployeeID = EMP_cte.EmployeeID  
INNER JOIN Departments d ON e.EmployeeID = d.DepartmentID)  
INSERT @tbFindReports  
SELECT EmployeeID, FirstName, LastName, JobId  
FROM EMP_cte 
RETURN 
END;  

SELECT EmployeeID, FirstName, LastName, JobTitle  
FROM uf_tb(101);

	
--Create Partition Function

CREATE PARTITION FUNCTION myRangePF1 (int)  
AS RANGE LEFT FOR VALUES (1, 100, 1000);  

--DROP Partition Function

DROP PARTITION FUNCTION  myRangePF1;

