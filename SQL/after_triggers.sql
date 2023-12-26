create trigger empu
on employee1
after update
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'update',GETDATE() from deleted

select * from employee1
update employee1 set empname='amitabh' where empid=11

select * from employee1
select * from EmpLog

select * from dbo.EMPLOG
   

