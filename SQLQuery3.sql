create table dept
(deptid int primary key,
deptname varchar(30));
create table emp 
(empid int primary key,ename varchar(25),salary int,did int,
constraint fkdid foreign key(did) references dept(deptid)
);