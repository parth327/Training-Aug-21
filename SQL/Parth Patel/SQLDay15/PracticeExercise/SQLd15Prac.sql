--SQL TRANSACTION AND INDEXES PRACTICE

--Transactions


--A transaction is a single unit of work. 
--If a transaction is successful, all of the data modifications made during the transaction are committed and become a permanent part of the database

--If a transaction encounters errors and must be canceled or rolled back, then all of the data modifications are erased.


--types of transactions

--Autocommit transactions
--Each individual statement is a transaction.

--Explicit transactions
--Each transaction is explicitly started with the BEGIN TRANSACTION statement and explicitly ended with a COMMIT or ROLLBACK statement.


--Implicit transactions
--A new transaction is implicitly started when the prior transaction completes, but each transaction is explicitly completed with a COMMIT or ROLLBACK statement.

--Implicit Transactions

SET IMPLICIT_TRANSACTIONS ON

INSERT INTO myTable VALUES('Raj','Sharma',9925099250)
UPDATE mytable
SET PhoneNumber = 9976799676
WHERE name = 'sagar'

ROLLBACK TRAN
GO


INSERT INTO myTable VALUES('Raj','Sharma',9925099250)
UPDATE mytable
SET PhoneNumber = 9976799676
WHERE name = 'sagar'

COMMIT TRAN
GO

SELECT * FROM mytable

--EXPLICIT TRANS

BEGIN TRANSACTION;

UPDATE mytable
SET surname = 'RAY'
WHERE name= 'sagar'

ROLLBACK TRAN;

BEGIN TRANSACTION;

UPDATE mytable
SET surname = 'RAY'
WHERE name= 'sagar'

COMMIT TRAN;

--naming a transaction

BEGIN TRANSACTION myTransaction

DELETE FROM mytable
WHERE name = 'Raj'

COMMIT TRANSACTION myTransaction

SELECT * FROM mytable

--transaction with mark

BEGIN TRANSACTION insertingTab
	WITH MARK N'inserting name ranveer singh'
Go

INSERT INTO mytable
VALUES('ranveer','Singh',9098090980)

COMMIT TRANSACTION insertingTab

SELECT * FROM mytable


--Indexes


CREATE TABLE dbo.bookstore
(id   INT NOT NULL,name VARCHAR(100));
Insert into dbo.bookstore values(1,'Learn ABC of SQL Server')
Insert into dbo.bookstore values(2,'Advanced troubleshooting step SQL Server')

--its better to use ssms gui for creating indexes

--index creatation using tsql

CREATE CLUSTERED INDEX IX_BookID
ON dbo.BookStore(id);
GO

--creating non clustered indexes
CREATE NONCLUSTERED INDEX NCIX_BookID
ON dbo.BookStore(id);

EXECUTE sp_helpindex employees
--the sp_helpindex all indexes of the table employees

SELECT avg_page_space_used_in_percent,avg_fragmentation_in_percent,index_level,record_count,page_count,fragment_count,avg_record_size_in_bytes
FROM sys.dm_db_index_physical_stats(DB_ID('testDB'), OBJECT_ID('bookstore'), NULL, NULL, 'DETAILED');
GO

SELECT * FROM BookStore


