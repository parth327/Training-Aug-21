--ASSIGNMENT 2:-

--   i. car (carid, vin, make, model, year, mileage, askprice, invoiceprice)
CREATE TABLE Car(CarId INT NOT NULL ,Vin INT NOT NULL PRIMARY KEY,Make varchar(10),Model varchar(10),Year varchar(4),Mileage varchar(3),AskPrice varchar(15),InvoicePrice varchar(15));
INSERT INTO Car(CarId,Vin,Make,Model,Year,Mileage,AskPrice,InvoicePrice)Values(101,1001,'Toyota','Prius','2004','26','1500000','1750000'),
(102,1002,'Toyota','Camry','2002','28','1200000','1350000'),(103,1003,'Toyota','Yaris','2005','25','1000000','1150000'),
(104,1004,'Toyota','Glanza','2002','27','1600000','1750000'),(105,1005,'Toyota','Fortuner','2007','28','2800000','3050000'),
(106,1006,'Toyota','Cruiser','2008','29','1600000','1850000'),(107,1007,'','BMW','2004','26','1500000','1750000'),
(108,1008,'BMW','X5','2010','26','4500000','4850000'),(109,1009,'BMW','X3','2007','21','4000000','4250000'),
(110,1010,'BMW','Z4','2004','23','5500000','5750000'),(111,1011,'BMW','X7','2004','26','4500000','4750000');

--ii. dealership (dealershipid, name, address, city, state)
CREATE TABLE Dealership(DealershipId INT NOT NULL PRIMARY KEY,Name VARCHAR(30),Address VARCHAR(20),City VARCHAR(10),State VARCHAR(10));
INSERT INTO Dealership(DealershipId,Name,Address,City,State)Values(11,'HeroHondaCarWorld','Krishna Park','Ahmedabad','Gujarat'),
(02,'Suresh','Shivaji nagar','Ahmedabad','Gujarat'),(03,'Raj','Parul Nagar','Surat','Gujarat'),
(04,'Ramesh','Krishna nagar','Ahmedabad','Gujarat'),(05,'Rahul','Kalyan Park','Delhi','Delhi'),
(06,'Parth','Nikol','Vadodara','Gujarat'),(07,'Rajiv','Ramnagar','Bhopal','M.P'),
(08,'Sandip','Radheshyam Park','Jamanagar','Gujarat'),(09,'Hardik','Rajiv Nagar','Indore','Rajsthan'),
(10,'Rajveer','Shriji Park','Anand','Gujarat');

-- iii. salesperson (salespersonid, name)
CREATE TABLE SalesPerson(SalespersonId INT NOT NULL PRIMARY KEY,Name VARCHAR(15));
INSERT INTO SalesPerson(SalespersonId,Name)VALUES(01,'Parth Patel'),(02,'Rahul Panchal'),(03,'Uttam Patel'),(04,'Harsh Patel'),(05,'Ravi Padhiyar'),(06,'Kuldeep Zala'),(07,'Rutvik Rav'),(08,'Sandip Patel'),(09,'Ramesh Kapoor'),(10,'Rajiv Shukla');

--iv. customer (customerid, name, address, city, state)
CREATE TABLE Customer(CustomerId INT NOT NULL PRIMARY KEY,Name VARCHAR(15),Address VARCHAR(20),City VARCHAR(10),State VARCHAR(10));
INSERT INTO Customer(CustomerId,Name,Address,City,State)
VALUES(11,'Himanshu','Maninagar','Ahmedabad','Gujarat'),(01,'Rahul Gandhi','RajBhavan','Delhi','Delhi'),(02,'Sonia Gandhi','SansadBhavan','Delhi','Delhi'),
(03,'Sandip','Sanjay Society','Himatnagar','Gujarat'),(04,'Narendra Modi','PM Bhavan','Delhi','Delhi'),
(05,'Ram','Bopal','Bhopal','MadyPrdesh'),(06,'Raju','anand nagar','anand','Gujarat'),
(07,'Raju Gandhi','Kerana','Kairana','Keral'),(08,'Rajiv Tiwari','Rampur','Gorakhpur','U.P'),
(09,'Ramesh Gandhi','Rajpur','Tamil','Tamilnadu'),(10,'Rajiv Shukla','Sitapur','Ayodhya','U.P');

--v. reportsto (reportstoid, salespersonid, managingsalespersonid)
CREATE TABLE Reportsto(ReportsId INT NOT NULL PRIMARY KEY,SalesPersonId INT,ManagingSalesPersonId INT,FOREIGN KEY(SalesPersonId)REFERENCES SalesPerson(SalesPersonId));
INSERT INTO Reportsto(ReportsId,SalesPersonId,ManagingSalesPersonId)
VALUES(01,01,01),(02,02,02),(03,03,03),(04,04,04),(05,05,05),(06,06,06),(07,07,07),(08,08,08);

