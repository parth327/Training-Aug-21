
--ADDITIONAL ASSIGNMENT FOR MORE PRACTICE :

--1. Write a query to find the names (first_name, last_name) and salaries of the employees 
--who have higher salary than the employee whose last_name='Bull'.
 
 SELECT e.FirstName, e.LastName,e.Salary FROM Employees e 
WHERE e.Salary > (SELECT e.Salary FROM Employees e WHERE e.LastName = 'Bull');

--2. Find the names (first_name, last_name) of all employees who works in the IT department.   

SELECT e.FirstName,e.LastName FROM Employees e WHERE e.DepartmentId IN (SELECT d.DepartmentID From Departments d WHERE d.DepartmentName='IT');
 
--3. Find the names (first_name, last_name) of the employees who have a manager who works for a department based in United States.   
 
 SELECT FirstName, LastName FROM Employees WHERE ManagerID IN (SELECT EmployeeID FROM Employees WHERE DepartmentID 
IN (SELECT DepartmentID FROM Departments WHERE LocationID IN (SELECT LocationID FROM Locations where CountryID='US')));

--4. Find the names (first_name, last_name) of the employees who are managers.   
 
SELECT FirstName, LastName FROM Employees WHERE (EmployeeID IN (SELECT ManagerID FROM Employees));

--5.  Find  the  names  (first_name,  last_name),  salary  of  the  employees  whose  salary  is  greater than the average salary.   
 
SELECT FirstName,LastName, Salary FROM Employees WHERE Salary > (SELECT AVG(Salary) FROM Employees);

--6.  Find  the  names  (first_name,  last_name),  salary  of  the  employees  whose  salary  is equal  to  the minimum salary for their job grade.   

SELECT FirstName,LastName,Salary FROM Employees WHERE Salary = (SELECT MIN(Salary) FROM Employees)

--7.  Find  the  names  (first_name,  last_name),  salary  of  the  employees  who earn  more  than  the average salary and who works in any of the IT departments.   
 
 SELECT FirstName, LastName, Salary FROM Employees WHERE DepartmentID 
 IN (SELECT DepartmentID FROM Departments WHERE DepartmentName LIKE 'IT%') AND Salary > (SELECT AVG(Salary) FROM Employees);

--8. Find the names (first_name, last_name), salary of the employees who earn more than Mr. Bell.   
 
 SELECT FirstName,LastName,Salary FROM Employees WHERE Salary > (SELECT Salary FROM Employees WHERE LastName='Bell')

--9. Find the names (first_name, last_name), salary of the employees who earn the same salary as the minimum salary for all departments.   

SELECT FirstName,LastName,Salary FROM Employees WHERE Salary IN (SELECT MIN(Salary) FROM Employees)
 
--10.  Find  the  names  (first_name,  last_name),  salary  of  the  employees  whose  salary  greater than average salary of all department.   

SELECT FirstName,LastName,Salary FROM Employees WHERE Salary > (SELECT AVG(Salary) FROM Employees)
 
--11. Write a query to find the names (first_name, last_name) and salary of the employees
--who earn a salary that is higher than the salary of all the Shipping Clerk (JOB_ID = 'SH_CLERK'). 
--Sort the results on salary from the lowest to highest.   
 
 SELECT FirstName,LastName, JobId, Salary FROM Employees 
WHERE Salary > ALL(SELECT Salary FROM Employees WHERE JobId = 'SH_CLERK') ORDER BY Salary;

 --12.  Write  a  query  to  find  the  names  (first_name,  last_name)  of  the  employees  who  are  not supervisors.   
 
SELECT e.FirstName,e.LastName FROM Employees e 
WHERE NOT EXISTS (SELECT 'X' FROM Employees s WHERE e.ManagerID = s.EmployeeID);

--13. Write a query to display the employee ID, first name, last names, and department names of all employees.   

SELECT e.EmployeeID,e.FirstName,e.LastName,d.DepartmentName FROM Employees e JOIN Departments d ON e.EmployeeID=d.DepartmentID
 
--14. Write a query to display the employee ID, first name, last names, salary of all employees 
--whose salary is above average for their departments.   

SELECT EmployeeID, FirstName FROM Employees e 
WHERE Salary > (SELECT AVG(Salary) FROM Employees WHERE DepartmentID  = e.DepartmentID);

 --15. Write a query to fetch even numbered records from employees table.   

 SELECT * FROM Employees WHERE EmployeeID % 2 = 0;


