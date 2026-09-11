/*Write a query to get second highest salary*/
select top(1) * from tbl_emp
where sal not in (select max(sal) from tbl_emp)
order by sal desc

/*Write a query to get name of person with min salary*/
select * from tbl_emp
where sal in (select min(sal) from tbl_emp)

select empname, sal from tbl_emp
where sal in (select min(sal) from tbl_emp)

/*Date functions*/
/* To get date -> slect GetDate()
selcet Dateadd(DD,10, GetDate()) -- To add 10 days
select Dateadd(MM,10, GetDate()) -- To add 10 months
select Dateadd(YY,10, GetDate()) -- To add 10 years
select Dateadd(HH,10, GetDate()) -- To add 10 hours
select Dateadd(MI,10, GetDate()) -- To add 10 minutes
For 10 days backwards
select Dateadd(DD,-10, GetDate()) -- To subtract 10 days
For data of birth
select Datediff(YY, '1990-01-01', GetDate()) -- To get age in years
*/

/*Write a wuery to get the experience of smith*/
select Datediff(YY, Hiredate, Getdate()) as Exp from tbl_emp where empname='Smith'

/*Write a Query to get the experience of female employees with thier names*/
select Datediff(YY, Hiredate, Getdate()) as Exp, Empname from tbl_emp where empgender='f'

/*Use Case
Whenever we have condition on a particular column then we use case*/
select Empname, Empgender, case when Empgender='m' then 'MR' 
when Empgender='f' then 'MRS' end as Title from tbl_emp

/*Write a query to get the details of the department id is null then make it as zero. If department id is not null then show depid*/
select Depid, case when Depid is null then 0
when depid is not null then Depid end as Did from tbl_emp

/*Write a query to check eligibility if the experience is less than 5 years then beginner, if experience is greater than 5
and less than 10 years then intermediate and if experience is greater than 10 years then expert*///
select empname, case when datediff(YY,Hiredate,Getdate()) < 5 then 'Beginner'
when datediff(YY, Hiredate, Getdate()) > 5 and datediff(YY, Hiredate, Getdate()) < 10 then 'Intermediate'
when datediff(YY, Hiredate, Getdate()) > 10 then 'Expert' end as Eligibility from tbl_emp

/*Joins - Join caluse is used to combine rows from two or more tables, based on a related column between them
Left outer join - Complete data from left table and matching data from right table
Right outer join - Complete data from right table and matching data from left table
Cross Join - It is used to combine each row of one table with each row of another table, and return the cartesion product
of the sets of rows from the tables that are joined 
Full outer join - complete data from both the tables
Inner Join - Matching data from both the tables*/

/*Write a query to get employee name, salary and department name of an organization*/
select empname, sal, depname from tbl_emp as E inner join tbl_dept as D on E.depid=D.depid

/*Write a query to get depname, dephod, emp salary and empname of an organization*/
select depname, dephod, empname, sal from tbl_dept as D inner join tbl_emp as E on D.depid=E.depid

select E.empname, E.sal, D.depname, D.dephod from tbl_emp as E inner join tbl_dept as D on E.depid=D.depid

/*Write a query to get employee name, sum of salary, department name of male employees and whose sum of salary
should be greater than 50,0000. Arrange them in descending order.*/
select empname, sum(sal) as SOS, depname from tbl_emp as E inner join tbl_dept as D on E.depid=D.depid 
where empgender='m'
groupby empname, depname
having sum(sal) > 50000
order by desc

/*Normalization - Breaking the table into multiple tables is called normalizatin*/
/*Store procedure - It will complie the code once and will execute the code 'n' number of times
To read data: 
--complie
*/
create sp_getdeptdetails
as 
select * from tbl_dept

--execute
exec sp_getdeptdetails

--To insert data
insert proc sp_insertdeptdetails
as 
insert into tbl_dept
values ('Test','Smith')
exec sp_insertdeptdeatails

--Taking input from user
create proc sp_insertdeptdetails-VI
@Depname varchar(100), @Dephod varchar(100)
exec sp_insertdeptdetails_VI 'Test1','Smith1'

--To begin transaction
begin trans
exec sp_updateddeptdetails-VI 'Test1','Smith1'
--commit -> It will effect the database
--rollback -> It will revoke the transaction
--alter -> It will change the existing data,in other words update
-- delete -> It will delete the data but will not delete the memory
-- Truncate -> It will delete the table and recreate it
-- drop -> It will permanently delete the table 

--View in SQL
--View is a virtual table based on the result-set (output) of an SQL statement 

create view department as 
select depname, dephod from tbl_dept

create view vw_getdeptdetails
as 
select * from tbl_dept

select * from vw_getdeptdetails

create view as_getcolumnsfromtwotables
asa
select depname, salary from tbl_emp as e join tbl_dept as d on e.tbl_depid=d.depid 

select * from sp_getcolumnsfrom twotables