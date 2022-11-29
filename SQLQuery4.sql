
select first_name,department_name,job_title from employees e inner join departments d on e.department_id=d.department_id
inner join jobs j on e.job_id=j.job_id;
select first_name,employees.job_id from employees inner join jobs on employees.job_id=jobs.job_id;
--select sname,batchname,tname from student s inner join batch b on s.batch_id=b.batch_id
--inner join trainer t on b.tid=t.tid;
select * from book b left join author a on b.authorid=aid;
select * from book b right join author a on b.authorid=aid;
select * from book b full join author a on b.authorid=aid;
create table thinkemp
(eid int primary key,ename varchar(20) not null,
salary int, managerid int,
foreign key (managerid)references thinkemp(eid));

select e.ename'Empname'm.ename 'Manager' from thinkemp inner join thinkemp m on e.managerid=m.eid;
