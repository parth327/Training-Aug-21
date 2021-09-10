--SQL Triggers

-- Trigger is set of T-SQL statements that executes in repsonse to certain actions,such as insert or delete.
--Is used to ensure data integrity

--Triggers are the following types
--DML triggers
--DDL triggers

--DML Triggers

--Fire automatically in response to DML statements.
--Ensure Data Integrity.

--Execution of a DML trigger creates the following temporary tables,called magic tables:
	--Inserted table:
		--Contains the copy of all records that are inserted in the trigger table.
	--Deleted Table:
		--Contains a copy of all the records that have been deleted from the trigger table.

--Depending on the operation that is performed,DML triggers can be further categorized as:
 -- Insert trigger:
	--Gets fired when new record is added.
 -- Update trigger:
	--Gets fired when an exiting record is modified.
 -- Delete trigger:
	--Gets fired when a record is deleted.
--Depending on the way the triggers are fired,DML triggers can be further categorized as:
	--Alter trigger:
		--Fires after the execution of the DML operation for which the trigger is defind.
	--Instead of trigger:
		--Executes instead of the events that events that cause the trigger to fire.
		--Can be created on both,a table as well a view.

--DDL Trigger

	--Is fired in response ti DML Statements.
	--Is used to perform administrative tasks.

--Nested Trigger

--When base table deletd,than delete trigger event fired and delete all data of chid table, too.

--For Example , if Department table deleted,So automatically Employee Table deleted also EmployeeHistory Column deleted.

--Recursive Trigger

--Eventually Call itself.
--Are special cases of nested triggers.
--Can be of the following types:
	--Direct
	--Indirect

--Direct recursive trigger
	--Fired and performs an action that causes the same trigger to fire again.
		--If update trigger fires in table A,than automatically take actions to fire again. 

--Indirect Recursive trigger
	--Fires a trigger on another table and evnetually the nested trigger ends up firing the first trigger again.
		--If update trigger fires in table A,than automatically nested trigger fired in table B and table c also.

-- Trigger Syntax

-- Create or alter trigger

{ CREATE | ALTER } TRIGGER <name>
ON {<table> | <view> }
{ AFTER | INSTEAD OF }
{ INSERT | UPDATE | DELETE}
AS 
BEGIN
--Logic
END

--Creation of trigger

--Gets fired at the time of inserting records in the shift table.
--Rolls back the INSERT statement if the modified dat is not equal to h=the current date.

CREATE TRIGGER trgShift
ON Employees
FOR INSERT 
AS
	DECLARE @HireDate datetime
	SELECT @HireDate = HireDate FROM Inserted
	IF(@HireDate != GETDATE())
	BEGIN
		PRINT' The modified date should be the current date.Hence,cannot insert.'
		ROLLBACK TRANSACTION
	END

--Creating a delete trigger

--Creates a DELETE trigger on the Department table.
--Prevents deletion in the Department table.

CREATE TRIGGER trgDelete
ON Employees
FOR DELETE
AS
PRINT'Deletion of department is not allowed'
ROLLBACK TRANSACTION
RETURN

--Creating an Update trigger

--Gets fired while updating the Rate column in the EmployeePayHistory table.

CREATE TRIGGER trg Update
ON Employees
FOR UPDATE 
AS
IF UPDATE(RATE)
BEGIN
DECLARE @AvgRate float
SELECT @AvgRate = AVG(Rate)
FROM Employees
IF(@AvgRate > 20)
BEGIN
PRINT'The avg value of rate cannot be more than 20'
IF(@AcgRate > 20)
BEGIN
PRINT'The avh value of rate cannot be more than 20'
ROLLBACK TRANSACTION
END
END

--Create an after trigger

--Gets Fired after the delete statement is executed on the shift table to display a confirmation message.

CREATE TRIGGER trgDeleteShift ON Employees
AFTER DELETE
AS 
PRINT'Deletion successfull'

--Create an instead of trigger 

--Displays a message instead of deleting record from the project table.

CREATE TRIGGER trgDel ON
Employees
INSTEAD OF DELETE
AS
PRINT'Projects record cannot be deleted'

--Creating a DDL trigger

CREATE TRIGGER Safety
ON DATABASE
FOR DROP_TABLE ALTER_TABLE
AS
PRINT'You must disable Trigger "Safety" to drop pr alter tables! '
ROLLBACK

--Altering a Trigger

--Syntax:

ALTER TRIGGER trigger_name
{ FOR | AFTER } { event_type[,...n]} |
DDL_DATABASE_LEVEL_EVENTS }
{ AS
{ sql_statement [...n] }
}

--Alter trigger

ALTER TRIGGER trgShift
ON Employees
FOR INSERT 
AS
DECLARE @HireDate datetime 
SELECT @HireDate = HireDate FROM Inserted
IF(@HireDate != GETDATE())
BEGIN
RAISERROR('The modified date is not the current date.The transcation cannot be processed. ',10,1)
ROLLBACK TRANSACTION
END 
RETURN

--Deleting a Trigger

--Syantax

DROP TRIGGER { trigger }

--Example

DROP TRIGGER
trgShift



