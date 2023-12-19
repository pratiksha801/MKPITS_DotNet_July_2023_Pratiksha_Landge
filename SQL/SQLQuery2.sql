create table products(product_id INT IDENTITY PRIMARY KEY,product_name varchar(255) NOT NULL,unit_price DEC(10,2)CHECK(unit_price > 0),
discounted_price DEC(10,2)CHECK(discounted_price > 0),CHECK (discounted_price < unit_price))
insert into products values('mouse',120,20)
insert into products values('mouse',0,0)
insert into products values('mouse',220,120)
insert into products values('mouse',110,105)
insert into products values('mouse',220,210)
select * from products
