-- 80 Queries Assignment for Additional Practice

CREATE TABLE Employee(EmployeeID INT NOT NULL PRIMARY KEY,FirstName VARCHAR(20),LastName VARCHAR(20),Salary INT,JoiningDate DATE,Department	VARCHAR(20))

drop table Employee
INSERT INTO Employee(EmployeeID,FirstName,LastName,Salary,JoiningDate,Department)
VALUES(1,'John','Abraham',1000000,'2013-01-01 12:00:00','Banking'),
(2,'Michal','Clarke',800000,'2013-01-01 12:00:00','Insuranse'),
(3,'Roy','Thomas',700000,'2013-02-01 12:00:00','Banking'),
(4,'Tom','Jose',600000,'2013-02-01 12:00:00','Insurance'),
(5,'Jerry','Pinto',650000,'2013-02-01 12:00:00','Insurance'),
(6,'Philip','Mathew',750000,'2013-01-01 12:00:00','Services'),
(7,'TestName1','123',650000,'2013-01-01 12:00:00','Services'),
(8,'TestName2','Lname%',600000,'2013-02-01 12:00:00','Insurance');

CREATE TABLE Incentives(EmployeeRefId INT, FOREIGN KEY (EmployeeRefId) REFERENCES Employee(EmployeeID) ,IncentiveDate DATE,IncentiveAmount INT)
drop table Incentives
INSERT INTO Incentives 
Values(1,'2013-02-01',5000),(2,'2013-02-01',3000),(3,'2013-02-01',4000),(1,'2013-01-01',4500),(2,'2013-01-01',3500);


--Quries related to Tables :


--1. Write create table syntax for employee table

CREATE TABLE Employee(EmployeeID INT NOT NULL PRIMARY KEY,FirstName VARCHAR(20),LastName VARCHAR(20),Salary INT,JoiningDate DATE,Department	VARCHAR(20))

--2.Get all employee details from the employee table

SELECT * FROM Employee

--3.Get First_Name, Last_Name from employee table

SELECT FirstName,LastName FROM Employee

--4. Get First_Name from employee table using alias name “Employee Name”

SELECT FirstName AS EmployeeName FROM Employee

--5. Get First_Name from employee table in upper case

SELECT UPPER(FirstName) FROM Employee

--6.Get First_Name from employee table in lower case

SELECT LOWER(FirstName) FROM Employee

--7. Get unique DEPARTMENT from employee table

SELECT DISTINCT Department FROM Employee

--8.Select first 3 characters of FIRST_NAME from EMPLOYEE.

SELECT SUBSTRING(FirstName,1,3) FROM Employee;

--9. Get position of 'o' in name 'John' from employee table

SELECT CHARINDEX('o',FirstName,0) FROM Employee WHERE FirstName='John'

--10.Get FIRST_NAME from employee table after removing white spaces from right side

SELECT RTRIM(FirstName) FROM Employee;

--11.Get FIRST_NAME from employee table after removing white spaces from left side

SELECT LTRIM(FirstName) FROM Employee

--12. Get length of FIRST_NAME from employee table

SELECT LEN(FirstName) FROM Employee

--13. Get First_Name from employee table after replacing 'o' with '$'

SELECT REPLACE(FirstName,'o','$') FROM Employee

--14.Get First_Name and Last_Name as single column from employee table separated by a '_'

SELECT CONCAT(FirstName,LastName) AS Name FROM Employee

--15.Get FIRST_NAME ,Joining year,Joining Month and Joining Date from employee table

SELECT FirstName,YEAR(JoiningDate) AS JoiningYear,MONTH(JoiningDate) AS JoiningMonth,DAY(JoiningDate) AS JoiningDate FROM Employee

--16. Get all employee details from the employee table order by First_Name Ascending

SELECT * FROM Employee ORDER BY FirstName 

--17.Get all employee details from the employee table order by First_Name descending

SELECT * FROM Employee ORDER BY FirstName DESC

--18.Get all employee details from the employee table order by First_Name Ascending and Salary descending

SELECT * FROM Employee ORDER BY FirstName,Salary DESC

--19.Get employee details from employee table whose employee name is “John”

SELECT * FROM Employee WHERE FirstName='John'

--20. Get employee details from employee table whose employee name are “John” and “Roy”

