--Day 4 Additional 

--NTILE(N) SQL Rank Function

SELECT *,NTILE(2) OVER(ORDER BY Salary DESC) Rank FROM Employees ORDER BY rank;

SELECT *,NTILE(2) OVER(ORDER BY Salary DESC) Rank FROM Employees ORDER BY rank;

--Use PARTITION BY with NTILE

SELECT *,NTILE(2) OVER(PARTITION  BY JobId ORDER BY Salary DESC) Rank FROM Employees ORDER BY JobId, rank;

--Practical Usage of SQL Rank Functions:

WITH ERanks AS(SELECT *, ROW_NUMBER() OVER( ORDER BY Salary) AS Ranks FROM Employees)
 
SELECT FirstName,Salary FROM ERanks WHERE Ranks >= 1 and Ranks <=3 ORDER BY Ranks;

--Use OFFSET FETCH Command

WITH ERanks AS(SELECT *, ROW_NUMBER() OVER( ORDER BY Salary) AS Ranks FROM Employees)
 
SELECT FirstName , Salary FROM ERanks ORDER BY Ranks OFFSET 1 ROWS FETCH NEXT 3 ROWS ONLY;



