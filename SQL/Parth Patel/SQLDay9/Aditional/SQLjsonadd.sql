--SQL JSON ADDITIONAL

--JSON Data in SQL Server

--Extract values from JSON text and use them in queries
--ISJSON (Transact-SQL) = tests whether a string contains valid JSON.
--JSON_VALUE (Transact-SQL) = extracts a scalar value from a JSON string.
--JSON_QUERY (Transact-SQL) = extracts an object or an array from a JSON string.
--JSON_MODIFY (Transact-SQL) = changes a value in a JSON string.

--Change JSON values

DECLARE @json NVARCHAR(MAX);
SET @json = '{"info": {"address": [{"town": "Belgrade"}, {"town": "Paris"}, {"town":"Madrid"}]}}';
SET @json = JSON_MODIFY(@json, '$.info.address[1].town', 'London');
SELECT modifiedJson = @json;

--Convert JSON collections to a rowset

DECLARE @json NVARCHAR(MAX);
SET @json = N'[
  {"id": 2, "info": {"name": "John", "surname": "Smith"}, "age": 25},
  {"id": 5, "info": {"name": "Jane", "surname": "Smith"}, "dob": "2005-11-04T12:00:00"}
]';

--OPENJSON with the default output

DECLARE @json NVARCHAR(MAX)

SET @json='{"name":"John","surname":"Doe","age":45,"skills":["SQL","C#","MVC"]}';
SELECT *FROM OPENJSON(@json);

--Convert SQL Server data to JSON or export JSON

SELECT EmployeeID, FirstName AS "info.name", LastName AS "info.surname" ,HireDate AS "Join"
FROM Employees FOR JSON PATH;

--Import JSON data into SQL Server tables

DECLARE @jsonVariable NVARCHAR(MAX);

SET @jsonVariable = N'[
  {"Order": {"Number":"SO43659","Date":"2011-05-31T00:00:00"},"AccountNumber":"AW29825","Item":
   {"Price":2024.9940,"Quantity":1}},  
  {"Order": {"Number":"SO43661","Date":"2011-06-01T00:00:00"},"AccountNumber":"AW73565","Item": 
  {"Price":2024.9940,"Quantity":3}}]';

