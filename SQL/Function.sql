create table fproduct1(productname varchar(20)NOT NULL,
quantity int NOT NULL,
price int NOT NULL)
insert into fproduct1 values('computer',10,100)
insert into fproduct1 values('laptop',20,200)
insert into fproduct1 values('iphone',40,400)
insert into fproduct1 values('smart phone',50,500)
select * from fproduct1 
select productname,quantity,price from fproduct1
where price=(
select max(price) as"minimum quantity" from fproduct1)
drop table fproduct1
