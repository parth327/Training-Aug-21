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


