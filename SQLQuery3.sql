/*Aggregate functions - It will give single window output*/
/*1. Count() - It will give the count of records*/
/*2. Sum() - It will give the sum of records*/
/*3. Avg() - It will give the average of records*/
/*4. Min() - It will give the minimum of records*/
/*5. Max() - It will give the maximum of records*/

/*Clausers - It will give the records based on the condition*/
/*1. Where - for filtering the records based on the condition*/
/*2. group by - when we have aggragate function with normal column*/
/*3. having - whenever we have filteration/condition on aggregate function*/
/*4. order by - for sorting the records in ascending or descending order*/

/*Write a query to get the number of employees of each department*/
select count(empid) as NOE, depid from tbl_emp

/*Write a query to get employee name, gender and salary of male employee*/
select empname, empgender, sal from tbl_emp where empgender='m'

/*Write a query to get the details of department who have more than 3 male employees in desc order*/
select count(empid) as NOE, depid from tbl_emp where empgender='m'
group by depid
having Count(empid)>3
order by NOE desc

/*Write a query to get the details of salary of female employees whose sum of salary should be greater than 100000 and arrange them in descending order*/
select sum(sal) as SOS, sal from tbl_emp where empgender='f' 
group by sal
having sum(sal)>100000
order by SOS desc

/*Write a query to get the details of female employees and arrange them by salary in descending order*/
select * from tbl_emp where Empgender='f' 
order by sal desc

/*To know the hishest salary we use top(1)*/
select top(1) * from tbl_emp order by sal desc

/*Write a query to get thte highest salary of male employee*/
select top(1) * from tbl_emp where empgender='m' order by sal desc

/*If more than 1 person with same salary then we use top() with ties*/
select top(1) with ties * from tbl_emp where empgender='m' order by sal desc

/*Write a query to get the number of employees, sum of salary of male employees*/
select count(empid) as NOE, sum(sal) as SOS from tbl_emp where Empgender='m'
order by NOE desc