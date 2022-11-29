--Student	Stud_id, Sname, Mobile ,Batch_id, Status_id,Year_Of_Pass
--Score	Stud_id,Test_Date,Topic,Marks_Obtained
--(Stud_id,Test_Date-Composite Key)
create table Student
(stud_id int primary key,
sname varchar(20)not null,
mobile bigint unique,
batch_id int,foreign key(batch_id)references Batch(batch_id),
status_id int,foreign key (status_id)references Status(status_id),
year_of_pass year); 

create table Score
(stud_id int,test_date date primary key)7foreign key (stud_id)references Student(stud_id),
topic varchar(20),marks_obtained float not null,

