--SQL Day 13 ADDITIONAL

--UDF

	
--Create Partition Function

CREATE PARTITION FUNCTION myRangePF1 (int)  
AS RANGE LEFT FOR VALUES (1, 100, 1000);  

--DROP Partition Function

DROP PARTITION FUNCTION  myRangePF1;