SELECT * FROM Employee WHERE FirstName='John' OR FirstName='Roy'

--21.Get employee details from employee table whose employee name are not “John” and “Roy”

SELECT * FROM Employee WHERE NOT FirstName='John' AND NOT FirstName='Roy'

--22.Get employee details from employee table whose first name starts with 'J'

SELECT * FROM Employee WHERE FirstName LIKE 'J%'

--23.Get employee details from employee table whose first name contains 'o'

SELECT * FROM Employee WHERE FirstName LIKE '%o%'

--24.Get employee details from employee table whose first name ends with 'n'

SELECT * FROM Employee WHERE FirstName LIKE '%n'

--25.Get employee details from employee table whose first name ends with 'n' and name contains 4 letters

SELECT * FROM Employee WHERE FirstName LIKE '%n'AND LEN(FirstName) = 4

--26. Get employee details from employee table whose first name starts with 'J' and name contains 4 letters

SELECT * FROM Employee WHERE FirstName LIKE 'J%' AND LEN(FirstName) = 4

--27. Get employee details from employee table whose Salary greater than 600000

SELECT * FROM Employee WHERE Salary > 600000

--28. Get employee details from employee table whose Salary less than 800000

SELECT * FROM Employee WHERE Salary < 800000

--29.Get employee details from employee table whose Salary between 500000 and 800000

SELECT * FROM Employee WHERE Salary BETWEEN 500000 AND 800000

--30.Get employee details from employee table whose name is 'John' and 'Michael'

SELECT * FROM Employee WHERE FirstName IN('John','Michal')

--31.Get employee details from employee table whose joining year is “2013”

SELECT * FROM Employee WHERE YEAR(JoiningDate) = '2013'

--32.Get employee details from employee table whose joining month is “January”

SELECT * FROM Employee WHERE MONTH(JoiningDate) = '01'

--33.Get employee details from employee table who joined before January 31st 2013

SELECT * FROM Employee WHERE JoiningDate < '2013-01-31'

--34. Get employee details from employee table who joined after January 31st

SELECT * FROM Employee WHERE MONTH(JoiningDate) > '01' OR DAY(JoiningDate) > '31'

--35. Get Joining Date and Time from employee table

SELECT DAY(JoiningDate),HOUR(JOININGDATE) FROM Employee  

--36.Get Joining Date,Time including milliseconds from employee table

SELECT JoiningDate

--37. Get difference between JOINING_DATE and INCENTIVE_DATE from employee and incentives table

SELECT DATEDIFF(MM,e.JoiningDate,i.IncentiveDate) AS 'DIFF'
FROM Employee e INNER JOIN Incentives i ON e.EmployeeID=i.EmployeeRefId

--38.Get database date

SELECT GETDATE()

--39. Get names of employees from employee table who has '%' in Last_Name. 

SELECT CONCAT(FirstName,LastName) AS Name FROM Employee WHERE LastName LIKE '%'

--Tip : Escape character for special characters in a query.

--40. Get Last Name from employee table after replacing special character with white space

SELECT LastName FROM Employee 

--41. Get department,total salary with respect to a department from employee table.

SELECT Department,SUM(Salary) AS TotalSalary FROM Employee GROUP BY Department

--42.Get department,total salary with respect to a department from employee table order by total salary descending

SELECT Department,SUM(Salary) AS TotalSalary FROM Employee GROUP BY Department ORDER BY TotalSalary DESC

--43. Get department,no of employees in a department,total salary with respect to a department from employee table order by total salary descending

SELECT Department,COUNT(EmployeeID) AS NoOfEmployees,SUM(Salary) AS TotalSalary FROM Employee GROUP BY Department ORDER BY TotalSalary DESC

--44.Get department wise average salary from employee table order by salary ascending

SELECT AVG(Salary) AS AvgSalary FROM Employee GROUP BY Department ORDER BY AvgSalary 

--45.Get department wise maximum salary from employee table order by salary ascending

SELECT MAX(Salary) AS MaxSalary FROM Employee GROUP BY Department ORDER BY MaxSalary 

--46. Get department wise minimum salary from employee table order by salary ascending

SELECT MIN(Salary) AS MinSalary FROM Employee GROUP BY Department ORDER BY MinSalary 
