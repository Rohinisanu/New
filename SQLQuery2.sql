create table batch
(batchid int primary key,
batchname varchar(30));
alter table student add batchid int;
select * from batch;
insert into batch values(1,'Wipro'),(2,'HCL');
alter table student1 add batchid int constraint fkbid foreign key(batchid)references batch(batchid);
update student1 set batchid=1;
delete from batch where batchid=4;
delete from batch where batchid=5;