create proc SP_insert_departments(
@department_name varchar(20)
)
as begin
insert into departments values(@department_name)
return
end
-- alter  is used to modify the existing proc
alter proc SP_insert_departments(
@department_name varchar(20)
)
as begin
insert into departments values(@department_name)
return
end


-- call the SP

exec SP_insert_dept
@deptname='Account'

select * from employees

create proc SP_select_employees(
@id int
)
as begin
select * from employees where employee_id=@id
return 
end

exec SP_select_employees
@id=10

--Write SP for update the dept
--Write SP for delete the dept
create  proc SP_insert_department(
@department_name varchar(20)
)
as begin
update departments set department_name='Testing' where department_id=4
return
end
create proc SP_delete_dept(
@department_name varchar (20))
as begin
delete from departments where department_id=4
return
end
select *from departments

create proc SP_update_dept(
@deptname varchar(20),
@deptid int
)
as begin
update departments set department_name=@deptname where department_id=@department_id
return
end

exec SP_update_dept
@department_name='test2'
@department_id=5

create proc SP_delete_dept1(
@deptid int
)
as begin
delete from departments where department_id=@department_id
return
end

exec SP_delete_dept1
@department_id=5

-- substring

select SUBSTRING(first_name,1,3) as Tempname from employees where employee_id=1

--concat
select CONCAT(first_name,' ',hire_date) as tempcol from employees
--len
select first_name,len(first_name) as LengthOFName from employees
--upper
select UPPER(last_name) from employees
select LOWER(last_name) from employees
--' Amol'
select LTRIM(first_name) from employees
--'Amol  '
select RTRIM(first_name) from employees
--'  Amol  '
select TRIM(last_name) from employees

select ROUND(salary,2) as Salary from employees

create function check_name_emp
( @first_name varchar(20)
)
returns varchar(5) as
begin
declare @return_value varchar(5);
if(len(@first_name)<5) set @return_value='false';
else set @return_value ='true';

return @return_value
end

select first_name ,dbo.check_name_emp(first_name) from employees


create function add_salary_employee
(
@salary decimal
)
returns decimal 
as begin
declare @newSalary decimal;
set @newSalary =@salary +1350;
return @newSalary
end

select first_name, salary , dbo.add_salary_employee(salary) from employees

alter function add_salary_employee
(
@salary decimal
)
returns decimal 
as begin
declare @newSalary decimal;
set @newSalary =@salary +1350;
return @newSalary
end



