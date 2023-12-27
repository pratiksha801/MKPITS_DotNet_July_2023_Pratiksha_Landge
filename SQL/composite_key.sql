CREATE TABLE student1
(rollNumber INT, 
name VARCHAR(30), 
class VARCHAR(30), 
section VARCHAR(1), 
mobile VARCHAR(10),
PRIMARY KEY (rollNumber, mobile));

insert into student1 values(1,'amit','dotnet','i','1234567890')
insert into student1 values(1,'amit','dotnet','i','1234567891')

select * from student
