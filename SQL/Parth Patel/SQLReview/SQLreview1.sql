--Review Query 1 :++

--Create a function pf=12% of salary,pt = if < 8000,75,if 8000 to 20000,150,>20000,200
--Show Empid,name,salary,pf,pt,netSal,GrossSalary by view
--Netsal=(Basic+HRA+ta+da)-pf-pt

CREATE FUNCTION uf_pf(@Salary INT)
RETURNS INT 
AS 
BEGIN
	DECLARE @pf int
	SELECT @pf = 0.12*Salary
	FROM Employees
	WHERE Salary = @Salary
		IF(@pf IS NULL)
	SET @pf=0
	RETURN @pf
	END



CREATE FUNCTION uf_pt(@Salary INT)
RETURNS INT 
AS 
BEGIN
	DECLARE @pt int
	SELECT @pt =Salary  
	FROM Employees
	WHERE Salary = @Salary
		IF @Salary <= 8000
		BEGIN
			SET @pt=75
		END
		IF @Salary > 8000 AND  @Salary <= 20000  
		BEGIN
			SET @pt=150
		END
			IF @Salary > 20000  
		BEGIN
			SET @pt=200
		END
	RETURN @pt
	END

	CREATE VIEW Emp2	
	AS
    SELECT EmployeeID,FirstName,Salary,dbo.uf_pf(Salary) AS 'PF',dbo.uf_pt(Salary) AS 'PT',
	(Salary+HRA+DA+TA)-dbo.uf_pf(Salary)-dbo.uf_pt(Salary) AS 'Net Salary',(Salary+HRA+DA+TA) AS 'Gross Salary' 
	FROM Employees

	select * from Emp2

--Show Employees who haven't allocated any project 

CREATE TABLE Employees1(ID INT PRIMARY KEY,NAME VARCHAR(5),GENDER VARCHAR(5))
INSERT INTO Employees1
Values(1,'A','M'),(2,'B','M'),(3,'C','F'),(4,'D','F');

CREATE TABLE Projects1(ProjectID INT PRIMARY KEY,ProjectName VARCHAR(15))
INSERT INTO Projects1
Values(1,'HR'),(2,'Index'),(3,'pay'),(4,'BusTkt');

CREATE TABLE Allocation1(ProjectID INT FOREIGN KEY REFERENCES Projects1(ProjectID),ID INT FOREIGN KEY REFERENCES Employees1(ID),Name VARCHAR(5))
INSERT INTO Allocation1
Values(1,1,'A'),(1,2,'B'),(2,1,'C'),(3,1,'D');


SELECT e.id,e.Name FROM Employees1 e LEFT OUTER JOIN Allocation1 a ON a.Id = e.Id WHERE a.Name IS NULL