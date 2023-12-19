create table products(product_id INT IDENTITY PRIMARY KEY,products_name varchar(255) NOT NULL,unit_price DEC(10,2),discounted_price DEC(10,2),CHECK(unit_price > 0),
CHECK(discounted_price > 0),CHECK(discounted_price > 0),CHECK(discounted_price > unit_price))
insert into products values('mouse',120,40)
insert into products values('keybord',110,60)
insert into products values('shift',100,20)

select * from products



