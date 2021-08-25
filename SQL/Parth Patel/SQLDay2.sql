--ASSIGNMENT :-


--Update Queries:

 UPDATE Employees SET Email='not available';

 UPDATE Employees SET Email='not available',CommissionPct =0.10;
 
 UPDATE Employees SET Email='not available',CommissionPct= 0.10 WHERE DepartmentId=110;
 
 UPDATE Employees SET Email='not available' WHERE DepartmentId=80 AND CommissionPct<0.20;
 
 UPDATE Employees SET Email='not available' WHERE DepartmentID=(SELECT DepartmentID FROM Departments WHERE DepartmentName='Accounting');

 UPDATE Employees SET Salary=8000 WHERE ID=105 AND Salary<5000;

 UPDATE Employees SET JobId= 'SH_CLERK' WHERE EmployeeId=118 AND DepartmentId=30 AND NOT JobId LIKE 'SH%';

 UPDATE Employees SET Salary= CASE DepartmentId WHEN 40 THEN Salary+(Salary*.25) WHEN 90 THEN Salary+(Salary*.15) WHEN 110 THEN Salary+(Salary*.10) ELSE Salary END WHERE DepartmentId IN (40,50,50,60,70,80,90,110);
 
 UPDATE Jobs,Employees SET Jobs.MinSalary=Jobs.MinSalary+2000,Jobs.MaxSalary=Jobs.MaxSalary+2000,Employees.Salary=Employees.Salary+(Employees.Salary*.20),Employees.Commission_Pct=Employees.CommissionPct+.10 WHERE Jobs.JobId='PU_CLERK'AND Employees.JobId='PU_CLERK';
 
 






--Basic Select Queries :

 SELECT * FROM Employees;

 SELECT FirstName,LastName FROM Employees;

 SELECT FirstName FROM Employees AS EmployeeName ;

 SELECT FirstName FROM Employees AS EmployeeName WHERE FirstName='Steven';

 SELECT FirstName AS EmployeeName FROM Employees WHERE FirstName='Neena' OR FirstName='Lex';

 SELECT FirstName FROM Employees AS EmployeeName WHERE NOT FirstName='Neena';

 SELECT * FROM Employees WHERE Salary BETWEEN 5000 AND 8000;

 SELECT FirstName,LastName,Salary,Salary*.12 AS PF FROM Employees;

 SELECT * FROM Employees WHERE FirstName LIKE 'N%';

 SELECT DISTINCT DepartmentID FROM Employees;

 SELECT * FROM Employees ORDER BY FirstName DESC;

 SELECT EmployeeId,FirstName,LastName,Salary FROM Employees ORDER BY Salary;

 SELECT TOP 2 Salary FROM Employees;
