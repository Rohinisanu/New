select * from employees
select * from employees  where first_name like '%u%'
select * from employees where first_name like '_a_'
select * from employees where first_name not like '%s%';
select * from employees where last_name not like'a__';
select * from employees where first_name not like['a-s']%
select max(salary)from employees where department_id=6;
select * from departments
select * from employees where salary=19160 or first_name='King';
select * from employees where salary=20000 and first_name='John';
select min (salary)from employees 
select sum(salary)from employees where department_id=7;
select avg (salary)from employees where department_id=9;
select count (salary)from employees where department_id=9;
select count (distinct salary) from employees;
select first_name,count(employee_id) from employees group by first_name;
select hire_date,count(employee_id) from employees group by hire_date having hire_date in(1987-06-17,1989-09-21)order by hire_date

