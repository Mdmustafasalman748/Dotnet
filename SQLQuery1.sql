/*select column_name from table_name*/

select depname, dephod from tbl_dept
select depid, depname, dephod from tbl_dept
select * from tbl_dept

/*Insert query without column names*/
/*insert into table_name values(value1, value2, value3)*/

insert into tbl_dept values('Ruby','David','alex')

/*Insert query with column names*/
insert into tbl_dept (depname) values ('css')
insert into tbl_dept (depname, dephod) values ('Python','Smith')

/* Update query*/
/*update table_name set column1=value1, column2=value2 where condition*/

update tbl_dept set depname='HTML'
where depid=106

update tbl_dept set dephod='Mickel' where depid=105

/*Delete query*/
/*delete from table_name where condition*/

delete from tbl_dept where depid=106

select * from tbl_dept

