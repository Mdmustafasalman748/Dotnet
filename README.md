Dotnet 
-> Dotnet is a language. It makes human work easy.
-> With the help of dotnet we can create any kind of applications such as windows, web, mobile, console
-> Dotnet is language netural (knows more than 1 language)
-> Dotnet support 62+ languages
-> Dotnet provide language interoperability (C# -> F#)
-> Dotnet owns C#, F#, J#, c++ and vb.net rest all are third party languages.

What is Dotnet framework?
-> It is the platform provided by Microsoft, which is used to create any kind of applications using windows.

Why Dotnet?
-> We use dotnet because of its feature namely CLR
Source code -> Complier -> Assembly language (010001) -> CLR -> Windows O.S language

CLR contains:
1. JIT: Just in time - Converts assembly language to windows O.s language
2. Garbage collection - It is the process used to maintain various aspects of memory to prevent memory leaks during program execution.
-> Generations of garbage collection:
Gen 0 : stores short-lived objects
Gen 1: objects from gen 0 live here
Gen 2: stores long-lived objects and Gen 1 objects.
-> Garbage collection deallocates unused memory
3. Memory manager: Manages memory
4. Exception manager: Display errors

SQL:
-> SQL stands for Stuctured query language. It is not case sensitive. It is used as a database for backend.

Database:
-> Database is a collection of structure data.

RBDMS:
-> It is Relational database management system. It is the collection of rows and columns.
-> Table contatins rows (fields) and columns(Attributes).

Full stack contains:
-> Frontend
-> Designing
-> Backend

Authentication:
Authentication means checking the genuinity of the user.

Authorization:
Authorization means defining roles such as Admin, user, guests.

Datatypes in SQL:
1. Integer - 1,2,3,4,0,-1,-2,-3
2. Float - 0.5,1.3,2.4,7.0
3. Varchar - '$24teg&sg#'
4. Date - 12 02 2026
5. Datetime - 12 02 2026 12:11:12

Candidate key:
-> The attribute through which we can findout a row uniquely is known as Candidate key.
-> We can have 'n' number of candidate keys in a table.
-> Candidate key can have null and duplicate values.

Composite candidate key:
-> It is nothing but a candidate key.
-> It is the combination of one or more columns.
-> We can have 'n' number of composite candidate keys in a table.
-> Composite candidate key can have null and duplicate values.

Primary key:
-> It is nothing but a candidate key.
-> The attribute through which we can findout a row uniquely.
-> We can have only one primary key in a table.
-> Primary key will not allow null as well as duplicate values.

Composite Primary key:
-> The combination of one or more columns called composite primary key.
-> We can have only one composite primary key in a table.
-> Composite primary key will not allow null as well as duplicate values.

Unique key:
-> The attribute through which we can findout a row uniquely.
-> It allows only one null value.
-> It will not allow duplicate values.

Foreign key:
-> Foreign key is the primary key of its master table.
-> We can have 'n' number of foreign keys in a table.
-> It allows null as well as duplicate values.

Constraints/Properties of Foreign key:
1. No action: is the child date exists, it will not allow to delete the parent data.
2. Set null: if parent data gets deleted then child data is set to null.
3. Set default: It parent data gets deleted then child data will be assigned a default value.
4. Cascade on delete: if parent data gets deleted then child data will also gets deleted.

There are 4 operations/funtions in any application:
1. Read 2. Insert 3. Update 4. Delete

READ Syntax:
select column_name from table_name

INSERT Syntax:
insert into table_name(column_name, column_name) values(value, value)

UPDATE Syntax:
update table_name
set column_name where(condition)

DELETE Syntax:
delete from table_name
where column_name=..

Aliasing concept 'as'








