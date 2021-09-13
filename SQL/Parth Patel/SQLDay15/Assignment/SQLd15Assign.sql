--SQL Day 15 Assignment

--Indexes

--TRUE FALSE

-- A primary key can contain NULL values. [FALSE] 

-- A clustered index usually improves performance when inserting data.[FALSE]

-- A table can contain only one clustered index [TRUE]

--Fill in the blanks

-- The value of a primary key must be [UNIQUE].

--  A foreign key works in conjunction with primary key or unique constraints to enforce 
--[REFERENITIAL INTEGRITY] between tables.

-- Add an index to one or more columns to speed up data [RETRIVAL].

-- Values in a clustered index are [SORTED].

--MCQs

--1. Which of the following is not a constraint?

--a. CHECK
--b. DEFAULT
--c. UNIQUE
--d. INDEX

--ANSWER: d

--2. Which of the following things can help speed data retrieval?

--a. A DEFAULT constraint
--b. A primary key constraint
--c. A clustered index
--d. A foreign key constraint

--ANSWER: c

--3. Which of the following statements is not true with regard to foreign keys?

--a. A foreign key is a combination of one or more columns used to establish and enforce 
--link between the data in two tables.
--b. You can create a foreign key by defining a foreign key constraint when you create or 
--alter a table.
--c. A foreign key enforces referential integrity by ensuring only valid data is stored.
--d.  A table can contain only one foreign key.

--ANSWER: d
 
--4. Consider using a clustered index when:

--a. Columns contain a large number of distinct values
--b. Columns are accessed sequentially
--c. Columns undergo frequent changes
--d.  Queries return large result sets

--ANSWER: c

--5.Which of the following could not be used as a primary key?

--a. A Social Security number
--b. An address
--c. An employee number
--d.  The serial number of an electronic component

--ANSWER: b
 
--8.  How many clustered indexes can you have for a database?

--a. 1 
--b. 2 
--c. 4 
--d. 8 

--ANSWER: 1

-- 9.  What is the name for the situation in which more than one columns act as a primary 
--key?

--a. Composite primary key
--b. Escalating key
--c. Foreign key
--d.  Constraint key

--ANSWER: a

--Comparing Clustered vs Non-clustered Indexes

--your boss wants to speed things up on the company’s database server. Therefore, he is thinking
--of having you create a couple of indexes. He asks you to explain the advantages and disadvantages 
--of creating a clustered index versus a non-clustered index. How should you respond?

--1. Clustered index is faster When Non-clustered index is slower.

--2. Clustered index requires less memory for operations When	Non-Clustered index requires more memory for operations.

--3. In clustered index, index is the main data when In Non-Clustered index, index is the copy of data.

--4. A table can have only one clustered index  when	A table can have multiple non-clustered index.

--5. Clustered index has inherent ability of storing data on the disk when Non-Clustered index does not have inherent ability of storing data on the disk.

--6. Clustered index store pointers to block not data when Non-Clustered index store both value and a pointer to actual row that holds data.

--7. In Clustered index leaf nodes are actual data itself when In Non-Clustered index leaf nodes are not the actual data itself rather they only contains included columns.

--8. In Clustered index, Clustered key defines order of data within table when In Non-Clustered index,index key defines order of data within index.

--9. A Clustered index is a type of index in which table records are physically reordered to match the index when A Non-Clustered index is a special type of index in which logical order of index does not match physical stored order of the rows on disk.

--Creating a clustered index

--You are a database administrator for the AdventureWorks Corporation. You recently created some databases, 
--and you’ve just realized how large the databases will become in the future. 
--Therefore, you need to create a new clustered index to help with overall performance.
--Using the SSMS interface, what steps would you use to create a new clustered index on the name column for the AdventureWorks database?

--step 1. Click on AdventureWorks database 

--step 2. Click on any table of AdventureWorks database.

--step 3. Then right-click on Indexes in table option.

--step 4. click on new index.

--step 5. Then click on General menu

--step 6. Select Index Type clustered.

--step 7. Click Ok 



-- Creating a Clustered Index Using Transact-SQL

--As a database administrator, you need to increase the performance of the PlanetsID table, so you decide to create a clustered index. 
--But instead of using SSMS, you decide to use queries to perform this task. Therefore, you create a new PlanetsID database using the following 
--commands within SMMS:

USE [AdventureWorks2019]
GO
CREATE TABLE [dbo].[PlanetsID](
[ID] [int] NOT NULL,
[Item] [int] NOT NULL,
[Value] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT INTO PlanetsID VALUES (4, 23, 66)
INSERT INTO PlanetsID VALUES (1, 12, 59)
INSERT INTO PlanetsID VALUES (3, 66, 24)

SELECT * FROM PlanetsID
GO

--Now that you have a database with data, what steps would you use to create a clustered index based on the ID Column?

CREATE CLUSTERED INDEX ClustPlanets   
    ON dbo.PlanetsID (ID);   
GO  

--TRANSACTION

--Detroit Bank need to implement the transaction whenever the amount is transferred from one account to the another account.

Create Database Bank
use Bank

Create Table Cust_Info
(
Customer_ID int Primary key Identity (100101, 1) Not Null,
Customer_Name varchar(50) Not Null,
DOB date Not Null,
Email nvarchar(30) check ( Email like '%__@%.com'),
Address nvarchar(30) Not Null,
Pincode Numeric(6) Not Null,
Phone_number numeric(10) Not Null
)

Create Table Account
(
Customer_ID int foreign key references Cust_Info(Customer_ID) Not Null,
Account_Number int Primary key Not Null, 
Account_type numeric(2) Not Null, -- (  0 is for Saving Account & 1 is for Current Account)
Balance_Amount money,
)

Insert Into Cust_Info values 
('Kartik' , '1999-12-25', null, 'Ahmedabad', 360001, 9656985688 ),
('Rahul' , '1999-08-30', null, 'Ahmedabad', 360001, 9656985688 ),
('Kishan' , '1999-11-21', null, 'Ahmedabad', 360001, 9656985688 ),
('Roy' , '1992-12-09', null, 'Ahmedabad', 360001, 9656985688 )


Insert Into Account values 
(100101, 124123, 0, 500000),
(100102, 129658, 0, 200000),
(100103, 963755, 0, 300000),
(100104, 539457, 0, 1000000)


Select * from Cust_Info
Select * from Account

ALTER TABLE ACCOUNTS
ADD CONSTRAINT chk_Balance CHECK ( Balance > 0 )

-- Detroit Bank need to implement the transaction whenever the amount is transferred from one account to the another account.

CREATE PROCEDURE Bank_Transaction @Amount MONEY , @Debit_From INT, @Credit_To MONEY
AS
BEGIN TRANSACTION Amount_transfer

BEGIN TRY
	UPDATE Accounts SET Balance_Amount = Balance_Amount - @Amount
	WHERE Account_Number =  @Debit_From 
	
	UPDATE Accounts SET Balance_Amount = Balance_Amount + @Amount
	WHERE Account_Number =  @Credit_To
	
	COMMIT TRANSACTION Amount_transfer
	PRINT 'Transaction Successful'
END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION Amount_transfer
	PRINT 'Transaction Failed'
END CATCH

-- Execute Transaction

EXECUTE Bank_Transaction @Amount = 5000 , @Debit_From =124123 , @Credit_To=963755