--vi. worksat (worksatid, salespersonid, dealershipid, monthworked, basesalaryformonth)
CREATE TABLE Works(WorksatId INT NOT NULL PRIMARY KEY,SalesPersonId INT,DealershipId INT,MonthWorked INT,BaseSalaryForMonth VARCHAR(10),
FOREIGN KEY (SalesPersonId) REFERENCES SalesPerson(SalesPersonId),FOREIGN KEY (DealershipId) REFERENCES Dealership(DealershipId));

INSERT INTO Works(WorksatId,SalesPersonId,DealershipId,MonthWorked,BaseSalaryForMonth) VALUES(01,01,01,2,7000),
(02,02,02,3,'10000'),(3,3,3,3,'10000'),(4,4,4,3,'10000'),(5,5,5,6,'13000'),(6,6,6,4,'12000'),(7,7,7,6,'15000'),(8,8,8,7,'17000'),(9,9,9,8,'19000'),(10,10,10,9,'20000');

--vii. inventory (inventoryid, vin, dealershipid)

CREATE TABLE Inventory(InventoryId INT NOT NULL PRIMARY KEY,Vin INT,DealershipId INT,
FOREIGN KEY (DealershipId) REFERENCES Dealership(DealershipId),FOREIGN KEY (Vin) REFERENCES Car(Vin));
INSERT INTO Inventory(InventoryId,Vin,DealershipId)VALUES(01,1001,01),
(02,1002,02),(03,1003,03),(04,1004,04),(05,1005,05),(06,1006,06),(07,1007,07),(08,1008,08),(09,1009,09),(10,1010,10);


--viii. sale (saleid, vin, customerid, salespersonid, dealershipid, saleprice, saledate)

CREATE TABLE Sale(SaleId INT NOT NULL PRIMARY KEY,Vin INT,CustomerId INT,SalesPersonId INT,DealershipId INT,
FOREIGN KEY (DealershipId) REFERENCES Dealership(DealershipId),FOREIGN KEY (Vin) REFERENCES Car(Vin),
FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId),FOREIGN KEY (SalesPersonId) REFERENCES SalesPerson(SalespersonId),
SalePrice INT,SaleDate DATE);
INSERT INTO Sale(SaleId,Vin,CustomerId,SalespersonId,DealershipId,SalePrice,SaleDate)
VALUES(01,1001,1,1,1,2000,'2020-04-02'),(02,1002,2,2,2,2000,'2006-07-01'),
(03,1003,3,3,3,11000,'2014-05-06'),(04,1004,4,4,4,12000,'2015-09-08'),
(05,1005,5,5,5,15000,'2013-04-07'),(06,1006,6,6,6,9000,'2020-04-02'),
(07,1007,7,7,7,17000,'2010-04-02'),(08,1008,8,8,8,7000,'2016-07-02'),
(09,1009,9,9,9,3000,'2020-04-02'),(10,1010,10,10,10,5000,'2018-07-06');

--QUERIES :

--1. Find the names of all salespeople who have ever worked for the company at any dealership.

SELECT S.Name,S.SalesPersonId,W.DealershipId 
FROM SalesPerson s INNER JOIN Works w ON s.SalesPersonId=W.SalesPersonId;
 
--2. List the Name, Street Address, and City of each customer who lives in Ahmedabad.

SELECT Name,Address,City FROM Customer WHERE City='Ahmedabad';

--3. List the VIN, make, model, year, and mileage of all cars in the inventory of the dealership named "Hero Honda Car World".
 SELECT c.CarId,c.Vin,c.Model,c.Year,c.Mileage FROM Car c INNER JOIN Inventory i ON c.Vin=i.Vin 
INNER JOIN Dealership d ON i.DealershipId=d.DealershipId WHERE d.Name='HeroHondaCarWorld';

--4. List names of all customers who have ever bought cars from the dealership named "Concept Hyundai".

SELECT c.Name FROM Customer c INNER JOIN Sale s ON c.CustomerId=s.CustomerId INNER JOIN Dealership d 
ON s.DealershipId=d.DealershipId WHERE d.Name='ConceptHyundai';

--5. For each car in the inventory of any dealership, list the VIN, make, model, and year of the car, along with the name, city, and state of the dealership whose inventory contains the car.

SELECT c.Vin,c.Make,c.Model,c.Year,d.Name,d.City,d.State
FROM Car c INNER JOIN Inventory i ON c.Vin=i.Vin 
INNER JOIN Dealership d ON i.DealershipId=d.DealershipId;

--6. Find the names of all salespeople who are managed by a salesperson named "Adam Smith".

SELECT s.Name FROM SalesPerson s	
JOIN (SELECT r.SalesPersonId AS s1,s.Name AS ManagerName FROM SalesPerson s
JOIN Reportsto r ON s.SalespersonId=r.ManagingSalesPersonId)ManagerList 
ON s.SalespersonId=ManagerList.s1 WHERE ManagerName='Adam Smith';

