--SQL JSON Practice

--OPENJSON

DECLARE @json NVARCHAR(MAX);
SET @json = N'[
		{"id"=1,"Name":"john"},
		{"id"=2,"Name":"Rita"}
		]';
DECLARE @json NVARCHAR(MAX);

SELECT * FROM OPENJSON(@json)
WITH(Id int '$.id',
Name Nvarchar(50) '$.Name'
)

--Convert SQL server Data to JSON or expert JSON

SELECT EmployeeID,FirstName AS "info.name",LastName AS "info.surname",HireDate AS "JoiningDate" FROM Employees FOR JSON PATH;
