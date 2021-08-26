--Day 3 Additional

--DATEFROMPARTS()

SELECT DATEFROMPARTS ( 2010, 12, 31 ) AS Result;

--DATETIME2FROMPARTS

--An example without fractions of a second

SELECT DATETIME2FROMPARTS ( 2010, 12, 31, 23, 59, 59, 0, 0 ) AS Result;

--Example with fractions of a second

SELECT DATETIME2FROMPARTS ( 2011, 8, 15, 14, 23, 44, 5, 1 );  

--DATETIMEFROMPARTS

SELECT DATETIMEFROMPARTS ( 2010, 12, 31, 23, 59, 59, 0 ) AS Result;

--DATETIMEOFFSETFROMPARTS 

--An example without fractions of a second

SELECT DATETIMEOFFSETFROMPARTS ( 2010, 12, 31, 14, 23, 23, 0, 12, 0, 7 ) AS Result;

-- Example with fractions of a second

SELECT DATETIMEOFFSETFROMPARTS ( 2011, 8, 15, 14, 30, 00, 5, 12, 30, 1 );  

--SMALLDATETIMEFROMPARTS

SELECT SMALLDATETIMEFROMPARTS ( 2010, 12, 31, 23, 59 ) AS Result;

--TIMEFROMPARTS

--Simple example without fractions of a second

SELECT TIMEFROMPARTS ( 23, 59, 59, 0, 0 ) AS Result;

--Example with fractions of a second

SELECT TIMEFROMPARTS ( 14, 23, 44, 5, 1 );  

--DATEDIFF

--Specifying columns for startdate and enddate

CREATE TABLE dbo.Duration (startDate datetime2, endDate datetime2);
INSERT INTO dbo.Duration(startDate, endDate)VALUES ('2007-05-06 12:10:09', '2007-05-07 12:10:09');
SELECT DATEDIFF(day, startDate, endDate) AS 'Duration'  
    FROM dbo.Duration;  

--Specifying user-defined variables for startdate and enddate

DECLARE @startdate DATETIME2 = '2007-05-05 12:10:09.3312722';  
DECLARE @enddate   DATETIME2 = '2007-05-04 12:10:09.3312722';   
SELECT DATEDIFF(day, @startdate, @enddate);

--Specifying scalar system functions for startdate and enddate

SELECT DATEDIFF(millisecond, GETDATE(), SYSDATETIME());

--Specifying scalar subqueries and scalar functions for startdate and enddate

USE AdventureWorks2012;GO SELECT DATEDIFF(day,(SELECT MIN(OrderDate) FROM Sales.SalesOrderHeader),(SELECT MAX(OrderDate) FROM Sales.SalesOrderHeader));

--Specifying numeric expressions and scalar system functions for enddate

USE AdventureWorks2012;GO SELECT DATEDIFF(day, '2007-05-07 09:53:01.0376635', GETDATE() + 1)AS NumberOfDays FROM Sales.SalesOrderHeader;  
GO USE AdventureWorks2012;GO SELECT DATEDIFF(day,'2007-05-07 09:53:01.0376635',DATEADD(day, 1, SYSDATETIME())) AS NumberOfDays FROM Sales.SalesOrderHeader;GO

--DATEDIFF_BIG

--Specifying columns for startdate and enddate

CREATE TABLE dbo.Duration(startDate datetime2, endDate datetime2);  
INSERT INTO dbo.Duration(startDate,endDate)VALUES('2007-05-06 12:10:09', '2007-05-07 12:10:09');  
SELECT DATEDIFF_BIG(day, startDate, endDate) AS 'Duration'FROM dbo.Duration;  

--DATEADD

--datepart argument

SELECT DATEADD(month, 1, '20060830');
SELECT DATEADD(month, 1, '20060831');

--number argument

SELECT DATEADD(year,2147483648, '20060731');  
SELECT DATEADD(year,-2147483649, '20060731');

--date argument

SELECT DATEADD(year,2147483647, '20060731');  
SELECT DATEADD(year,-2147483647, '20060731');

--EOMONTH

DECLARE @date DATETIME = '12/1/2011';  
SELECT EOMONTH ( @date ) AS Result;  
GO

--SWITCHOFFSET

DECLARE @dt datetimeoffset = switchoffset (CONVERT(datetimeoffset, GETDATE()), '-04:00');   
SELECT * FROM t    
WHERE c1 > @dt OPTION (RECOMPILE);

--TODATETIMEOFFSET

DECLARE @todaysDateTime DATETIME2;  
SET @todaysDateTime = GETDATE();  
SELECT TODATETIMEOFFSET (@todaysDateTime, '-07:00');



