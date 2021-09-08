--SQL Exception Handling

-- Try Catch Syntax

BEGIN TRY  
     --code to try 
END TRY  
BEGIN CATCH  
     --code to run if an error occurs
--is generated in try
END CATCH

--Error Functions used within CATCH block

--ERROR_NUMBER()
--This returns the error number and its value is the same as for @@ERROR function.

--ERROR_LINE()
--This returns the line number of T-SQL statement that caused an error.

--ERROR_SEVERITY()
--This returns the severity level of the error.

--ERROR_STATE()
--This returns the state number of the error.

--ERROR_PROCEDURE()
--This returns the name of the stored procedure or trigger where the error occurred.

--ERROR_MESSAGE()
--This returns the full text of error message. The text includes the values supplied for 
--any substitutable parameters,such as lengths, object names, or times.

--Exception Handling Example

 BEGIN TRY
DECLARE @num INT, @msg varchar(200)
---- Divide by zero to generate Error
SET @num = 5/0
PRINT 'This will not execute'
END TRY
BEGIN CATCH
PRINT 'Error occured that is'
set @msg=(SELECT ERROR_MESSAGE())
print @msg;
END CATCH
GO 

BEGIN TRY
DECLARE @num INT
---- Divide by zero to generate Error
SET @num = 5/0
PRINT 'This will not execute'
END TRY
BEGIN CATCH
SELECT ERROR_NUMBER() AS ErrorNumber, ERROR_SEVERITY() AS ErrorSeverity, ERROR_STATE() AS ErrorState, ERROR_PROCEDURE() AS ErrorProcedure, ERROR_LINE() AS ErrorLine, ERROR_MESSAGE() AS ErrorMessage;
END CATCH;
GO 

