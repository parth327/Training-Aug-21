--Day2 Additional

--Updating User-defined Types

--Using a system data type

UPDATE Cities  SET Location = CONVERT(Point, '12.3:46.2') WHERE Name = 'Anchorage';

--Invoking a method

UPDATE Cities SET Location.SetXY(23.5, 23.5) WHERE Name = 'Anchorage';

--Modifying the value of a property or data member

UPDATE Cities SET Location.X = 23.5 WHERE Name = 'Anchorage';

--Using the UPDATE statement with a WHERE clause

UPDATE DimEmployee SET FirstName = 'Gail' WHERE EmployeeKey = 500;

--Using the UPDATE statement with label

UPDATE DimProduct SET ProductSubcategoryKey = 2 WHERE ProductKey = 313 OPTION (LABEL = N'label1');

--Non-Recursive CTEs

with ROWCTE(ROWNO) as (SELECT ROW_NUMBER() OVER(ORDER BY name ASC) AS ROWNO FROM sys.databases WHERE database_id <= 10)  
SELECT * FROM ROWCTE 

--Recursive CTEs

Declare @RowNo int =1;with ROWCTE as(SELECT @RowNo as ROWNO UNION ALL SELECT  ROWNO+1 FROM  ROWCTE WHERE RowNo < 10)  
SELECT * FROM ROWCTE 


