--Day 3 Additional

--String Function

--Using ASCII and CHAR to print ASCII values from a string

SELECT CHAR(65) AS [65], CHAR(66) AS [66],CHAR(97) AS [97], CHAR(98) AS [98],CHAR(49) AS [49], CHAR(50) AS [50];

--Searching from a position other than the first position

SELECT CHARINDEX('is', 'This is a string', 4);

--Results when the string is not found

SELECT TOP(1) CHARINDEX('at', 'This is a string') FROM dbo.DimCustomer;

--Using CONCAT with NULL values

CREATE TABLE EmpName (EmpId INT NOT NULL,FirstName NVARCHAR(20) NULL,LastName NVARCHAR(20) NOT NULL);  
INSERT INTO EmpName VALUES( 101, NULL, 'Patel' );  

SELECT CONCAT(Empid,FirstName,LastName) AS Result  
FROM EmpName;  

--DIFFERENCE
--This function returns an integer value measuring the difference between
-- the SOUNDEX() values of two different character expressions.

SELECT SOUNDEX('Ice'), SOUNDEX('Eyes'), DIFFERENCE('Ice','Eyes');  
  
SELECT SOUNDEX('Blotchet-Halls'), SOUNDEX('Greene'), DIFFERENCE('Blotchet-Halls', 'Greene');  

--Using LEFT with a column

SELECT LEFT(FirstName, 5) FROM Employees  
ORDER BY EmployeeID;  

--Using LEFT with a character string

SELECT LEFT('abcdefg',2);  

--The following example selects the number of characters and the data in FirstName 
--For employee whose EmployeeId is 101. 

SELECT LEN(FirstName) AS Length, FirstName, LastName FROM Employees  
WHERE EmployeeId = 101;  
  
--The following example replaces the string cde in abcdefghicde with xxx.

SELECT REPLACE('abcdefghicde','cde','xxx');  

--The following example returns all contact first names with the characters reversed

SELECT FirstName, REVERSE(FirstName) AS Reverse FROM Employees  
WHERE EmployeeID = 105 ORDER BY FirstName;  

SELECT REVERSE(1234) AS Reversed ;   

--Using RIGHT with a column

SELECT RIGHT(FirstName, 5) AS 'First Name' FROM Employees  
WHERE EmployeeID < 105 ORDER BY FirstName;  

--The following example trims the last names and concatenates a comma, two spaces, 
--and the first names of people listed in the Employees table.
  
SELECT RTRIM(LastName) + ',' + SPACE(2) +  LTRIM(FirstName)  
FROM Employees  
ORDER BY LastName,FirstName;  

--Using SUBSTRING with a character string

SELECT name, SUBSTRING(FirstName, 1, 1) AS Initial ,
SUBSTRING(FirstName, 3, 2) AS ThirdAndFourthCharacters
FROM Employees WHERE EmployeeId = 105;

--Removes the space character from both sides of string

SELECT TRIM( '     test    ') AS Result;



--DATEDIFF

--Specifying columns for startdate and enddate

CREATE TABLE dbo.Duration (startDate datetime2, endDate datetime2);
INSERT INTO dbo.Duration(startDate, endDate)VALUES ('2007-05-06 12:10:09', '2007-05-07 12:10:09');

SELECT DATEDIFF(day, startDate, endDate) AS 'Duration'  
    FROM dbo.Duration;  




