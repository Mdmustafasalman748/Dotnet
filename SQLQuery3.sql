--select column_name from table_name
select depname, dephod from tbl_dept
--insert into table_name values (value1, value2, ...)
insert into tbl_dept values (5, 'Research', 'Dr. Smith', 'Building A')
--insert into table_name (column1, column2, ...) values (value1, value2, ...)
insert into tbl_emp(Empname, Empgender, Sal, Depid, Comm) values ('John Doe', 'M', 60000.00, 5, 5000.00)
--update table_name set column1 = value1, column2 = value2, ... where condition
update tbl_dept set dephod='Dr. Johnson' where depid = 105
--delete from table_name where condition
delete from tbl_dept where depid=105

select * from tbl_emp where empgender='f'
select * from tbl_emp where empgender<>'m'

select * from tbl_emp
where sal<5000

select * from tbl_emp
where sal between 2000 and 3000

select * from tbl_emp
where empgender='m' and sal between 3000 and 5000

select * from tbl_emp
where empgender='m' and empname like 'N%'

select * from tbl_emp
where empname like 'W%'

select * from tbl_emp
where empname like '%N'

select * from tbl_emp
where empname like '%R%'

select * from tbl_emp
where empgender='f' and empname like 'N%'

select * from tbl_emp
where empid in(101,102,103,104,105,106,107,108,109,110)

select * from tbl_emp 
where empid in(7369, 7499)

select * from tbl_emp
where comm is null

select * from tbl_emp
where sal between 2000 and 5000 and comm is null

select * from tbl_emp
where comm is not null

select * from tbl_emp
where SOUNDEX(empname) = SOUNDEX('kvin')

select count(empid) as NOE, depid from tbl_emp
group by depid

select empname, empgender, sal from tbl_emp
where empgender='m'

select count(Empid) as NOE, depid from tbl_emp
group by depid
having count(empid) >3
order by NOE desc

select sum(sal) as SOS, sal from tbl_emp
where empgender='f'
group by sal
having sum(sal) > 10000
order by SOS desc

select * from tbl_emp
where empgender='f'
order by sal desc

select top(1) * from tbl_emp
where empgender='m'
order by sal desc

select top(1) with ties * from tbl_emp
where empgender='m'
order by sal desc

select count(empid) as NOE, sum(sal) as SOS from tbl_emp
where empgender='m'