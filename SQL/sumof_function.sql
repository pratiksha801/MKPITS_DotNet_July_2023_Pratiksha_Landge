create table fstudent (rno int, fdate date ,amount int)
insert into fstudent values(1,'2020-2-1',200000)
insert into fstudent values(2,'2021-3-2',500000)
insert into fstudent values(3,'2022-5-3',600000)

select * from fstudent
select sum(amount) as "sum of amount"
from fstudent
group by rno
drop table fstudent



