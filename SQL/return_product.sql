create table products(productname varchar(20)NOT NULL,
quantity int NOT NULL,
price int NOT NULL)
insert into products values('pen',5,50)
insert into products values('book',2,20)
insert into products values('pencil',4,40)
select * from products

create function f1()
returns table
as 
return (select * from product)

select * from products
