select * from tbl_dept
Select * from tbl_emp

select * from tbl_emp 
where empgender='f'
order by sal desc

select depname, dephod, empname, sal from tbl_dept as D inner join tbl_emp as E on D.depid=E.empid

select * from tbl_emp where sal between 50000 and 70000 and empname like '%A%'