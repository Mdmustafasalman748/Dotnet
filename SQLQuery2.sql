select * from tbl_emp

insert into tbl_emp ( Empname, Empgender, Sal, depid) values ( 'John Doe', 'M', 50000.00, 101);	
insert into tbl_emp ( Empname, Empgender, Sal, depid) values ( 'Jane Smith', 'F', 60000.00, 102);	
insert into tbl_emp ( Empname, Empgender, Sal, depid) values ( 'Alice Johnson', 'F', 55000.00, 101);
insert into tbl_emp ( Empname, Empgender, Sal, depid) values ( 'Bob Brown', 'M', 70000.00, 103);
insert into tbl_emp ( Empname, Empgender, Sal, depid) values ( 'Charlie Davis', 'M', 65000.00, 102);
insert into tbl_emp ( Empname, Empgender, Sal, depid) values ( 'Diana Evans', 'F', 72000.00, 103);
insert into tbl_emp ( Empname, Empgender, Sal, depid) values ( 'Ethan Foster', 'M', 48000.00, 101);

/* Equal to = , Not equal to <> */
/*Write a query to get the female employees*/
select * from tbl_emp where Empgender = 'F'
select * from tbl_emp where Empgender <> 'm'

/*Write a query to get all employees whose salary is less than 50000*/
select * from tbl_emp where sal<50000

/*Write a query to get all employees whose salary is less than 70000 and greater than 50000*/
select * from tbl_emp where sal >50000 and sal <70000
/*use between operator*/
select * from tbl_emp where sal between 50000 and 70000

/*Write a query to get male employee whose salary is less than 40000 and greater than 50000*/
select * from tbl_emp where empgender='m' and sal between 40000 and 50000

/*Write a query to get male employee whose name starts with J*/
/*Like operator*/
select * from tbl_emp where empgender='m' and empname like 'J%'

/*Write a query to get all employees whose name starts with A*/
select * from tbl_emp where empname like 'A%'

/*Write a query to get all employees whose name ends with n*/
select * from tbl_emp where empname like '%N'

/*Write a query to get all employees whose name contains 'R'*/
select * from tbl_emp where empname like '%R%'

/*Write a query to get details of female employees whose name starts with N*/
select * from tbl_emp where empgender='f' and empname like 'N%'

/*Write a query to display only 10 records of the organization*/
/* use in operator*/
select * from tbl_emp where empid in (101, 102, 103, 104, 105, 106, 107, 108, 109, 110)

/*Write a query to get the details of employees whose id is 104 and 107	*/
select * from tbl_emp where empid=104 and empid=107
select * from tbl_emp where empid in(104,107)
/*for not in, use not in*/
select * from tbl_emp where empid not in(104,107)

/*Write a query to display all records whose commission is null*/
/* insert into tbl_emp where comm=null */
/*use is null operator*/
/*insert into tbl_emp where comm is null*/

/*Write a query to get details of all employees whose salary is greater than 50000 and less than 70000 and whose commission is null*/
/* select * from tbl_emp where sal between 50000 and 70000 and comm is null*/

/*Write a query to get details of all employees whose commission is not null*/
/*select * from tbl_emp where comm is not null*/

/*For pronounciation*/
update tbl_emp set empname='kevin' where empid=102

select * from tbl_emp where SOUNDEX(Empname) = SOUNDEX('kevn')

update tbl_emp set empname='smith' where empid=104

select * from tbl_emp where SOUNDEX(Empname) = SOUNDEX('smth')
