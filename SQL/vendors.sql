create table vendors_groups(vendor_id Int Identity Primary Key,vendor_name varchar(20),group_id int not null);
create table vendors(vendor_id Int Identity Primary key,vendor_name varchar(100) Not Null,group_id Int Not Null)
select * from vendors_groups
insert into vendors(vendor_name,group_id) values('amit',123)
select * from vendors
insert into vendors(vendor_name,group_id) values('pratu',124)
select * from vendors