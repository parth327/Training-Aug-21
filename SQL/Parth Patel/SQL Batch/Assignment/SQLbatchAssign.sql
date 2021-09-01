--SQL Batch Assignment


--Create a batch Select Banking as ‘Bank Dept’, Insurance as ‘Insurance Dept’ and Services as ‘Services Dept’ from employee table

 SELECT case DepartmentName when 'IT' then 'Information technology' when 'Banking' then 'Bank Dept' when 'Insurance' then 'Insurance Dept' when
'Services' then 'Services Dept' END as Department FROM Departments
