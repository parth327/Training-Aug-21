--SQL Day 1 

--PRACTICE EXERCISE :-

--Query 1. Write a SQL statement to create a table named countries including columns CountryId, CountryName and RegionId and make sure that no countries except Italy, India and China will be entered in the table. and combination of columns CountryId and RegionId will be unique.

 CREATE TABLE Countries(CountryId INT NOT NULL UNIQUE,CountryName VARCHAR(10) CHECK(CountryName IN('Italy','India','China')),RegionId INT NOT NULL);

--Query 2. Write a SQL statement to create a table named JobHistory including columns EmployeeId, StartDate, End_Eate, Job_Id and Department_Id and make sure that the value against column EndDate will be entered at the time of insertion to the format like ‘–/–/—-‘.

 CREATE TABLE JobHistory(EmployeeId INT NOT NULL PRIMARY KEY,StartDate DATE NOT NULL,EndDate DATE NOT NULL,CHECK (EndDate LIKE '--/--/----'),JobId INT NOT NULL,DepartmentId INT NOT NULL);

--Query 3. Write a SQL statement to create a table named jobs including columns JobId, JobTitle, MinSalary and MaxSalary, and make sure that, the default value for JobTitle is blank and MinSalary is 8000 and MaxSalary is NULL will be entered automatically at the time of insertion if no value assigned for the specified columns.

 CREATE TABLE Jobs(JobId INT NOT NULL PRIMARY KEY,JobTitle VARCHAR(10),MinSalary VARCHAR(20) DEFAULT '8000',MaxSalary VARCHAR(20) DEFAULT 'NULL');

--Query 4. Write a SQL statement to create a table employees including columns Employee_Id, FirstName, LastName, Email, PhoneNumber, Hire_Date, Job_Id, Salary, Commission, Manager_Id and Department_Id and make sure that, the Employee_Id column does not contain any duplicate value at the time of insertion, and the foreign key column DepartmentId, reference by the column DepartmentId of Departments table, can contain only those values which are exists in the Department table and another foreign key column JobId, referenced by the column JobId of jobs table, can contain only those values which are exists in the jobs table.

 CREATE TABLE Employees(EmployeeId INT NOT NULL PRIMARY KEY,FirstName VARCHAR(20),LastName VARCHAR(20),Email VARCHAR(25),PhoneNumber VARCHAR(10),HireDate DATE ,JobId INT NOT NULL,Salary VARCHAR(20),Commission VARCHAR(10),ManagerID INT NOT NULL,DepartmentId INT NOT NULL,FOREIGN KEY (DepartmentId) REFERENCES Departments(DepartmentId),FOREIGN KEY (JobId) REFERENCES Jobs(JobId));

--ALTER :-

--Query 1. Write a SQL statement to add a foreign key constraint named fk_job_id on JobId column of JobHistory table referencing to the primary key JobId of jobs table.

ALTER TABLE JobHistory ADD CONSTRAINT fk_JobId FOREIGN KEY (JobId) REFERENCES JobHistory(EmployeeId);

--Query 2. Write a SQL statement to drop the existing foreign key fk_job_id from JobHistory table on JobId column which is referencing to the JobId of jobs table.

ALTER TABLE JobHistory DROP fk_JobId ;

--Query 3. Write a SQL statement to add a new column named location to the JobHistory table.

ALTER TABLE JobHistory ADD Location varchar(50);

--ASSIGNMENT :-

CREATE TABLE SalesPerson(EmployeeId INT NOT NULL PRIMARY KEY,EmployeeName VARCHAR(20),Commission VARCHAR(10));

CREATE TABLE Cars(CarId INT NOT NULL PRIMARY KEY,CarName VARCHAR(20),ModelId INT NOT NULL);

CREATE TABLE Model(ModelId INT FOREIGN KEY REFERENCES Cars(CarId) ,ModelName VARCHAR(20),Price VARCHAR(20));

CREATE TABLE Sales(BillNo INT NOT NULL PRIMARY KEY,ModelId INT FOREIGN KEY REFERENCES Cars(CarId),EmployeeId INT REFERENCES SalesPerson(EmployeeId));  



