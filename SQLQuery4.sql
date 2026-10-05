select * from tbl_dept
Select * from tbl_emp

select * from tbl_emp 
where empgender='f'
order by sal desc

select depname, dephod, empname, sal from tbl_dept as D inner join tbl_emp as E on D.depid=E.empid

select * from tbl_emp where sal between 50000 and 70000 and empname like '%A%'

--Sql is structured query language and it is not case sensitive. It is used as a database for the backend. RDBMS uses the concept of tables, tables contains rows(fields) and columns(attributes) 