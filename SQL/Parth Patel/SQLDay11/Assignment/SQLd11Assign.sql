--SQL DAY 12 PROGRAM DISCRIPTION

--ASSIGNMENT

--STORED PROCEDURE

--STEP 1

CREATE TABLE Deposit(Actno VARCHAR(5) NOT NULL PRIMARY KEY,Cname VARCHAR(18) FOREIGN KEY REFERENCES Customer(Cname)
,Bname VARCHAR(18) FOREIGN KEY REFERENCES Branch(Bname),Amount INT,Adate DATE);

INSERT INTO Deposit(Actno,Cname,Bname,Amount,Adate)
VALUES(101,'SUNIL','AJNI',5000,'4-JAN-1996'),
(102,'MEHUL','KAROLBAGH',3500,'17-Nov-1995'),(104,'MADHURI','CHANDNI',1200,'17-Dec-1995'),
(105,'PRAMOD','M.G.ROAD',3000,'27-Mar-1996'),(106,'SANDIP','ANDHERI',2000,'31-Mar-1996'),
(107,'SHIVANI','VIRAR',1000,'5-Sep-1995'),(108,'KRANTI','NEHRU PLACE',5000,'2-Jul-1995'),
(109,'NAREN','POWAI',7000,'10-Aug-1995');

CREATE TABLE Branch(Bname VARCHAR(18) NOT NULL,City VARCHAR(18),PRIMARY KEY(Bname));

INSERT INTO Branch
VALUES('VRCE','NAGPUR'),('AJNI','NAGPUR'),
('KAROLBAGH','DELHI'),('CHANDNI','DELHI'),
('DHARAMPETH','NAGPUR'),('M.G.ROAD','BANGLORE'),
('ANDHERI','MUMBAI'),('VIRAR','MUMBAI'),
('NEHRU PLACE','DELHI'),('POWAI','MUMBAI');

CREATE TABLE Customer(Cname VARCHAR(18) NOT NULL,City VARCHAR(18),PRIMARY KEY(Cname));

INSERT INTO Customer
VALUES('ANIL','KOLKATA'),('SUNIL','DELHI'),
('MEHUL','BARODA'),('MANDAR','PATNA'),
('MADHURI','NAGPUR'),('PRAMOD','NAGPUR'),
('SANDIP','SURAT'),('SHIVANI','MUMBAI'),
('KRANTI','MUMBAI'),('NAREN','MUMBAI');

CREATE TABLE BORROW(Loanno VARCHAR(5) NOT NULL PRIMARY KEY,Cname VARCHAR(18) FOREIGN KEY REFERENCES Customer(Cname),
Bname VARCHAR(18) FOREIGN KEY REFERENCES Branch(Bname),Amount INT);

INSERT INTO BORROW(Loanno,Cname,Bname,Amount)
VALUES(201,'ANIL','VRCE',1000),(206,'MEHUL','AJNI',5000),
(311,'SUNIL','DHARAMPETH',3000),(321,'MADHURI','ANDHERI',2000),
(375,'PRAMOD','VIRAR',8000),(481,'KRANTI','NEHRU PLACE',3000);



-- STEP 2 :Create the queries listed below:

--Q1: Create a Store Procedure which will accept name of the customer as input parameter and product the following output,
--List Names of Customers who are Depositors and have Same Branch City as that of input parameter customer’s Name.


CREATE PROCEDURE dbo.uspGetCustInfo
@CustName VARCHAR(18)=NULL
AS
BEGIN
	IF @CustName IS NULL
	BEGIN
		PRINT'Provide the customer name'
		RETURN (1)
	END

	SET NOCOUNT ON;

	SELECT d.Cname FROM Deposit d
		INNER JOIN Customer c ON c.Cname = d.Cname
		INNER JOIN Branch b ON b.Bname = d.Bname
	WHERE b.City LIKE (SELECT City FROM Customer WHERE Cname = @CustName)
	
	SET NOCOUNT OFF;
END
GO

EXEC dbo.uspGetCustInfo 'KRANTI'

--Q2: Create a Store Procedure which will accept name of the customer as input parameter and produce the following output List in JSON format, All the Depositors Having Deposit in All the Branches where input parameter customer is Having an Account


CREATE PROCEDURE dbo.GetCustInfo
@Cname VARCHAR(18) = NULL,
@Cdata NVARCHAR(MAX) OUTPUT
AS
BEGIN
IF @Cname IS NULL
	BEGIN
		PRINT'Provide the customer name'
		RETURN (1)
	END

	SET NOCOUNT ON;

	SET @Cdata = (SELECT Cname 
		FROM Deposit d
		WHERE Bname IN (SELECT Bname FROM Deposit WHERE Cname = @Cname)
		FOR JSON AUTO)

	SET NOCOUNT OFF;
END
GO

DECLARE @Cdata NVARCHAR(MAX);

EXEC dbo.GetCustInfo 'MEHUL',@Cdata OUTPUT ;

--Q3: Create a Store Procedure that will accept city name and returns the number of customers in that city.

CREATE PROCEDURE dbo.CustSameCity
@City VARCHAR(18)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT COUNT(Cname)AS CustomerCount
	FROM Customer
	WHERE City=@City
	
	SET NOCOUNT OFF;
END

EXEC dbo.CustSameCity 'PATNA'

--Q4: Create a Store Procedure which will accept city of the customer as input parameter and product the following output List in JSON format List All the Customers Living in city provided in input parameter and Having the Branch City as MUMBAI or DELHI


CREATE PROCEDURE CityPro
@City VARCHAR(18)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT c.Cname FROM Customer c
	JOIN Deposit d ON d.Cname = c.Cname
	JOIN Branch b ON  b.Bname = d.Bname
	WHERE c.City = @City AND b.City IN('DELHI','MUMBAI')
	FOR JSON AUTO

	SET NOCOUNT OFF;
END

EXEC CityPro'BARODA'

--Q5: Count the Number of Customers Living in the City where Branch is Located



ALTER PROCEDURE CityPro
@branchName VARCHAR(18)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @city VARCHAR(18) = (SELECT City FROM Branch WHERE Bname=@branchName)
	SELECT COUNT(Cname) FROM Customer 
	WHERE City = @city
	
	SET NOCOUNT OFF;
END
GO

EXEC CityPro 'ANDHERI'

--Q6: Create a Procedure which will accept input in JSON parameter CustomerName,City, ACTNO,Branch,amount  
--And insert these record in the Deposit table.
--Before inserting some validation should be done like amount should be greater than 10Rs.
--and date should always be current date.

CREATE PROCEDURE All_Details @jsonData NVARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Customer
	SELECT Cname,City AS Adate FROM OPENJSON(@jsonData)
		WITH (Cname VARCHAR(18) '$.Cname',City VARCHAR(18) '$.City',
			ActNo INT '$.ActNo',Bname VARCHAR(18) '$.Bname',Amount INT '$.Amount')
	INSERT INTO Deposit
		SELECT ActNo,Cname,Bname,Amount,GETDATE() AS Adate FROM OPENJSON(@jsonData)
		WITH (Cname VARCHAR(18) '$.Cname',City VARCHAR(18) '$.City',
			ActNo INT '$.ActNo',Bname VARCHAR(18) '$.Bname',Amount INT '$.Amount')
	SET NOCOUNT OFF;
END

DECLARE @json NVARCHAR(MAX)

SET @json = N'[ {"Cname":"PARTH","City":"MUMBAI","ActNo":114,
		"Bname":"POWAI","Amount":1000} ]'

EXEC All_Details @json 

SELECT * FROM Deposit
SELECT * FROM Customer