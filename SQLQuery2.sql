/*select query*/
/*select column_name from table_name*/
select depname from tbl_dept
select depname,dephod from tbl_dept
select * from tbl_dept

/*insert query without column*/
/*insert into table_name values(value1,value2,value3)*/
insert into tbl_dept values('Java', 'Jimmy', 'Ottawa')

/*inset query with column*/
/*insert into table_name(column1,column2,column3) values(value1,value2,value3)*/
insert into tbl_dept(Depname, Dephod, Loc) values('C++', 'John', 'Toronto')

/*update query*/
/*update table_name set column1=value1,column2=value2 where condition*/
update tbl_dept set depname = 'C#'where depid = 101

/*delete query*/
/*delete from table_name where condition*/
delete from tbl_dept where depid = 113

select * from tbl_dept