--SQL Day 1 Assignment

--You have been hired to create a relational database to support a car sales business. 
--You need to store information on the business employees, inventory, and completed sales.
--You also need to account for the fact that each salesperson receives a different percentage of their sales in commission. 
--What tables and columns would you create in your relational database, and how would you link the tables?

--Table for SalesPerson

CREATE TABLE SalesPerson(EmployeeId INT NOT NULL PRIMARY KEY,EmployeeName VARCHAR(20),Commission VARCHAR(10));

INSERT INTO SalesPerson(EmployeeId,EmployeeName,Commission)
VALUES(101,'RAKESH',1000),(102,'MUKESH',800),(103,'MANISH',500),(104,'RAVI',1500),
    (105,'MAHESH',700),(106,'PRATIK',500),(107,'RAMESH',700),(108,'RAM',2000);

--Table for Cars

CREATE TABLE Cars(CarId INT NOT NULL PRIMARY KEY,CarName VARCHAR(20),
ModelId INT FOREIGN KEY REFERENCES Model(ModelId));

INSERT INTO Cars(CarId,CarName,ModelId)
VALUES(1001,'BMW',101),(1001,'BMW',102),(1001,'BMW',103),(1002,'ROLLSROYCE',201),
(1003,'AUDI',301),(1003,'AUDI',302),(1002,'ROLLSROYCE',202),(1002,'ROLLSROYCE',203);

--Table for Model

CREATE TABLE Model(ModelId INT NOT NULL PRIMARY ,ModelName VARCHAR(20),Price INT);

INSERT INTO Model(ModelId,ModelName,Price)
VALUES(101,'X5',2500000),(1002,'X3',3000000),(103,'BMW','X1',2000000),(201,'GHOST',6500000),
(301,'RS5',4000000),(302,'Q2',3500000),(202,'DAWN',5000000),(203,'PHANTOM',6000000);

--Table for Sales

CREATE TABLE Sales(BillNo INT NOT NULL PRIMARY KEY,ModelId INT FOREIGN KEY REFERENCES Cars(CarId),
EmployeeId INT FOREIGN KEY REFERENCES SalesPerson(EmployeeId));  

INSERT INTO Sales(BillNo,ModelId,EmployeeId)
VALUES(5001,301,101),(5002,201,103),(5003,101,105),(5004,201,106),
(5005,302,102),(5006,101,103),(5007,103,104),(5008,301,106);
