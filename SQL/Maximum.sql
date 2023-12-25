create table fproduct(productname varchar(20),
                      quantity int,
					  price int)
insert into fproduct values('mouse',10,100)

insert into fproduct values('mou',20,200)

insert into fproduct values('use',30,300)
select * from fproduct

select productname,quantity,price
from fproduct
where price=(
select max(price) as "maximumum quantity"
from fproduct)

select productname,
max(price) as "maximum price"
from fproduct
group by productname
having max(price)>100