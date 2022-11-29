create table departments1
(deptid int primary key identity(1,1),deptname varchar(20));

select * from departments1;

create table employee1
(id int primary key identity(1,1),
name varchar(20),city varchar(20),salary decimal,
deptid int,foreign key (deptid)references departments1(deptid));

select * from employee1;

insert into departments1 values('HR');
insert into departments1 values('Development');
insert into departments1 values('Finance');
insert into departments1 values('IT');

insert into employee1 values('Riya','Pune',20000,2);
insert into employee1 values('Diya','Mumbai',50000,3);
insert into employee1 values('Om','Delhi',60000,4);
insert into employee1 values('Omkar','Pune',45000,1);
insert into employee1 values('Shanaya','Nashik',65000,2);
alter table employee1 add managerid int;
update employee1 set managerid=5 where id in(2,3);
update employee1 set managerid=1 where id in(1,4);

select e.*,d.* from employees e inner join departments d on e.department_id=d.department_id;
select e.*,d.* from employees e left join departments d on e.department_id=d.department_id;
select e.*,d.* from employees e right join departments d on e.department_id=d.department_id;
select e.*,d.* from employees e full join departments d on e.department_id=d.department_id;

select * from employees e where department_id=
(select department_id from departments where department_name='Finance');

select max(salary)from employees;
select * from employees where salary=
(select max(salary) from employees);



