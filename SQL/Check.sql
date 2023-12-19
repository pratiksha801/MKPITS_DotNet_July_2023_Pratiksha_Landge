create table product1(product_id INT IDENTITY PRIMARY KEY,product_name varchar(255)NOT NULL,unit_price DEC(10,2)CHECk(unit_price>0))
insert into product1 values('mouse',120)
insert into product1 values('keybord',150)
select * from product1
