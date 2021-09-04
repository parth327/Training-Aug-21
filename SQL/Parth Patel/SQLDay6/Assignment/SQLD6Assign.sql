--SQL Day 6 Assignment   
   
--Query 1. Select employee details from employee table if data exists in incentive table ?

SELECT * FROM Employees WHERE EXISTS (SELECT * FROM Incentive)    

--Query 2. Find Salary of the employee whose salary is more than Roy Salary
   
SELECT Salary FROM Employees WHERE Salary > (SELECT Salary FROM Employees WHERE FirstName='Roy')

--Query 3. Find the employee ID, job title, number of days between ending date and starting date for all jobs in department 90 from job history.
   
SELECT EmployeeID, JobId AS JobTitle,DATEDIFF(DAY,StartDate,EndDate) FROM JobHistory 
WHERE DepartmentId=90
