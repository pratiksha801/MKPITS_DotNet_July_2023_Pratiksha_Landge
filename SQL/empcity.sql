create table employee(empid int ,emp_contact int NOT NULL,empname varchar(20)NOT NULL, city varchar(20)NOT NULL)
insert into employee values(1,123,'amit','nagpur')
insert into employee values(2,222,'pratu','mumbai')
insert into employee values(3,.,333,'payal','nagpur')

select * from employee

    create function fun_JoinEmpColumnInfo  
    (  
       @EmpContact nchar(15),  
       @EmpEmail nvarchar(50),  
       @EmpCity varchar(30)  
    )  
    returns nvarchar(100)  
    as  
    begin return(select @EmpContact+ ' ' +@EmpEmail + ' ' + @EmpCity)  
    end
	


