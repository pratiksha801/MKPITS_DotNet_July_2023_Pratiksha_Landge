create table fproduct(productname varchar(20)NOT NULL,
quantity int NOT NULL,
price int NOT NULL)
insert into fproduct values('computer',10,100)
insert into fproduct values('laptop',20,200)
insert into fproduct values('iphone',40,400)
insert into fproduct values('smartphone',50,500)
select * from fproduct 
select productname,
min(price) as "minimum price"
from fproduct
group by productname
having min(price)> 300
drop table fproduct