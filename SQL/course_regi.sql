create table TableNation4 (Nation_ID int primary key, Nation_Name varchar(500))
insert into TableNation4 values (1,'India')
insert into TableNation4 values (2,'United-Nation')
insert into TableNation4 values (3,'Nepal')
insert into TableNation4 values (4,'Srilanka')
select * from TableNation4

	

create table TableState4 (State_ID int primary key , State_Name varchar(500), Nation_ID int foreign key (Nation_ID) references TableNation1 )
insert into TableState4 values(101,'Andhra Pradesh',1)
insert into TableState4 values(102,'Panjab',1)
insert into TableState4 values(103,'California',2)
insert into TableState4 values(104,'Florida',2)
insert into TableState4 values(105,'Koshi',3)
insert into TableState4 values(106,'Bagmati',3)
insert into TableState4 values(107,'Colombo',4)
insert into TableState4 values(108,'Ratnapura',4)

select * from TableNation2

select * from TableState2

create table TableCity4 (City_ID int Primary key, City_Name varchar(500), State_Id int foreign key (State_Id) references TableState1 (State_Id))
insert into TableCity4 values (1001,'Visakhapatnam',101)
insert into TableCity4 values (1002,'Vijaywada',101)
insert into TableCity4 values (1003,'Guntur',101)
insert into TableCity4 values (1004,'Amritrsar',102)
insert into TableCity4 values (1005,'Jalandhar',102)
insert into TableCity4 values (1006,'Chandighar',102)
insert into TableCity4 values (1007,'Los Angeles',103)
insert into TableCity4 values (1008,'San Jose',103)
insert into TableCity4 values (1009,'San Diego',103)
insert into TableCity4 values (1010,'Jack Sonville',104)
insert into TableCity4 values (1011,'Miami',104)
insert into TableCity4 values (1012,'Tampa',104)
insert into TableCity4 values (1013,'Damak',105)
insert into TableCity4 values (1014,'Dharan',105)
insert into TableCity4 values (1015,'Biratnagar',105)
insert into TableCity4 values (1016,'Banepa',106)
insert into TableCity4 values (1017,'Bharatpur',106)
insert into TableCity4 values (1018,'Hetauda',106)
insert into TableCity4 values (1019,'Grandpass',107)
insert into TableCity4 values (1020,'Borella',107)
insert into TableCity4 values (1021,'Pettah',107)
insert into TableCity4 values (1022,'Balangoda',108)
insert into TableCity4 values (1023,'Kolonna',108)
insert into TableCity4 values (1024,'Panamure',108)


create table TableCourseRegDetail4 (CourseRegiD int  primary key identity, Categorylnd int ,FullName varchar(500) , Genderlnd int)

 create table TableRegAddress4 (RegAddresslD int identity ,CourseRegiD int foreign key (CourseRegiD) references TableCourseRegDetail (CourseRegiD), NationlD int foreign key (NationlD) references TableNation1  ,StatelD int  , CitylD int )

 create table TableFeeDetail4 (FeelD int identity, CourseReglD int foreign key (CourseReglD) references TableCourseRegDetail , TotalAmount decimal , MinPer decimal , PaidAmount decimal ,BalAmount decimal , PaidDate date)

 
select * from TableCity4

select * from TableNation4

select * from TableState4

 select * from TableCourseRegDetail4
 select * from TableRegAddress4
 select * from TableFeeDetail4

 