create table person_skill(id INT IDENTITY PRIMARY KEY,person_id int,skill_id int,updated_at DATETIME,    UNIQUE (person_id, skill_id))
insert into person_skill values(111,10,'2021-12-12')
insert into person_skill values(111,10,'2021-12-12')
insert into person_skill values(112,10,'2021-12-12')
insert into person_skill values(111,11,'2021-12-12')

select * from person_skill