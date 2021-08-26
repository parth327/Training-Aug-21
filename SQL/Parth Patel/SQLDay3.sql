--Assignment

 --Query 1. 
 
 SELECT FirstName "Name" ,LEN (FirstName) "Fname" FROM Employees WHERE FirstName LIKE 'J%' OR FirstName LIKE 'M%' OR FirstName LIKE 'A%' ORDER BY FirstName ;

 --Query 2.

 SELECT FirstName,CONCAT(FORMAT(Salary,'C'),REPLICATE('0',10-LEN(Salary))) AS SALARY FROM Employees;

 --Query 3. 
 
 SELECT EmployeeID AS code,FirstName AS firstname,LastName AS lastname,HireDate AS hiredate FROM Employees WHERE DATEPART(dd,HireDate) = 07 OR DATEPART(mm,HireDate) = 07;

 --Query 4.
 
 SELECT LEN(FirstName) FROM Employees WHERE CHARINDEX('c',LastName,2) > 2;

 --Query 5. 
 
 SELECT RIGHT(PhoneNumber, 4) FROM Employees;

 --Query 6. 
 
 SELECT REPLACE(PhoneNumber,'124','999') AS PhoneNumber FROM Employees;

 --Query 7.
  
 SELECT DATEPART(YYYY,GETDATE())-DATEPART(YYYY,HireDate) AS AGE FROM Employees;

 --Query 8. 
 
 SELECT HireDate FROM Employees WHERE DATENAME(WEEKDAY,HireDate) = 'Monday';

 --Query 9. 
 
 SELECT FirstName,HireDate FROM Employees WHERE CAST(HireDate AS varchar) BETWEEN '1987-06-01' AND '1987-07-30';

 --Query 10,11. 
 
 SELECT RIGHT(GETDATE(),7)+' '+DATENAME(MONTH,GETDATE())+' '+DATENAME(DAY,GETDATE())+', '+DATENAME(YYYY,GETDATE()) AS currentdate;

 --Query 12. 
 
 SELECT FirstName AS firstname,LastName as lastname FROM Employees WHERE MONTH(HireDate) =  6;

 --Query 13. 
 
 SELECT FirstName AS firstname,HireDate as hiredate,DATEPART(YY,GETDATE())-DATEPART(YY,HireDate) AS Experience FROM Employees;

 --Query 14. 
 
 SELECT FirstName AS firstname FROM Employees WHERE DATENAME(YYYY,HireDate)=1987;


	


