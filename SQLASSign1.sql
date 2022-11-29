create table Employee
(empid int primary key,name varchar(20)not null,salary varchar(30),
deptid int,foreign key (deptid)references Department(deptid),magrid int );
select * from Employee;
create table Department
(deptid int primary key,dname varchar(20) not null,city varchar(10));
select * from Department;
insert into Department values(1,'IT','Pune'),(2,'Finance','Mumbai'),(3,'HR','Pune');
insert into Employee values(11,'Nilesh',20000,1,21),(12,'Ramesh',50000,2,21),(13,'Mahesh',55000,3,22),
(14,'Kiran',30000,1,23),(15,'Riya',60000,2,22);
SELECT e.name ,d.dname FROM Employee e INNER JOIN Department d ON e.deptid = d.deptid;
select city from Department d inner join Employee e on d.deptid=e.deptid where e.name='Ramesh';
select count(*)from Employee e inner join Department d on e.deptid=d.deptid group by city;
select * from Employee e inner join Department d on e.deptid=d.deptid where salary<5000;
select top(1) * from Employee order by salary;
Select city as 'city name',count(*) as 'No of Employees' 
from Department inner join Employee 
on employee.deptid = Department.deptid group by Department.deptid, city order by city;

10.	Show city name and total salary of employees working in that city.
select city as 'city name',count(*)as 'salary'
from Department inner join Employee on employee.deptid = Department.deptid group by salary;
