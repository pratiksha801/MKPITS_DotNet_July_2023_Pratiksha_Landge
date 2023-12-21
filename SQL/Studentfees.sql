   
create table customers1(id int, name varchar(20),phone bigint)

insert into customers1 values(1,'Abhi','9096569768')
insert into customers1 values(2,'Pratu','9884539709')
insert into customers1 values(3,'Payal','8004565201')
insert into customers1 values(4,'Haeshu','9563428720')
select * from customers1

create table orders1(ord_id int,ord_date varchar(20),id int,prd_name varchar(20),qty int,rate int)
insert into orders1 values(1,'20-11-2023',1,'pen',10,20)
insert into orders1 values(2,'10-11-2023',3,'pencil',20,20)
insert into orders1 values(3,'25-11-2023',2,'eraser',5,10)
select * from customers1
select * from orders1

select customers1.id,customers1.name,customers1.phone,orders1.ord_id,orders1.ord_date,orders1.prd_name,
orders1.qty,orders1.rate
from customers1
inner join orders1
on customers1.id=orders1.id
 

