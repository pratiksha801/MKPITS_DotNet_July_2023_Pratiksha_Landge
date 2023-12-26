create table employee1 (empid int primary key, empname varchar(20))
CREATE TABLE EmpLog 
	(LogID int IDENTITY(1,1) NOT NULL,
	EmpID int NOT NULL,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL)	

create trigger empt 
on employee1
for insert 
as insert into
EMPLOG(EMPID,Operation,UpdatedDate)
select empid,'insert',GETDATE() from inserted; 
insert into employee1 values(11,'amita')
 select * from employee1
 select * from EMPLOG

 insert into employee1 values(12,'pratu')
 select * from employee1
 select * from EMPLOG	
