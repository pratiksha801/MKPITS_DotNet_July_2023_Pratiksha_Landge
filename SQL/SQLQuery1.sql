create table tableinvoicedetail(invoice_details int Identity,
                               customer_name varchar (20) not null,
							   customer_contact int not null,
							   Product_ID int,
							   Product_category_ID int,
							   residential_type_id int,
							   Quentity decimal,
							   Price decimal,
							   cgst decimal,
							   sgst decimal,
							   igst decimal,
							   cgst_value decimal,
							   sgst_value decimal,
							   igst_value decimal,
							   TotalAmount decimal,
							   FOREIGN KEY (Product_Category_ID) REFERENCES Product_category(product_category_id),
							   FOREIGN KEY (Product_ID) REFERENCES TableProduct(product_id))

create table TableProduct(product_id int Primary key,
                          product_name varchar(20)not null,
						  product_category_id int,
						  product_price int,
						  foreign key (product_category_id) references Product_category(product_category_id))

insert into tableproduct values(210,'Apple',1002,40000)
insert into tableproduct values(211,'Lenevo',1002,25000)
insert into tableproduct values(212,'Samsung',1003,50000)
insert into tableproduct values(213,'IFB',1004,20000)
insert into tableproduct values(214,'LG',1004,30000)
insert into tableproduct values(215,'Sony',1001,60000)

select * from tableinvoicedetail
select * from Product_category
select * from TableProduct
select * from product_GST_details

drop table tableinvoicedetail
drop table TableProduct

