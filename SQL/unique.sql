create table persons(prsons_id INT IDENTITY PRIMARY KEY, first_name varchar(255)NOT NULL,last_name varchar(255)NOT NULL,email varchar(255) UNIQUE);
insert into persons values('amit','kumar','a@gmail.com')
insert into persons values('amit','sharma','a@gmail.com')
insert into persons values('pratu','reddy','p@gmail.com')
insert into persons values('payal','khana','p@gmail.com')
insert into persons values('prachi','roy','d@gmail.com')

select * from persons
 
