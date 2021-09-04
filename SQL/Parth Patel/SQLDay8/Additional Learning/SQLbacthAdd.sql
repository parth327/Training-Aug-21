--SQL Batch ADDITIONAL

--WHILE loop

DECLARE @Counter INT 
SET @Counter=1
WHILE ( @Counter <= 10)
BEGIN
    PRINT 'The counter value is = ' + CONVERT(VARCHAR,@Counter)
    SET @Counter  = @Counter  + 1
END

--Infinite while loop

DECLARE @Counter INT 
SET @Counter=1
WHILE ( @Counter <= 10)
BEGIN
    PRINT 'Somebody stops me!'
  
END

--BREAK

DECLARE @Counter INT 
SET @Counter=1 
WHILE ( @Counter <= 10)
BEGIN
  PRINT 'The counter value is = ' + CONVERT(VARCHAR,@Counter)
  IF @Counter >=7
  BEGIN
  BREAK
  END
    SET @Counter  = @Counter  + 1
END

--CONTINUE Statement

DECLARE @Counter INT 
SET @Counter=1
WHILE ( @Counter <= 20)
BEGIN
 
  IF @Counter % 2 =1
  BEGIN
  SET @Counter  = @Counter  + 1
  CONTINUE
  END
    PRINT 'The counter value is = ' + CONVERT(VARCHAR,@Counter)
    SET @Counter  = @Counter  + 1
END

--Reading table records through the WHILE loop

CREATE TABLE SampleTable
(Id INT, CountryName NVARCHAR(100), ReadStatus TINYINT)
GO
INSERT INTO SampleTable ( Id, CountryName, ReadStatus)
Values (1, 'Germany', 0),
        (2, 'France', 0),
        (3, 'Italy', 0),
    (4, 'Netherlands', 0) ,
       (5, 'Poland', 0)
 
  SELECT * FROM SampleTable

  --Read all data row by row with the help of the WHILE loop: 

DECLARE @Counter INT , @MaxId INT, 
        @CountryName NVARCHAR(100)
SELECT @Counter = min(Id) , @MaxId = max(Id) 
FROM SampleTable
 
WHILE(@Counter IS NOT NULL
      AND @Counter <= @MaxId)
BEGIN
   SELECT @CountryName = CountryName
   FROM SampleTable WHERE Id = @Counter
    
   PRINT CONVERT(VARCHAR,@Counter) + '. country name is ' + @CountryName  
   SET @Counter  = @Counter  + 1        
END

--SQL Variable Declaration

DECLARE @TestVariable AS VARCHAR(100)='Save Our Planet'
PRINT @TestVariable

DECLARE @TestVariable AS VARCHAR(100)
SELECT @TestVariable = 'Save the Nature'
PRINT @TestVariable

DECLARE @PurchaseName AS NVARCHAR(50)
SELECT @PurchaseName = [Name]
FROM [Purchasing].[Vendor]
WHERE BusinessEntityID = 1492
PRINT @PurchaseName

DECLARE @StockVal AS INT
SELECT @StockVal=dbo.ufnGetStock(1)
SELECT @StockVal AS [VariableVal]

--Multiple Sql Variables

DECLARE @Variable1 AS VARCHAR(100)
DECLARE @Variable2 AS UNIQUEIDENTIFIER
SET @Variable1 = 'Save Water Save Life'
SET @Variable2= '6D8446DE-68DA-4169-A2C5-4C0995C00CC1'
PRINT @Variable1
PRINT @Variable2

DECLARE @Variable1 AS VARCHAR(100), @Variable2 AS UNIQUEIDENTIFIER
SELECT @Variable1 = 'Save Water Save Life' , @Variable2= '6D8446DE-68DA-4169-A2C5-4C0995C00CC1'
PRINT @Variable1
PRINT @Variable2

DECLARE @VarAccountNumber AS NVARCHAR(15)
,@VariableName AS NVARCHAR(50)
SELECT @VarAccountNumber=AccountNumber , @VariableName=Name
FROM [Purchasing].[Vendor]
WHERE BusinessEntityID = 1492
PRINT @VarAccountNumber
PRINT @VariableName

