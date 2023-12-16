create table vendors_groups(group_id int identity primary key,group_name varchar(20)not null);
create table vendors(vendors_id int identity primary key,vendor_name varchar(100)not null,
groups_id int not null);
drop table vendors;
create table vendors(vendor_id int identity primary key,vendor_name varchar(100) not null,
groups_id int not null,
constraint fk_groups foreign key(groups_id) references vendors_groups(group_id));
select * from vendor_groups
insert into vendors(vendor_name,groups_id) values('amit',123)
insert into vendor_groups values('mkpits')
select * from vendor_groups
insert into vendors(vendor_name,groups_id) values('amit',1)
select * from vendors
insert into vendors(vendor_name,groups_id) values('arjun',2)
insert into vendor_groups values('niit')
select * from vendor_groups
insert into vendors(vendor_name,groups_id) values('arjun',2)
select * from vendors
insert into vendors(vendor_name,groups_id) values('arpita',2)
select * from vendors





