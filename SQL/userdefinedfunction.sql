create table products(product_id int identity, region  varchar(50),product varchar(50),productyr varchar(10),quantitiy int ,price int);
insert products values('East','Computer','2020',130,50000),
('South','Computer','2020',450,50000), 
('North','Computer','2020',250,35000), 
('East','Hard Disk','2020',190,40000), 
('West','Computer','2021',250,5500), 
('South','Hard Disk','2021',550,4400), 
('West','Hard Disk','2021',650,7500), 
('East','Pen Drive','2021',120,800), 
('North','Mouse','2019',160,1500), 
('South','Pen Drive','2019',270,750), 
('East','Mouse','2019',2000,1200), 
('West','Pen Drive','2019',190,650);
select *from products
create function select1()
returns table as
return(select * from products)
select * from select1()