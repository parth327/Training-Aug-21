--SQL Day 13 ASSIGNMENT

--Create a scaler Function to compute PF which will accept parameter basicsalary and compute PF. PF is 12% of the basic salary.
	   

CREATE FUNCTION uf_pftb1(@Sal int)  
RETURNS int   
AS     
BEGIN  
    DECLARE @pf int;  
    SELECT @pf = Salary*0.12   
    FROM Employees   
    WHERE Salary = @Sal   
			IF (@pf IS NULL)   
        SET @pf = 0;  
    RETURN @pf;  
END; 

DECLARE @Sal INT = 8000

--Create a scaler Function which will compute PT which will accept MontlyEarning. Criteria as below.

CREATE FUNCTION P_Fund(@MontlyEarning int)
RETURNS float
AS
BEGIN
DECLARE @PF FLOAT
IF @MontlyEarning < 5999 
	SET @PF = 0
IF @MontlyEarning BETWEEN 6000 AND 8999
	SET @PF = 80
IF @MontlyEarning BETWEEN 9000 AND 11999
	SET @PF = 150
IF @MontlyEarning >= 12000
	SET @PF=200
RETURN @PF
END
GO

DECLARE @Fund FLOAT
EXEC @Fund =P_Fund
	 @MontlyEarning = 9000
PRINT @Fund

--Create a table valued function which will accept JobTitle which will return new table set based on jobtitle 

CREATE FUNCTION uf_Jobt (@JobTitle VARCHAR(50))
RETURNS TABLE
AS
RETURN
(
	SELECT * FROM Employees WHERE JobId=@JobTitle
)
GO

SELECT * FROM Employees
SELECT * FROM uf_Jobt('IT_PROG')