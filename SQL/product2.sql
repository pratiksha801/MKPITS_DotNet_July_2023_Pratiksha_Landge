create table product2(ord_no int,purch_amt float,ord_date date,coustomer_id int,salesman_id int)
insert into product2 values(70001,150.5,'2012-10-05',3005,5002)
insert into product2 values(70009,270.65,'2012-09-10',3001,5005)
insert into product2 values(70002,65.26,'2012-10-05',3002,5001)
insert into product2 values(70004,110.5,'2012-08-17',3009,5003)
insert into product2 values(70007,948.5,'2012-09-10',3005,5002)
insert into product2 values(70005,2400.6,'2012-07-27',3007,5001)

select * from product2
select ord_date,salesman_id,ord_no,coustomer_id,purch_amt from product2
order by ord_date,salesman_id,ord_no,coustomer_id,purch_amt