--7. Find the names of all salespeople who do not have a manager.

SELECT s.Name FROM SalesPerson s LEFT JOIN Reportsto r 
ON s.SalesPersonId=r.SalesPersonId WHERE R.ManagingSalesPersonId IS NULL;

--8. Find the total number of dealerships.

SELECT COUNT(DealershipID) FROM Dealership;

--9. List the VIN, year, and mileage of all "Toyota Camrys" in the inventory of the dealership named "Toyota Performance". (Note that a "Toyota Camry" is indicated by the make being "Toyota" and the model being "Camry".)

SELECT c.Vin,c.Year,c.Mileage FROM Car c INNER JOIN Inventory i ON c.Vin=i.Vin INNER JOIN Dealership d
ON i.DealershipId=d.DealershipId WHERE c.Make='Toyota' AND c.Model='Camry' AND d.Name='ToyotaPerformance';		

--10. Find the name of all customers who bought a car at a dealership located in a state other than the state in which they live.

SELECT c.Name FROM Customer c INNER JOIN Sale s ON c.CustomerId=s.CustomerId 
INNER JOIN Dealership d ON s.DealershipId=d.DealershipId WHERE c.State ! = d.State;

--11. Find the name of the salesperson that made the largest base salary working at the dealership named "Ferrari Sales" during January 2010.

SELECT s.Name FROM SalesPerson s INNER JOIN Works w ON s.SalesPersonId=w.SalesPersonId
INNER JOIN Dealership d ON w.DealershipId=d.DealershipId
WHERE d.Name='Ferrari Sales' AND w.MonthWorked='January 2010';

--12. List the name, street address, city, and state of any customer who has bought more than two cars from all dealerships combined since January 1, 2010.

SELECT c.Name,c.Address,c.City,c.State FROM (SELECT * ,COUNT(s.CustomerId)AS TOTAL FROM Customer c
INNER JOIN Sale s ON c.CustomerId=s.CustomerId WHERE s.SaleDate>'01/01/2001' GROUP BY s.CustomerId)DERIVEDTABLE WHERE TOTAL>=2 ;

--13. List the name, salesperson ID, and total sales amount for each salesperson who has ever sold at least one car. The total sales amount for a salesperson is the sum of the sale prices of all cars ever sold by that salesperson.

SELECT a.Name,b.SalesPersonId,SUM(b.SalePrice) AS TotalSales FROM SalesPerson a 
JOIN Sale b ON a.SalesPersonId=b.SalesPersonId GROUP BY b.SalesPersonId;

--14. Find the names of all customers who bought cars during 2010 who were also salespeople during 2010. For the purpose of this query, assume that no two people have the same name.

SELECT c.Name FROM Customer c JOIN Sale s ON c.CustomerId=s.CustomerId
WHERE s.SaleDate BETWEEN '2009-12-31' AND '2011-01-01'; 

--15. Find the name and salesperson ID of the salesperson who sold the most cars for the company at dealerships located in Gujarat between March 1, 2010 and March 31, 2010.

SELECT a.Name,a.SalespersonId FROM (SELECT *,dense_rank() OVER(ORDER BY count(c.SalespersonId)DESC)AS RANK FROM SalesPerson a
JOIN Sale c ON a.SalespersonId=c.SalespersonId JOIN Dealership b ON c.DealershipId=b.DealershipId
WHERE c.SaleDate BETWEEN '2010-03-01' AND '2010-03-31' AND b.City='AHMEDABAD'
GROUP BY c.SalesPersonId)NEWTABLE WHERE RANK=1;

--16. Calculate the payroll for the month of March 2010.
--* The payroll consists of the name, salesperson ID, and gross pay for each salesperson who worked that month.
--* The gross pay is calculated as the base salary at each dealership employing the salesperson that month, along with the total commission for the salesperson that month.
--* The total commission for a salesperson in a month is calculated as 5% of the profit made on all cars sold by the salesperson that month.
--* The profit made on a car is the difference between the sale price and the invoice price of the car. (Assume, that cars are never sold for less than the invoice price.)

SELECT SalesPerson.Name,SalesPerson.SalesPersonId,(Works.BaseSalaryForMonth +(ProfitMade*0.05))AS GrossPay 
FROM (SELECT Sale.SalesPersonId AS S1, (Sale.SalePrice - Car.InvoicePrice) AS ProfitMade FROM Sale JOIN Car ON Sale.Vin=Car.Vin)T2 
JOIN Works ON T2.S1=Works.SalesPersonId JOIN SalesPerson ON Works.SalesPersonId=SalesPerson.SalesPersonId WHERE Works.MonthWorked='MARCH 2010';



        