--Day 4

--Practice Exercise :-

--Ranking Functions
        
--Row_number()
 
SELECT FirstName,Salary,JobId,ROW_NUMBER() OVER(ORDER BY Salary) SALARY FROM Employees;

--Row Number in Descending

SELECT FirstName,Salary,JobId,ROW_NUMBER() OVER(ORDER BY Salary DESC) SALARY FROM Employees;

--Rank()

--Use Rank with Partition By

SELECT FirstName,Salary,JobId,RANK() OVER(PARTITION BY FirstName ORDER BY Salary DESC) Rank FROM Employees ORDER BY FirstName,Rank;

--Use Rank

SELECT FirstName,Salary,JobId,RANK() OVER(PARTITION BY FirstName ORDER BY Salary DESC) Rank FROM Employees ORDER BY Rank;
 
--Dense_rank()

--Use Dense_rank 

SELECT FirstName,JobId,Salary,DENSE_RANK() OVER(ORDER BY Salary DESC) Rank FROM Employees ORDER BY Rank;
  
--Use Dense_rank with Partition By

SELECT FirstName,JobId,Salary,DENSE_RANK() OVER(PARTITION BY HireDate ORDER BY Salary DESC) Rank FROM Employees ORDER BY Rank;

--Aggregate Function


        
--SUM

SELECT DepartmentID,Hiredate,SUM(CommissionPct) AS TotalSalary FROM Employees GROUP BY DepartmentID,HireDate;
	
--COUNT

SELECT DepartmentID,Hiredate,COUNT(CommissionPct) AS TotalSalary FROM Employees GROUP BY DepartmentID,HireDate;
    
--AVG
  
SELECT DepartmentID,Hiredate,AVG(CommissionPct) AS TotalSalary FROM Employees GROUP BY DepartmentID,HireDate;

--MAX
  
SELECT DepartmentID,Hiredate,MAX(CommissionPct) AS TotalSalary FROM Employees GROUP BY DepartmentID,HireDate;

--MIN

SELECT DepartmentID,Hiredate,MIN(CommissionPct) AS TotalSalary FROM Employees GROUP BY DepartmentID,HireDate;

--Group by

--Group By CUBE ()

SELECT DepartmentID,Hiredate,SUM(CommissionPct) AS TotalSalary FROM Employees GROUP BY CUBE(DepartmentID,HireDate);

--Group BY Grouping Sets()

SELECT GROUPING(Salary) SALARY,SUM (CommissionPct) COMMISSION FROM Employees GROUP BY GROUPING SETS (Salary,CommissionPct) ORDER BY Salary ;

--Having

SELECT COUNT(EmployeeID),Salary FROM Employees GROUP BY Salary HAVING COUNT(EmployeeID) > 5;

--ROLLUP

SELECT DepartmentID,Hiredate,SUM(CommissionPct) AS TotalSalary FROM Employees GROUP BY ROLLUP (DepartmentID,HireDate);
