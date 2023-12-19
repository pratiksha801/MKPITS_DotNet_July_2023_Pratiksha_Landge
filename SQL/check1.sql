create table product(product_id INT IDENTITY PRIMARY KEY,product_name varchar(255)NOT NULL,unit_price DEC(10,2)CONSTRAINT positive_price Check(unit_price > 0))
insert into product values('pratu',10)
insert into product values('payal',0)
delete from product
select * from product
