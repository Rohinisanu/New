create view vk
as select eid,ename from thinkemp;
select * from vk;
insert into vk values(7,'Komal');
delete from vk where eid=6;

create view vk2
as select * from book b inner join author a on b.authorid=a.aid;
select * from vk2;
drop view vk;
create index idxmarks on student1(marks);
select * from student1 where marks>75;
create table trainer
(tid int primary key,
tname varchar(20),
mobileno bigint);
create unique index uqidx on trainer(mobileno)
where mobileno is not null;
insert into trainer values(1,'Deepa',987654323);
insert into trainer(tid,tname) values(2,'aa');
insert into trainer (tid,tname)values(3,'bb');
select * from trainer;
begin try
begin tran
insert into book values(101,'c++',900,201);
insert into book values(102,'Python',900,202);
commit tran
end try
begin catch
select ERROR_MESSAGE();
rollback tran;
end catch;
