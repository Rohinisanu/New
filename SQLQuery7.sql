select * from employees e1 where 3=(select count (distinct(salary))from employees e2 where e2.salary>=e1.salary);