create table empinfo(name varchar (20) NOT NULL,
                     occupation varchar(20) NOT NULL,
					 working_hours int,
					 salary int)
insert into empinfo values('Abhi','manager',9,900000)

insert into empinfo values('Pratu','clerk',5,100000)

insert into empinfo values('Payal','associative',4,800000)

insert into empinfo values('Harshu','team leader',3,500000)

select * from empinfo

select avg(working_hours) as " average working_hours"
from empinfo

select avg(salary) as" average salary"
from empinfo