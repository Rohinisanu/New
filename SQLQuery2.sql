
create table student
(rollno int primary key,name varchar(30)not null,
age int check(age>18),
mobile bigint unique,
city varchar(30)default'Pune');
insert into student values(1,'Sakshi',21,98705888,'Mumbai');
insert into student(rollno,name,age,mobile)values(2,'Pooja',20,95874566);
insert into student(rollno ,name) values(100,'Sneha');
select * from student;
update student set city='Pune' where name='Pooja';
delete from student where rollno=2;


