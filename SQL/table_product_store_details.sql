create table tableproductgstdetail(product_gst_id int not null,
                                  gst_detail_name varchar(20) not null,
								  cgst int not null, sgst int ,igst int )

insert into tableproductgstdetail values(601,'AC and fridge',14,14,14)
insert into tableproductgstdetail values(602,'Computers',9,9,9)
insert into tableproductgstdetail values(603,'Printers',9,9,9)
insert into tableproductgstdetail values(604,'Mobiles',6,6,6)

select * from tableproductgstdetail

