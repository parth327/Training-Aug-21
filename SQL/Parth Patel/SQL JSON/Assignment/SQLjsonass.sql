--SQL JSON Assignment

--5 Students Name, Address, City, DOB, Standard need to be inserted in the student table, 
--need to fetch these result from json variable. and select output in the json format

DECLARE @json NVARCHAR(MAX);
SET @json = N'[
		{"id"=1,"Name":"john","Address":"SantJosef","City":"London","DOB":"2014-05-04","Std":2},
		{"id"=2,"Name":"Williams","Address":"Galaxy","City":"Chicago","DOB":"2012-07-05","Std":4},
		{"id"=3,"Name":"jay","Address":"Partm","City":"AlRah","DOB":"2011-09-03","Std":5},
		{"id"=4,"Name":"Mehul","Address":"Greaya","City":"AlHabib","DOB":"2013-05-04","Std":3},
		{"id"=5,"Name":"Rahul","Address":"Santm","City":"SansSarif","DOB":"2012-06-09","Std":4}
		]';

SELECT * FROM OPENJSON(@json)
WITH(Name NVARCHAR(20) '$.Name',
Address Nvarchar(25) '$.Address',
City Nvarchar(25) '$.City',
DOB DATE '$.DOB',
Std INT '$.Std'
)