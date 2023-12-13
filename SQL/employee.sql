create table employee(empid int primary key identity(1,1),empname varchar(20))
insert into employee(empname) values('ravi')
insert into employee(empname) values('rajesh')
select * from employee
delete from employee where empid=1
insert into employee(empname) values('rajesh123')
delete from employee

insert into employee(empname) values('rajesh123')
select * from employee 
