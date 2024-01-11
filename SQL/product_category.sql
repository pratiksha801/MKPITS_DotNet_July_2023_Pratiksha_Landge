create table tableproductcategory(product_category_id int primary key,product_type_name varchar(20),
                                  product_gst_id int)

insert into tableproductcategory values(1001,'computers',602)
insert into tableproductcategory values(1002,'mobile',604)
insert into tableproductcategory values(1003,'printers',603)
insert into tableproductcategory values(1004,'Ac and fridge',607)

select * from tableproductcategory
