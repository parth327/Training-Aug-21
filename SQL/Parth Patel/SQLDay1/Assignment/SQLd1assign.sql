--SQL Day 1 Assignment

--You have been hired to create a relational database to support a car sales business. 
--You need to store information on the business employees, inventory, and completed sales.
--You also need to account for the fact that each salesperson receives a different percentage of their sales in commission. 
--What tables and columns would you create in your relational database, and how would you link the tables?

CREATE TABLE SalesPerson(EmployeeId INT NOT NULL PRIMARY KEY,EmployeeName VARCHAR(20),Commission VARCHAR(10));

CREATE TABLE Cars(CarId INT NOT NULL PRIMARY KEY,CarName VARCHAR(20),ModelId INT NOT NULL);

CREATE TABLE Model(ModelId INT FOREIGN KEY REFERENCES Cars(CarId) ,ModelName VARCHAR(20),Price VARCHAR(20));

CREATE TABLE Sales(BillNo INT NOT NULL PRIMARY KEY,ModelId INT FOREIGN KEY REFERENCES Cars(CarId),EmployeeId INT REFERENCES SalesPerson(EmployeeId));  



