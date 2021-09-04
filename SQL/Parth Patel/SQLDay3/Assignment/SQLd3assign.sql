--Day 3 Assignment

--Query 1. Write a query that displays the FirstName and the length of the FirstName for all employees whose name starts with the letters �A�, �J� or �M�. Give each column an appropriate label. Sort the results by the employees� FirstName
 
SELECT FirstName "Name" ,LEN (FirstName) "Fname" FROM Employees WHERE FirstName LIKE 'J%' OR FirstName LIKE 'M%' OR FirstName LIKE 'A%' ORDER BY FirstName ;

--Query 2. Write a query to display the FirstName and Salary for all employees. Format the salary to be 10 characters long, left-padded with the $ symbol. Label the column SALARY.

SELECT FirstName,CONCAT(FORMAT(Salary,'C'),REPLICATE('0',10-LEN(Salary))) AS SALARY FROM Employees;

--Query 3. Write a query to display the employees with their code, first name, last name and hire date who hired either on seventh day of any month or seventh month in any year.

SELECT EmployeeID AS code,FirstName AS firstname,LastName AS lastname,HireDate AS hiredate FROM Employees WHERE DATEPART(dd,HireDate) = 07 OR DATEPART(mm,HireDate) = 07;

--Query 4. Write a query to display the length of first name for employees where last name contains character �c� after 2nd position.

SELECT LEN(FirstName) FROM Employees WHERE CHARINDEX('c',LastName,2) > 2;

--Query 5. Write a query to extract the last 4 character of PhoneNumber.

SELECT RIGHT(PhoneNumber, 4) FROM Employees;

--Query 6. Write a query to update the portion of the PhoneNumber in the employees table, within the phone number the substring �124� will be replaced by �999�.

SELECT REPLACE(PhoneNumber,'124','999') AS PhoneNumber FROM Employees

--Query 7. Write a query to calculate the age in year.

SELECT DATEPART(YYYY,GETDATE())-DATEPART(YYYY,HireDate) AS AGE FROM Employees;

--Query 8. Write a query to get the distinct Mondays from HireDate in employees tables.

SELECT HireDate FROM Employees WHERE DATENAME(WEEKDAY,HireDate) = 'Monday';

--Query 9. Write a query to get the FirstName and HireDate from Employees table where HireDate between �1987-06-01� and �1987-07-30�

SELECT FirstName,HireDate FROM Employees WHERE CAST(HireDate AS varchar) BETWEEN '1987-06-01' AND '1987-07-30';

--Query 10,11. Write a query to display the current date in the following format.Sample output : 12:00 AM Sep 5, 2014
  
SELECT RIGHT(GETDATE(),7)+' '+DATENAME(MONTH,GETDATE())+' '+DATENAME(DAY,GETDATE())+', '+DATENAME(YYYY,GETDATE()) AS currentdate;

--Query 12. Write a query to get the FirstName, LastName who joined in the month of June.

SELECT FirstName AS firstname,LastName as lastname FROM Employees WHERE MONTH(HireDate) =  6;

--Query 13. Write a query to get first name, hire date and experience of the employees.

SELECT FirstName AS firstname,HireDate as hiredate,DATEPART(YY,GETDATE())-DATEPART(YY,HireDate) AS Experience FROM Employees;

--Query 14. Write a query to get first name of employees who joined in 1987.

SELECT FirstName AS firstname FROM Employees WHERE DATENAME(YYYY,HireDate)=1987;


	


	