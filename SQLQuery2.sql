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