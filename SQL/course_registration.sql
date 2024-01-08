create table TableNation1 (Nation_ID INT PRIMARY KEY, Nation_Name varchar(500))
insert into TableNation1 values (1,'India')
insert into TableNation1 values (2,'United-Nation')
insert into TableNation1 values (3,'Nepal')
insert into TableNation1 values (4,'Srilanka')
select * from TableNation1



create table TableState1 (State_ID Int primary key , State_Name varchar(500), Nation_ID int foreign key (Nation_ID) references TableNation1 )
insert into TableState1 values(101,'Andhra Pradesh',1)
insert into TableState1 values(102,'Panjab',1)
insert into TableState1 values(103,'California',2)
insert into TableState1 values(104,'Florida',2)
insert into TableState1 values(105,'Koshi',3)
insert into TableState1 values(106,'Bagmati',3)
insert into TableState1 values(107,'Colombo',4)
insert into TableState1 values(108,'Ratnapura',4)

select * from TableNation1

select * from TableState1

create table TableCity (City_ID Int Primary Key, City_Name varchar(500), State_Id int foreign key (State_Id) references TableState1 (State_Id))
insert into TableCity values (1001,'Visakhapatnam',101)
insert into TableCity values (1002,'Vijaywada',101)
insert into TableCity values (1003,'Guntur',101)
insert into TableCity values (1004,'Amritrsar',102)
insert into TableCity values (1005,'Jalandhar',102)
insert into TableCity values (1006,'Chandighar',102)
insert into TableCity values (1007,'Los Angeles',103)
insert into TableCity values (1008,'San Jose',103)
insert into TableCity values (1009,'San Diego',103)
insert into TableCity values (1010,'Jack Sonville',104)
insert into TableCity values (1011,'Miami',104)
insert into TableCity values (1012,'Tampa',104)
insert into TableCity values (1013,'Damak',105)
insert into TableCity values (1014,'Dharan',105)
insert into TableCity values (1015,'Biratnagar',105)
insert into TableCity values (1016,'Banepa',106)
insert into TableCity values (1017,'Bharatpur',106)
insert into TableCity values (1018,'Hetauda',106)
insert into TableCity values (1019,'Grandpass',107)
insert into TableCity values (1020,'Borella',107)
insert into TableCity values (1021,'Pettah',107)
insert into TableCity values (1022,'Balangoda',108)
insert into TableCity values (1023,'Kolonna',108)
insert into TableCity values (1024,'Panamure',108)

select * from TableCity

select * from TableNation1

select * from TableState1
