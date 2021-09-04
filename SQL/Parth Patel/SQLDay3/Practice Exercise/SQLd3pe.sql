--Day 3 Practice Exercise

--String Functions :-

--ASCII

SELECT ASCII('C');

--CHAR

SELECT CHAR(85);

--CHARINDEX

SELECT CHARINDEX('M','MICROSOFT DOT NET',1);

--CONCAT

SELECT CONCAT('Parth','Patel');

--FORMAT

DECLARE @d DATETIME='02/03/2014';
SELECT FORMAT(@d,'d','en-US');

--LEFT

SELECT LEFT('MICROSOFT',3);

--LEN

SELECT LEN('Parth');

--LOWER

SELECT LOWER('SQL SERVER');

--LTRIM

SELECT LTRIM(' Sql Server');

--PATINDEX

SELECT PATINDEX('%SER%','SQL SERVER');

--REPLACE

SELECT REPLACE('We are Friends','We','They');

--RTRIM

SELECT RTRIM('Sql Server ');

--SOUNDEX

SELECT SOUNDEX ('Ear'), SOUNDEX ('Here');  

--SPACE

SELECT SPACE(12);

--STR

SELECT STR(246.573, 3, 3);

--STUFF

SELECT STUFF('SQL Tutorial', 1, 3, 'HTML');

--SUBSTRING

SELECT SUBSTRING('SQL Tutorial', 1, 3);

--TRANSLATE

SELECT TRANSLATE('Monday', 'Monday', 'Sunday'); 

--TRIM

SELECT TRIM('     SQL Tutorial!     ');

--UNICODE

SELECT UNICODE('Apple');

--REPLICATE

SELECT REPLICATE('SQL Tutorial', 3); 

--REVERSE

SELECT REVERSE('SQL Tutorial');

--RIGHT

SELECT RIGHT('SQL Tutorial', 6);

--Date Function

--Dateadd

SELECT dateadd(mm,2,'2021-03-04');

--DateName

SELECT datename(month,convert(datetime,'2021-02-07'))

--GetDate

SELECT getdate();

--day

SELECT day('2021-07-04');

--Math Functions

--ceiling

SELECT ceiling(12.23);

--exp

SELECT exp(2.4);

--floor

SELECT floor(3.89);

--power

SELECT power(2,6);

--round

SELECT round(13.466,2);
