--SQL Batch Assignment


--Create a batch Select Public Relation as 'P.R', Government Sales as 'G.S', Retail Sales as 'R.S' from employee table

 SELECT case DepartmentName when 'Public Relations' then 'P.R' when 'Government Sales' then 'G.S' when 'Retail Sales' then 'R.S'
 END as Department FROM Departments

select * from Departments