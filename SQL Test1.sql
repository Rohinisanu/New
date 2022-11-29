Create database Hospital;
create table Doctor
(did int primary key,
dname varchar(20) not null,
daddress varchar(30),
qualification varchar(10),
noofpatient_handled int );
select * from  Doctor;
create table PatientMaster
(pcode int primary key,
pname varchar(20) not null,
paddr varchar(30),
age int check (age>20),
gender char(1),
bloodgroup varchar(10));
select * from PatientMaster;
create table AdmittedPatient
( pcode int,foreign key (pcode)references PatientMaster(pcode),
Entry_date date,Discharge_date date,
wardno int primary key,disease varchar(10),
did int,
foreign key (did) references Doctor(did));
select * from AdmittedPatient;
create table Bill
(Billno int primary key,
pcode int,
foreign key (pcode) references PatientMaster(pcode),
bill_amount bigint);
select * from Bill;
alter table AdmittedPatient add Discharge_date date;
alter table AdmittedPatient alter column wardno varchar(10);
alter table AdmittedPatient drop constraint [FK__AdmittedP__pcode__3B75D760]
 add foreign key (did) references Doctor(did)on delete set null on update cascade);
 alter table PatientMaster drop constraint [PK__PatientM__293812AAB86E77B9]
 alter table PatientMaster add primary key(pcode);
 insert into Doctor values(1,'Ahire','Nashik','MS',5);
 insert into Doctor values(2,'Bhole','Nashik','MS',5);
 insert into Doctor values(3,'Gangane','Nashik','MS',5);
 insert into Doctor values(4,'Jadhav','Nashik','MS',5);
 insert into Doctor values(5,'Vaje','Nashik','MS',5);
 select * from Doctor where qualification='MS';
 insert into PatientMaster values(10,'Rohini','Nashik',21,'f','A+');
 insert into PatientMaster values(11,'Shanaya','Nashik',27,'f','AB+');
 insert into PatientMaster values(12,'Om','Nashik',25,'M','O+');
 insert into PatientMaster values(13,'Omkar','Nashik',22,'M','A-');
 insert into PatientMaster values(14,'Jaya','Nashik',24,'M','o-');

 select * from PatientMaster where bloodgroup='A+'and age between 21 and 27;
 select * from Doctor where daddress='Mumbai'and noofpatient_handled=10;
 --select * from PatientMaster where bloodgroup='A+'%
 select * from Doctor where noofpatient_handled>10;
 select * from PatientMaster where paddr='pune';
 select *from PatientMaster where bloodgroup='AB+'and gender='f';
 insert into AdmittedPatient values(10,2020-04-24 ,2020-05-24,4,'covid19',1);
 insert into AdmittedPatient values(10,2020-04-27 ,2020-05-27,1,'covid19',2);
 insert into AdmittedPatient values(10,2021-05-24 ,2021-05-29,3,'Malaria',2);
 insert into AdmittedPatient values(10,2021-08-20 ,2021-09-02,6,'Dengue',3);
 insert into AdmittedPatient values(10,2022-08-24 ,2022-09-06,2,'Typhoid',5);
 select * from AdmittedPatient;
 delete from AdmittedPatient where wardno between 4 and 6 and disease='covid19';
 select * from AdmittedPatient where disease='Dengue';










