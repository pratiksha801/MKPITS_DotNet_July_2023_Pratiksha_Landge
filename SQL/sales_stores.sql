create table stores(stores_id INT IDENTITY(1,1)PRIMARY KEY,stores_name varchar(255)NOT NULL,phone varchar(25),email varchar(255),street varchar(255),
city varchar(255),state varchar(10),zip_code varchar(5))
insert into stores(stores_name,phone,email,street,city,state,zip_code)values('mana','1234567890','mana@gmail.com','sadar','nagpur','maharastra','4400')

select * from stores
insert into stores(stores_name,phone,email,street,city,state,zip_code)values('pratu','12300546','pratugmail.com','sadar','nagpur','maharastra','4400')
insert into stores(phone,email) values('3222','ab@gmail.com')
insert into stores(stores_name,phone,email)values('radha','3222','ab@gmail.com')


